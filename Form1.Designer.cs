namespace sinifisi6
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlHeader = new Panel();
            lblTitle = new Label();
            btnAddFile = new Button();
            btnReadFile = new Button();
            btnRemoveFile = new Button();
            btnWriteFile = new Button();
            txtContent = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(238, 162, 125);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(23, 27);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(851, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(851, 100);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "File Control System";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddFile
            // 
            btnAddFile.BackColor = Color.FromArgb(235, 235, 235);
            btnAddFile.FlatAppearance.BorderSize = 0;
            btnAddFile.FlatStyle = FlatStyle.Flat;
            btnAddFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAddFile.Location = new Point(23, 153);
            btnAddFile.Margin = new Padding(3, 4, 3, 4);
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(263, 80);
            btnAddFile.TabIndex = 1;
            btnAddFile.Text = "Add File";
            btnAddFile.TextAlign = ContentAlignment.MiddleLeft;
            btnAddFile.UseVisualStyleBackColor = false;
            btnAddFile.Click += btnAddFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = Color.FromArgb(235, 235, 235);
            btnReadFile.FlatAppearance.BorderSize = 0;
            btnReadFile.FlatStyle = FlatStyle.Flat;
            btnReadFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReadFile.Location = new Point(23, 253);
            btnReadFile.Margin = new Padding(3, 4, 3, 4);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(263, 80);
            btnReadFile.TabIndex = 2;
            btnReadFile.Text = "Read File";
            btnReadFile.TextAlign = ContentAlignment.MiddleLeft;
            btnReadFile.UseVisualStyleBackColor = false;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnRemoveFile
            // 
            btnRemoveFile.BackColor = Color.FromArgb(235, 235, 235);
            btnRemoveFile.FlatAppearance.BorderSize = 0;
            btnRemoveFile.FlatStyle = FlatStyle.Flat;
            btnRemoveFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnRemoveFile.Location = new Point(23, 353);
            btnRemoveFile.Margin = new Padding(3, 4, 3, 4);
            btnRemoveFile.Name = "btnRemoveFile";
            btnRemoveFile.Size = new Size(263, 80);
            btnRemoveFile.TabIndex = 3;
            btnRemoveFile.Text = "Remove File";
            btnRemoveFile.TextAlign = ContentAlignment.MiddleLeft;
            btnRemoveFile.UseVisualStyleBackColor = false;
            btnRemoveFile.Click += btnRemoveFile_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.BackColor = Color.FromArgb(235, 235, 235);
            btnWriteFile.FlatAppearance.BorderSize = 0;
            btnWriteFile.FlatStyle = FlatStyle.Flat;
            btnWriteFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnWriteFile.Location = new Point(23, 453);
            btnWriteFile.Margin = new Padding(3, 4, 3, 4);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(263, 80);
            btnWriteFile.TabIndex = 4;
            btnWriteFile.Text = "Write File";
            btnWriteFile.TextAlign = ContentAlignment.MiddleLeft;
            btnWriteFile.UseVisualStyleBackColor = false;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // txtContent
            // 
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.Font = new Font("Segoe UI", 11F);
            txtContent.Location = new Point(309, 153);
            txtContent.Margin = new Padding(3, 4, 3, 4);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(566, 380);
            txtContent.TabIndex = 5;
            txtContent.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(179, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(179, 253);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(179, 353);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(107, 80);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(179, 453);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(107, 80);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 132, 61);
            ClientSize = new Size(897, 560);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtContent);
            Controls.Add(btnWriteFile);
            Controls.Add(btnRemoveFile);
            Controls.Add(btnReadFile);
            Controls.Add(btnAddFile);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Control System";
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.RichTextBox txtContent;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}