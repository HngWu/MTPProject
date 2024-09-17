namespace MTPApplication
{
    partial class CreatePackage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uploadimagebutton = new System.Windows.Forms.Button();
            this.imagebox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costtextbox = new System.Windows.Forms.TextBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.createbutton = new System.Windows.Forms.Button();
            this.insertimagebutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.introductiontextbox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.costtextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nametextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(101, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 509);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.insertimagebutton);
            this.groupBox1.Controls.Add(this.uploadimagebutton);
            this.groupBox1.Controls.Add(this.imagebox);
            this.groupBox1.Location = new System.Drawing.Point(120, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 121);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // uploadimagebutton
            // 
            this.uploadimagebutton.Location = new System.Drawing.Point(219, 47);
            this.uploadimagebutton.Name = "uploadimagebutton";
            this.uploadimagebutton.Size = new System.Drawing.Size(93, 32);
            this.uploadimagebutton.TabIndex = 20;
            this.uploadimagebutton.Text = "Upload";
            this.uploadimagebutton.UseVisualStyleBackColor = true;
            this.uploadimagebutton.Click += new System.EventHandler(this.uploadimagebutton_Click);
            // 
            // imagebox
            // 
            this.imagebox.Location = new System.Drawing.Point(6, 0);
            this.imagebox.Name = "imagebox";
            this.imagebox.Size = new System.Drawing.Size(170, 121);
            this.imagebox.TabIndex = 18;
            this.imagebox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 279);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 10, 10);
            this.label5.Size = new System.Drawing.Size(104, 35);
            this.label5.TabIndex = 22;
            this.label5.Text = "Introduction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 152);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(40, 5, 10, 10);
            this.label4.Size = new System.Drawing.Size(104, 35);
            this.label4.TabIndex = 21;
            this.label4.Text = "Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(50, 5, 10, 10);
            this.label2.Size = new System.Drawing.Size(102, 35);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cost";
            // 
            // costtextbox
            // 
            this.costtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costtextbox.Location = new System.Drawing.Point(120, 79);
            this.costtextbox.Name = "costtextbox";
            this.costtextbox.Size = new System.Drawing.Size(312, 26);
            this.costtextbox.TabIndex = 19;
            // 
            // nametextbox
            // 
            this.nametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextbox.Location = new System.Drawing.Point(120, 3);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(312, 26);
            this.nametextbox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(50, 5, 10, 10);
            this.label1.Size = new System.Drawing.Size(111, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Create Package";
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(593, 607);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(93, 32);
            this.createbutton.TabIndex = 21;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // insertimagebutton
            // 
            this.insertimagebutton.Location = new System.Drawing.Point(342, 47);
            this.insertimagebutton.Name = "insertimagebutton";
            this.insertimagebutton.Size = new System.Drawing.Size(93, 32);
            this.insertimagebutton.TabIndex = 21;
            this.insertimagebutton.Text = "Insert Below";
            this.insertimagebutton.UseVisualStyleBackColor = true;
            this.insertimagebutton.Click += new System.EventHandler(this.insertimagebutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.introductiontextbox);
            this.panel1.Location = new System.Drawing.Point(120, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 224);
            this.panel1.TabIndex = 22;
            // 
            // introductiontextbox
            // 
            this.introductiontextbox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.introductiontextbox.Location = new System.Drawing.Point(3, 3);
            this.introductiontextbox.Name = "introductiontextbox";
            this.introductiontextbox.Size = new System.Drawing.Size(459, 218);
            this.introductiontextbox.TabIndex = 18;
            this.introductiontextbox.Text = "";
            // 
            // CreatePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 880);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Name = "CreatePackage";
            this.Text = "CreatePackage";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button uploadimagebutton;
        private System.Windows.Forms.PictureBox imagebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costtextbox;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Button insertimagebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox introductiontextbox;
    }
}