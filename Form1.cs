namespace FileRename
{
    public partial class FileRenameForm : Form
    {
        public FileRenameForm()
        {
            InitializeComponent();
        }

        private void btnHandle_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(txtSource.Text,"*.*", SearchOption.AllDirectories);
            //Guid.NewGuid().ToString();

            var destFolder = string.IsNullOrWhiteSpace(txtDest.Text) ? txtSource.Text : txtDest.Text;
            foreach (var file in files)
            {
                var ext = Path.GetExtension(file);
                var newFileName = $"{Guid.NewGuid().ToString("N").ToUpper()}{ext}";
                if (!string.IsNullOrWhiteSpace(txtPrefix.Text))
                {
                    newFileName = $"{txtPrefix.Text}-{newFileName}";
                }

                var newFilePath = Path.Combine(destFolder, newFileName);
                File.Move(file, newFilePath);
            }

            MessageBox.Show("¥¶¿ÌÕÍ±œ!");
            btnHandle.Enabled = false;
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtSource.Text = fbd.SelectedPath;
                    btnHandle.Enabled = true;

                }
            }
        }

        private void btnSelectDest_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtDest.Text = fbd.SelectedPath;
                }
            }
        }
    }
}