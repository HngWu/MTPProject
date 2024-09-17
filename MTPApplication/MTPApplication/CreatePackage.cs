using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
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

        public CreatePackage()
        {
            InitializeComponent();
           
        }



        private void createbutton_Click(object sender, EventArgs e)
        {
            decimal cost;
            if(decimal.TryParse(costtextbox.Text.ToString(), out cost))
            {
                var package = new Package
                {
                    name = nametextbox.Text.ToString(),
                    cost = cost,
                    image = ImageToByteArray(imagebox.Image),
                    introduction = introductiontextbox.Rtf
                };
                context.Packages.Add(package);
                context.SaveChanges();
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
            string imagePath = @"C:\Users\hngwu\OneDrive\Korea\Data Files\Session 1\Hotel Imagesd\Mate Hotel.jpg";
            InsertImageIntoRichTextBox(imagePath);

        }
    }
}
