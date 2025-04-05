namespace ImgCompare
{
    partial class BrowseForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            BrowseButton = new Button();
            folder_text = new TextBox();
            LoadButton = new Button();
            resultText = new Label();
            SuspendLayout();
            // 
            // BrowseButton
            // 
            BrowseButton.Location = new Point(30, 40);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(75, 23);
            BrowseButton.TabIndex = 0;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += browse_Button_Click;
            // 
            // folder_text
            // 
            folder_text.BorderStyle = BorderStyle.None;
            folder_text.Location = new Point(30, 69);
            folder_text.Name = "folder_text";
            folder_text.ReadOnly = true;
            folder_text.Size = new Size(210, 16);
            folder_text.TabIndex = 1;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(111, 40);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(75, 23);
            LoadButton.TabIndex = 2;
            LoadButton.Text = "Load";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += load_Button_Click;
            // 
            // resultText
            // 
            resultText.AutoSize = true;
            resultText.Location = new Point(30, 179);
            resultText.Name = "resultText";
            resultText.Size = new Size(0, 15);
            resultText.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 203);
            Controls.Add(resultText);
            Controls.Add(LoadButton);
            Controls.Add(folder_text);
            Controls.Add(BrowseButton);
            Name = "BrowseForm";
            Text = "Image Compare";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button BrowseButton;
        private TextBox folder_text;
        private Button LoadButton;
        private Label resultText;
    }
}
