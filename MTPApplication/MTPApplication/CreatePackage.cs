using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTPApplication
{
    public partial class CreatePackage : Form
    {
        MTPDbContext context = new MTPDbContext();
        private Point _imageLocation;
        private bool _isDragging;
        private PictureBox _imageBox;
        private bool isDragging = false;
        private int dragStartPosition = -1;
        private Point lastMousePosition;

        [DllImport("user32.dll")]
        static extern bool SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.IDispatch)] object lParam);


        public CreatePackage()
        {
            InitializeComponent();
            SetupRichTextBox();
            this.Height = 1000;
            this.Width = 800;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
        }

        private void SetupRichTextBox()
        {
            introductiontextbox.AllowDrop = true;
            introductiontextbox.MouseDown += RichTextBox_MouseDown;
            introductiontextbox.MouseMove += RichTextBox_MouseMove;
            introductiontextbox.MouseUp += RichTextBox_MouseUp;
        }

        private void RichTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            dragStartPosition = introductiontextbox.GetCharIndexFromPosition(e.Location);
            if (IsPositionInImage(dragStartPosition))
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void RichTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            //if (isDragging)
            //{
            //    int deltaX = e.X - lastMousePosition.X;
            //    int deltaY = e.Y - lastMousePosition.Y;

            //    MoveImage(dragStartPosition, new Point(deltaX, deltaY));

            //    lastMousePosition = e.Location;
            //}
        }

        private void RichTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            dragStartPosition = -1;
        }

        private bool IsPositionInImage(int position)
        {
            introductiontextbox.Select(position, 1);
            return introductiontextbox.SelectionType == RichTextBoxSelectionTypes.Object;
        }

        private void MoveImage(int startPosition, Point offset)
        {
            const int WM_USER = 0x0400;
            const int EM_GETOLEINTERFACE = WM_USER + 60;

            SendMessage(introductiontextbox.Handle, EM_GETOLEINTERFACE, 0, null);

            introductiontextbox.Select(startPosition, 1);
            if (introductiontextbox.SelectionType == RichTextBoxSelectionTypes.Object)
            {
                // Copy the image
                introductiontextbox.Copy();

                // Calculate new position
                Point currentPos = introductiontextbox.GetPositionFromCharIndex(startPosition);
                Point newPos = new Point(currentPos.X + offset.X, currentPos.Y + offset.Y);
                int newCharIndex = introductiontextbox.GetCharIndexFromPosition(newPos);

                // Delete the original image
                introductiontextbox.Select(startPosition, 1);
                introductiontextbox.SelectedText = "";

                // Paste the image at the new position
                introductiontextbox.Select(newCharIndex, 0);
                introductiontextbox.Paste();

                // Update drag start position
                dragStartPosition = newCharIndex;
            }
        }



        private void createbutton_Click(object sender, EventArgs e)
        {
            decimal cost;
            if (decimal.TryParse(costtextbox.Text.ToString(), out cost))
            {
                var package = new Package
                {
                    name = nametextbox.Text.ToString(),
                    cost = cost,
                    employeeId = CommonAccess.employeeId,
                    image = ImageToByteArray(imagebox.Image),
                    introduction = introductiontextbox.Rtf
                };
                context.Packages.Add(package);
                context.SaveChanges();
                var packageId = package.packageId;
                var controls = flowLayoutPanel1.Controls;
                var namecount = 1;
                for (int i = 0; i < controls.Count; i += 2)
                {
                    DateTimePicker datePicker1 = controls[i] as DateTimePicker;
                    DateTimePicker datePicker2 = (i + 1 < controls.Count) ? controls[i + 1] as DateTimePicker : null;

                    // Check if the controls are DateTimePickers
                    if (datePicker1 != null)
                    {
                        var schedule = new Schedule
                        {
                            packageId = packageId,
                            name = $"Schedule {namecount}",
                            startingDate= datePicker1.Value.Date,
                            endingDate= datePicker2.Value.Date // Handle null case if there is no second DateTimePicker
                        };
                        context.Schedules.Add(schedule);
                        context.SaveChanges();
                        // Process or use the schedule object as needed

                        namecount++;
                    }
                }

                MessageBox.Show("Package created successfuly.");
                PackageManagement packageManagement = new PackageManagement();
                packageManagement.Show();
                this.Hide();
            }
        }


        public byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Save the image to the MemoryStream in a specific format (e.g., PNG, JPEG)
                image.Save(ms, image.RawFormat);

                // Convert the MemoryStream to a byte array
                return ms.ToArray();
            }
        }



        private void uploadimagebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set file filter to image files (JPEG, PNG, etc.)
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select an Image";

            // Show the file dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the selected file
                string imagePath = openFileDialog.FileName;

                // Load the selected image into the PictureBox
                imagebox.Image = Image.FromFile(imagePath);

                // Optionally, adjust the PictureBox size mode to fit the image
                imagebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void introductiontextbox_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsMouseOverImage(e.Location))
            {
                _isDragging = true;
                _imageLocation = e.Location;
            }
        }
        private void introductiontextbox_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
        }

        private void introductiontextbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                // Calculate the new position
                Point newLocation = new Point(e.X - _imageLocation.X, e.Y - _imageLocation.Y);
                // Move the image box
                _imageBox.Location = newLocation;
            }
        }

        private void InsertImageIntoRichTextBox(string imagePath)
        {
            Image image = Image.FromFile(imagePath);

            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Png);
                stream.Seek(0, SeekOrigin.Begin);

                // Set the image to clipboard
                Clipboard.SetImage(image);

                // Paste the image into the RichTextBox
                introductiontextbox.Paste();

                // Create a PictureBox for the image
                _imageBox = new PictureBox
                {
                    Image = image,
                    Size = image.Size,
                    Location = new Point(10, 10) // Set initial location
                };

                // Add PictureBox to the form
                Controls.Add(_imageBox);
                _imageBox.BringToFront();
            }
        }

        private bool IsMouseOverImage(Point location)
        {
            if (_imageBox == null)
                return false;

            // Check if the mouse location is within the bounds of the PictureBox
            Rectangle imageBounds = new Rectangle(_imageBox.Location, _imageBox.Size);
            return imageBounds.Contains(location);
        }
        private void introductiontextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertimagebutton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set file filter to image files (JPEG, PNG, etc.)
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select an Image";

            // Show the file dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of the selected file
                string imagePath = openFileDialog.FileName;

                // Load the selected image into the PictureBox
                CommonAccess.image= Image.FromFile(imagePath);

                // Optionally, adjust the PictureBox size mode to fit the image
                //imagebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }


            PreviewImage previewImage = new PreviewImage(introductiontextbox);
            previewImage.Show();
            


            //string imagePath = @"C:\Users\hngwu\OneDrive\Korea\Data Files\Session 1\Hotel Imagesd\Mate Hotel.jpg";
            //InsertImageIntoRichTextBox(imagePath);
            //using (OpenFileDialog ofdIntro = new OpenFileDialog())
            //{
            //    ofdIntro.Filter = "Image Files(.jpg; *.jpeg;.png;)|*.jpg; *.jpeg; *.png;";
            //    if (ofdIntro.ShowDialog() == DialogResult.OK)
            //    {
            //        Image selectedImage = Image.FromFile(ofdIntro.FileName);
            //        using (ResizeImageForm resizeForm = new ResizeImageForm(selectedImage))
            //        {
            //            if (resizeForm.ShowDialog() == DialogResult.OK)
            //            {
            //                Image resizedImage = resizeForm.ResizedImage;
            //                Clipboard.SetImage(resizedImage);
            //                rtbIntroduction.Paste();
            //            }
            //        }
            //    }
            //}

        }

        private void CreatePackage_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void introductiontextbox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void imagebox_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void costtextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        static int count = 0;
        private void addbutton_Click(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker
            {
                Location = new System.Drawing.Point(20, 20),  // Set position on the form
                Format = DateTimePickerFormat.Short
            };

            // Create the second DateTimePicker, positioning it next to the first one
            DateTimePicker dateTimePicker2 = new DateTimePicker
            {
                Location = new System.Drawing.Point(dateTimePicker1.Right + 10, 20),  // Set position next to the first DateTimePicker
                Format = DateTimePickerFormat.Short
            };


            if(count <20)
            {
                flowLayoutPanel1.Controls.Add(dateTimePicker1);
                flowLayoutPanel1.Controls.Add(dateTimePicker2);
                count += 2;
            }
            else
            {
                MessageBox.Show("Max limit reached");
            }
           

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                count -= 2;
            }
            else
            {
                MessageBox.Show("No choices to remove.");
            }
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }

}


