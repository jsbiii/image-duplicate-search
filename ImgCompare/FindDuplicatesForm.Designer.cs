namespace ImgCompare
{
    partial class FindDuplicatesForm
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            imgName1 = new Label();
            imgWidth1 = new Label();
            imgHeight1 = new Label();
            imgHash1 = new Label();
            imgName2 = new Label();
            deleteLeft = new Button();
            deleteRight = new Button();
            nextButton = new Button();
            imgHash2 = new Label();
            imgHeight2 = new Label();
            imgWidth2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(563, 451);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(581, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(563, 451);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // imgName1
            // 
            imgName1.Location = new Point(12, 474);
            imgName1.MaximumSize = new Size(563, 45);
            imgName1.MinimumSize = new Size(563, 45);
            imgName1.Name = "imgName1";
            imgName1.Size = new Size(563, 45);
            imgName1.TabIndex = 2;
            imgName1.Text = "Image Name:";
            // 
            // imgWidth1
            // 
            imgWidth1.AutoSize = true;
            imgWidth1.Location = new Point(12, 521);
            imgWidth1.Name = "imgWidth1";
            imgWidth1.Size = new Size(78, 15);
            imgWidth1.TabIndex = 5;
            imgWidth1.Text = "Image Width:";
            // 
            // imgHeight1
            // 
            imgHeight1.AutoSize = true;
            imgHeight1.Location = new Point(12, 536);
            imgHeight1.Name = "imgHeight1";
            imgHeight1.Size = new Size(82, 15);
            imgHeight1.TabIndex = 6;
            imgHeight1.Text = "Image Height:";
            // 
            // imgHash1
            // 
            imgHash1.AutoSize = true;
            imgHash1.Location = new Point(12, 552);
            imgHash1.Name = "imgHash1";
            imgHash1.Size = new Size(73, 15);
            imgHash1.TabIndex = 7;
            imgHash1.Text = "Image Hash:";
            // 
            // imgName2
            // 
            imgName2.Location = new Point(581, 474);
            imgName2.MaximumSize = new Size(563, 45);
            imgName2.MinimumSize = new Size(563, 45);
            imgName2.Name = "imgName2";
            imgName2.Size = new Size(563, 45);
            imgName2.TabIndex = 11;
            imgName2.Text = "Image Name:";
            // 
            // deleteLeft
            // 
            deleteLeft.Enabled = false;
            deleteLeft.Location = new Point(228, 578);
            deleteLeft.Name = "deleteLeft";
            deleteLeft.Size = new Size(75, 23);
            deleteLeft.TabIndex = 19;
            deleteLeft.Text = "Delete Left";
            deleteLeft.UseVisualStyleBackColor = true;
            deleteLeft.Click += deleteLeft_Click;
            // 
            // deleteRight
            // 
            deleteRight.Enabled = false;
            deleteRight.Location = new Point(829, 578);
            deleteRight.Name = "deleteRight";
            deleteRight.Size = new Size(80, 23);
            deleteRight.TabIndex = 20;
            deleteRight.Text = "Delete Right";
            deleteRight.UseVisualStyleBackColor = true;
            deleteRight.Click += deleteRight_Click;
            // 
            // nextButton
            // 
            nextButton.Enabled = false;
            nextButton.Location = new Point(537, 578);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 23);
            nextButton.TabIndex = 21;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // imgHash2
            // 
            imgHash2.AutoSize = true;
            imgHash2.Location = new Point(581, 552);
            imgHash2.Name = "imgHash2";
            imgHash2.Size = new Size(73, 15);
            imgHash2.TabIndex = 24;
            imgHash2.Text = "Image Hash:";
            // 
            // imgHeight2
            // 
            imgHeight2.AutoSize = true;
            imgHeight2.Location = new Point(581, 536);
            imgHeight2.Name = "imgHeight2";
            imgHeight2.Size = new Size(82, 15);
            imgHeight2.TabIndex = 23;
            imgHeight2.Text = "Image Height:";
            // 
            // imgWidth2
            // 
            imgWidth2.AutoSize = true;
            imgWidth2.Location = new Point(581, 521);
            imgWidth2.Name = "imgWidth2";
            imgWidth2.Size = new Size(78, 15);
            imgWidth2.TabIndex = 22;
            imgWidth2.Text = "Image Width:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 658);
            Controls.Add(imgHash2);
            Controls.Add(imgHeight2);
            Controls.Add(imgWidth2);
            Controls.Add(nextButton);
            Controls.Add(deleteRight);
            Controls.Add(deleteLeft);
            Controls.Add(imgName2);
            Controls.Add(imgHash1);
            Controls.Add(imgHeight1);
            Controls.Add(imgWidth1);
            Controls.Add(imgName1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "FindDuplicatesForm";
            Text = "Image Compare";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label imgName1;
        private Label imgWidth1;
        private Label imgHeight1;
        private Label imgHash1;
        private Label imgName2;
        private Button deleteLeft;
        private Button deleteRight;
        private Button nextButton;
        private Label imgHash2;
        private Label imgHeight2;
        private Label imgWidth2;
    }
}