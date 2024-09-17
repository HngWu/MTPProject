namespace MTPApplication
{
    partial class storeimage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imagebutton
            // 
            this.imagebutton.Location = new System.Drawing.Point(348, 202);
            this.imagebutton.Name = "imagebutton";
            this.imagebutton.Size = new System.Drawing.Size(75, 23);
            this.imagebutton.TabIndex = 0;
            this.imagebutton.Text = "button1";
            this.imagebutton.UseVisualStyleBackColor = true;
            this.imagebutton.Click += new System.EventHandler(this.imagebutton_Click);
            // 
            // storeimage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imagebutton);
            this.Name = "storeimage";
            this.Text = "storeimage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button imagebutton;
    }
}