namespace ImgCompare
{
    partial class LoadForm
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
            progressBar1 = new ProgressBar();
            statusText = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(150, 154);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(350, 20);
            progressBar1.TabIndex = 0;
            // 
            // statusText
            // 
            statusText.Location = new Point(150, 126);
            statusText.Name = "statusText";
            statusText.Size = new Size(350, 15);
            statusText.TabIndex = 1;
            statusText.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 291);
            Controls.Add(statusText);
            Controls.Add(progressBar1);
            Name = "LoadForm";
            Text = "Image Compare";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Label statusText;
    }
}