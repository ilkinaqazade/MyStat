namespace MyStat
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mystatLb = new System.Windows.Forms.Label();
            this.menuPicBoxBacnkround = new System.Windows.Forms.PictureBox();
            this.photoLb = new System.Windows.Forms.Label();
            this.fullNameLb = new System.Windows.Forms.Label();
            this.markpresenceLb = new System.Windows.Forms.Label();
            this.markonlineLb = new System.Windows.Forms.Label();
            this.testLb = new System.Windows.Forms.Label();
            this.classworkLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPicBoxBacnkround)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 59);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mystatLb
            // 
            this.mystatLb.AutoSize = true;
            this.mystatLb.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mystatLb.ForeColor = System.Drawing.Color.White;
            this.mystatLb.Location = new System.Drawing.Point(295, 9);
            this.mystatLb.Name = "mystatLb";
            this.mystatLb.Size = new System.Drawing.Size(142, 40);
            this.mystatLb.TabIndex = 1;
            this.mystatLb.Text = "My Stat";
            // 
            // menuPicBoxBacnkround
            // 
            this.menuPicBoxBacnkround.Location = new System.Drawing.Point(0, 59);
            this.menuPicBoxBacnkround.Name = "menuPicBoxBacnkround";
            this.menuPicBoxBacnkround.Size = new System.Drawing.Size(775, 34);
            this.menuPicBoxBacnkround.TabIndex = 2;
            this.menuPicBoxBacnkround.TabStop = false;
            // 
            // photoLb
            // 
            this.photoLb.AutoSize = true;
            this.photoLb.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoLb.ForeColor = System.Drawing.Color.White;
            this.photoLb.Location = new System.Drawing.Point(17, 67);
            this.photoLb.Name = "photoLb";
            this.photoLb.Size = new System.Drawing.Size(50, 17);
            this.photoLb.TabIndex = 3;
            this.photoLb.Text = "Photo";
            // 
            // fullNameLb
            // 
            this.fullNameLb.AutoSize = true;
            this.fullNameLb.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLb.ForeColor = System.Drawing.Color.White;
            this.fullNameLb.Location = new System.Drawing.Point(122, 67);
            this.fullNameLb.Name = "fullNameLb";
            this.fullNameLb.Size = new System.Drawing.Size(79, 17);
            this.fullNameLb.TabIndex = 4;
            this.fullNameLb.Text = "Full Name";
            // 
            // markpresenceLb
            // 
            this.markpresenceLb.AutoSize = true;
            this.markpresenceLb.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markpresenceLb.ForeColor = System.Drawing.Color.White;
            this.markpresenceLb.Location = new System.Drawing.Point(253, 67);
            this.markpresenceLb.Name = "markpresenceLb";
            this.markpresenceLb.Size = new System.Drawing.Size(112, 17);
            this.markpresenceLb.TabIndex = 5;
            this.markpresenceLb.Text = "Mark Presence";
            // 
            // markonlineLb
            // 
            this.markonlineLb.AutoSize = true;
            this.markonlineLb.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markonlineLb.ForeColor = System.Drawing.Color.White;
            this.markonlineLb.Location = new System.Drawing.Point(424, 67);
            this.markonlineLb.Name = "markonlineLb";
            this.markonlineLb.Size = new System.Drawing.Size(93, 17);
            this.markonlineLb.TabIndex = 6;
            this.markonlineLb.Text = "Mark Online";
            // 
            // testLb
            // 
            this.testLb.AutoSize = true;
            this.testLb.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLb.ForeColor = System.Drawing.Color.White;
            this.testLb.Location = new System.Drawing.Point(577, 67);
            this.testLb.Name = "testLb";
            this.testLb.Size = new System.Drawing.Size(37, 17);
            this.testLb.TabIndex = 7;
            this.testLb.Text = "Test";
            // 
            // classworkLb
            // 
            this.classworkLb.AutoSize = true;
            this.classworkLb.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classworkLb.ForeColor = System.Drawing.Color.White;
            this.classworkLb.Location = new System.Drawing.Point(666, 67);
            this.classworkLb.Name = "classworkLb";
            this.classworkLb.Size = new System.Drawing.Size(88, 17);
            this.classworkLb.TabIndex = 8;
            this.classworkLb.Text = "Class Work";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 388);
            this.panel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.classworkLb);
            this.Controls.Add(this.testLb);
            this.Controls.Add(this.markonlineLb);
            this.Controls.Add(this.markpresenceLb);
            this.Controls.Add(this.fullNameLb);
            this.Controls.Add(this.photoLb);
            this.Controls.Add(this.menuPicBoxBacnkround);
            this.Controls.Add(this.mystatLb);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuPicBoxBacnkround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mystatLb;
        private System.Windows.Forms.PictureBox menuPicBoxBacnkround;
        private System.Windows.Forms.Label photoLb;
        private System.Windows.Forms.Label fullNameLb;
        private System.Windows.Forms.Label markpresenceLb;
        private System.Windows.Forms.Label markonlineLb;
        private System.Windows.Forms.Label testLb;
        private System.Windows.Forms.Label classworkLb;
        private System.Windows.Forms.Panel panel1;
    }
}

