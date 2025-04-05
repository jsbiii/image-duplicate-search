namespace ImgCompare
{
    using Microsoft.WindowsAPICodePack.Dialogs;
    public partial class BrowseForm : Form
    {
        private LoadForm _loadForm;
        private FindDuplicatesForm _findDuplicatesForm;
        private bool _finished;
        private const string DuplicatesCompleted = "Finished Going Through Duplicates";
        private const string ThirdFormEnded = "Comparisons of Duplicates Closed";

        public BrowseForm()
        {
            InitializeComponent();
            _loadForm = new LoadForm();
            _findDuplicatesForm = new FindDuplicatesForm(this);
            _findDuplicatesForm.FormClosed += form3_FormClosed!;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void browse_Button_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog openFileDialog = new();
            openFileDialog.IsFolderPicker = true;
            if(openFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                folder_text.Text = openFileDialog.FileName;
            }
        }
        private void load_Button_Click(object sender, EventArgs e)
        {
            _finished = false;
            if (folder_text.Text == string.Empty) return;
            if(_loadForm.IsDisposed) _loadForm = new LoadForm();
            _loadForm.Show();
            Hide();
            _loadForm.Load_Images(folder_text.Text, this);
        }
        public void Second_Form_Complete(List<ImageData> images)
        {
            _loadForm.Dispose();
            if (_findDuplicatesForm.IsDisposed) _findDuplicatesForm = new FindDuplicatesForm(this);
            _findDuplicatesForm.Show();
            _findDuplicatesForm.Load_Images(images);
            
        }
        public void Third_Form_Complete()
        {
            _finished = true;
            _findDuplicatesForm.Dispose();
            folder_text.Text = "";
            resultText.Text = DuplicatesCompleted;
            Show();
        }
        private void form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
            if (!_finished)
            {
                resultText.Text = ThirdFormEnded;
            }
        }

    }
}
