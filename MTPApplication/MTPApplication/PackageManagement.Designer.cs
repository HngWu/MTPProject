namespace MTPApplication
{
    partial class PackageManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageManagement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.packagegridview = new System.Windows.Forms.DataGridView();
            this.createbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagegridview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Package Management";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // packagegridview
            // 
            this.packagegridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.packagegridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packagegridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.packagegridview.Location = new System.Drawing.Point(0, 212);
            this.packagegridview.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.packagegridview.Name = "packagegridview";
            this.packagegridview.RowTemplate.Height = 33;
            this.packagegridview.Size = new System.Drawing.Size(1108, 560);
            this.packagegridview.TabIndex = 11;
            this.packagegridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.packagegridview_CellContentClick);
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(927, 139);
            this.createbutton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(166, 47);
            this.createbutton.TabIndex = 12;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // PackageManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 772);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.packagegridview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PackageManagement";
            this.Text = "PackageManagement";
            this.Load += new System.EventHandler(this.PackageManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagegridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView packagegridview;
        private System.Windows.Forms.Button createbutton;
    }
}