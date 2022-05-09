namespace ImageResize.WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region An Image

        private void buttonOpenFileSource_Click(object sender, EventArgs e)
        {
            var directoryDialog = new OpenFileDialog();
            directoryDialog.Filter = "Jpeg files, PNG files, BMP files|*.jpg;*.jpeg;*.png;*.bmp";

            if (directoryDialog.ShowDialog() == DialogResult.OK)
                textBoxSource.Text = directoryDialog.FileName;
        }

        private void buttonOpenFileDestiny_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                textBoxDestiny.Text = folderBrowserDialog.SelectedPath;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;
            var image = Image.FromFile(textBoxSource.Text);
            var imagemResize = new Service.ImageResize(image);

            if (checkBoxEnlarge.Checked)
            {
                imagemResize.Enlarge();
            }
            if (checkBoxAlignTop.Checked)
            {
                imagemResize.AlignTop();
            }

            var size = new Size()
            {
                Width = Convert.ToInt32(textBoxWidth.Text),
                Height = Convert.ToInt32(textBoxHeight.Text)
            };

            var currentFilename = Path.GetFileNameWithoutExtension(textBoxSource.Text);
            var extension = Path.GetExtension(textBoxSource.Text);
            var pathOutput = textBoxDestiny.Text + "\\" +
                currentFilename + "_" + size.Width.ToString() + "x" + size.Height.ToString() + "_" + "." + extension;

            imagemResize.Resize(size)
            .Save(pathOutput, image.RawFormat);
            MessageBox.Show("Resized image!");
        }

        private bool ValidateFields()
        {
            if (textBoxSource.Text.Count() == 0 || textBoxDestiny.Text.Count() == 0)
            {
                MessageBox.Show("Please, select a source file and a destiny");
                return false;
            }

            if (textBoxWidth.Text.Count() == 0 || textBoxHeight.Text.Count() == 0)
            {
                MessageBox.Show("Please, select a width and a height");
                return false;
            }

            try
            {
                int width = Int32.Parse(textBoxWidth.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value for width");
                return false;
            }

            try
            {
                int height = Int32.Parse(textBoxHeight.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value for height");
                return false;
            }
            return true;
        }

        #endregion

        #region Multi Image

        private void buttonMultiOpenSource_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                textBoxMultiSource.Text = folderBrowserDialog.SelectedPath;
        }

        private void buttonMultiOpenDestiny_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                textBoxMultiDestiny.Text = folderBrowserDialog.SelectedPath;
        }

        private void buttonMultiSave_Click(object sender, EventArgs e)
        {
            if (!ValidateMultiFields()) return;
            foreach (var pathSource in Directory.GetFiles(textBoxMultiSource.Text))
                ProcessImage(pathSource);
            MessageBox.Show("Resized images!");
        }

        private void ProcessImage(string pathSource)
        {
            var image = Image.FromFile(pathSource);
            var imagemResize = new Service.ImageResize(image);

            if (checkBoxMultiEnlarge.Checked)
            {
                imagemResize.Enlarge();
            }
            if (checkBoxMultiAlignTop.Checked)
            {
                imagemResize.AlignTop();
            }

            var size = new Size()
            {
                Width = Convert.ToInt32(textBoxMultiWidth.Text),
                Height = Convert.ToInt32(textBoxMultiHeight.Text)
            };

            var currentFilename = Path.GetFileNameWithoutExtension(pathSource);
            var extension = Path.GetExtension(pathSource);
            var pathOutput = textBoxMultiDestiny.Text + "\\" +
                currentFilename + "_" + size.Width.ToString() + "x" + size.Height.ToString() + "_" + "." + extension;

            imagemResize.Resize(size).Save(pathOutput, image.RawFormat);
        }

        private bool ValidateMultiFields()
        {
            if (textBoxMultiSource.Text.Count() == 0 || textBoxMultiDestiny.Text.Count() == 0)
            {
                MessageBox.Show("Please, select a source and a destiny");
                return false;
            }

            if (textBoxMultiWidth.Text.Count() == 0 || textBoxMultiHeight.Text.Count() == 0)
            {
                MessageBox.Show("Please, select a width and a height");
                return false;
            }

            try
            {
                int width = Int32.Parse(textBoxMultiWidth.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value for width");
                return false;
            }

            try
            {
                int height = Int32.Parse(textBoxMultiHeight.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid value for height");
                return false;
            }
            return true;
        }

        #endregion


    }

}