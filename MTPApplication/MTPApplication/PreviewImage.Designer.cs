namespace MTPApplication
{
    partial class PreviewImage
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.widthtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heighttextbox = new System.Windows.Forms.TextBox();
            this.insertbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(221, 33);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(336, 187);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // widthtextbox
            // 
            this.widthtextbox.Location = new System.Drawing.Point(234, 244);
            this.widthtextbox.Name = "widthtextbox";
            this.widthtextbox.Size = new System.Drawing.Size(323, 31);
            this.widthtextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // heighttextbox
            // 
            this.heighttextbox.Location = new System.Drawing.Point(234, 292);
            this.heighttextbox.Name = "heighttextbox";
            this.heighttextbox.Size = new System.Drawing.Size(323, 31);
            this.heighttextbox.TabIndex = 3;
            // 
            // insertbutton
            // 
            this.insertbutton.Location = new System.Drawing.Point(465, 361);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(92, 34);
            this.insertbutton.TabIndex = 5;
            this.insertbutton.Text = "insert";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // PreviewImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heighttextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthtextbox);
            this.Controls.Add(this.pictureBox);
            this.Name = "PreviewImage";
            this.Text = "PreviewImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox widthtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heighttextbox;
        private System.Windows.Forms.Button insertbutton;
    }
}