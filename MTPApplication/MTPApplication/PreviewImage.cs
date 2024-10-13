using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTPApplication
{
    public partial class PreviewImage : Form
    {
        private RichTextBox package;
        public PreviewImage()
        {
            InitializeComponent();
            pictureBox.Image = CommonAccess.image;
        }

        public PreviewImage(RichTextBox package)
        {
            InitializeComponent();
            pictureBox.Image = CommonAccess.image;
            this.package = package;
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
    

            var picturebox = new PictureBox()
            {
                Image = CommonAccess.image,
                
            };
            Clipboard.SetImage(picturebox.Image);
            this.Hide();
            this.package.Paste();
        }
    }
}
