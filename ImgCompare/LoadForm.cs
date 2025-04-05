namespace ImgCompare
{
    public partial class LoadForm : Form
    {
        private List<ImageData> _images = [];
        private readonly string[] _filters = ["*.jpg", "*.jpeg", "*.png", "*.gif"];
        public LoadForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void Load_Images(string dPath, BrowseForm browseForm)
        {
            //Add ability to search all folders too.
            
            //SearchOption searchOption = SearchOption.AllDirectories;
            SearchOption searchOption = SearchOption.TopDirectoryOnly;
            string[] fileNames = [];
            fileNames = _filters.Aggregate(fileNames, (current, f) => current.Concat(Directory.GetFiles(dPath, f,searchOption)).ToArray());
            Update_Status("Hashing Images");
            statusText.Update();
            progressBar1.Maximum = fileNames.Length;

            foreach (string f in fileNames)
            {
                try
                {
                    _images.Add(new ImageData(f));
                }
                catch (OutOfMemoryException e)
                {

                }
                progressBar1.Value++;
            }
            Update_Status("Sorting Images");
            _images = _images.OrderBy(image => image.Hash).ToList();

            browseForm.Second_Form_Complete(_images);
        }
        private void Update_Status(string s)
        {
            statusText.Text = s;
            statusText.Update();
        }
    }
}
