namespace ImgCompare
{
    public partial class FindDuplicatesForm : Form
    {
        private int _imageIndex;
        private List<ImageData>? _images;
        private readonly BrowseForm _browseForm;
        private ImageData? _image1;
        private ImageData? _image2;
        private readonly LabelSet _imgLabel1;
        private readonly LabelSet _imgLabel2;

        public FindDuplicatesForm(BrowseForm browseForm)
        {
            InitializeComponent();
            _browseForm = browseForm;
            _imgLabel1 = new LabelSet(imgName1, imgWidth1, imgHeight1, imgHash1);
            _imgLabel2 = new LabelSet(imgName2, imgWidth2, imgHeight2, imgHash2);
            ResetLabel(_imgLabel1);
            ResetLabel(_imgLabel2);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        public void Load_Images(List<ImageData> images)
        {
            _images = images;
            Find_Comparison();
        }
        private void Find_Comparison()
        {
            if (_images == null) return;
            bool matchFound = false;
            while (!matchFound && _imageIndex < _images.Count-1)
            {
                if (_images[_imageIndex].Hash != _images[_imageIndex + 1].Hash)
                {
                    _imageIndex++;
                }
                else
                {
                    matchFound = true;
                }
            }
            if (matchFound)
            {
                _image1 = _images[_imageIndex];
                _image2 = _images[_imageIndex + 1];
                Display_Information();
            }
            else
            {
                _browseForm.Third_Form_Complete();
            }
        }
        private void Display_Information()
        {
            if (_image1 != null && _image2 != null)
            {
                pictureBox1.Image = Image.FromFile(_image1.FilePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromFile(_image2.FilePath);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

                SetLabels(_imgLabel1, _image1);
                SetLabels(_imgLabel2, _image2);

                if (_image1.Width > _image2.Width)
                {
                    _imgLabel1.SetGreater();
                }
                else if (_image2.Width > _image1.Width)
                {
                    _imgLabel2.SetGreater();
                }
                else
                {
                    _imgLabel1.SetEqual();
                    _imgLabel2.SetEqual();
                }

                deleteLeft.Enabled = true;
                deleteRight.Enabled = true;
                nextButton.Enabled = true;
            }
        }

        private void Clear_Information()
        {
            pictureBox1.Image.Dispose();
            pictureBox2.Image.Dispose();

            ResetLabel(_imgLabel1);
            ResetLabel(_imgLabel2);
            
            _imgLabel1.ResetColor();
            _imgLabel2.ResetColor();

            deleteLeft.Enabled = false;
            deleteRight.Enabled = false;
            nextButton.Enabled = false;
        }
        private static void SetLabels(LabelSet labels, ImageData img)
        {
            labels.name.Text += img.FileName;
            labels.width.Text += img.Width + "px";
            labels.height.Text += img.Height + "px";
            labels.hash.Text += img.Hash.ToString();
        }

        private static void ResetLabel(LabelSet labels)
        {
            labels.name.Text = "Image Name: ";
            labels.width.Text = "Image Width: ";
            labels.height.Text = "Image Height: ";
            labels.hash.Text = "Image Hash: ";
        }

        private void Delete_Image(ImageData image)
        {
            Clear_Information();
            if (_images != null)
            {
                File.Delete(image.FilePath);
                _images.Remove(image);
            }
            Find_Comparison();
        }

        private void deleteLeft_Click(object sender, EventArgs e)
        {
            if (_image1 != null)
            {
                Delete_Image( _image1 );
            }
            
        }

        private void deleteRight_Click(object sender, EventArgs e)
        {
            if (_image2 != null)
            {
                Delete_Image(_image2);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            _imageIndex++;
            Clear_Information();
            Find_Comparison();
        }
    }
}
