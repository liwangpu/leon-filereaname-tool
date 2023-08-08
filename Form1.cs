using shortid;
using shortid.Configuration;

namespace FileRename
{
    public partial class FileRenameForm : Form
    {
        private GenerationOptions shortIdOptions;
        private static string AllFileFilter = "*.*";
        public FileRenameForm()
        {
            InitializeComponent();
        }


        private void FileRenameForm_Load(object sender, EventArgs e)
        {
            ActiveControl = btnSelectSource;
            shortIdOptions = new GenerationOptions(false, false, 8);
            generateRandomPrefix();
        }

        private void generateRandomPrefix()
        {
            txtPrefix.Text = ShortId.Generate(new GenerationOptions(false, false, 8)).ToUpper();
        }


        private void btnHandle_Click(object sender, EventArgs e)
        {
            InvokeMainForm((obj) =>
            {
                var filter = string.IsNullOrWhiteSpace(txtFileFilter.Text) ? AllFileFilter : txtFileFilter.Text;
                var files = Directory.GetFiles(txtSource.Text, filter, SearchOption.AllDirectories);
                var destFolder = string.IsNullOrWhiteSpace(txtDest.Text) ? txtSource.Text : txtDest.Text;

                foreach (var file in files)
                {
                    var ext = Path.GetExtension(file);
                    var newFileName = $"{ ShortId.Generate(shortIdOptions)}{ext}";
                    if (!string.IsNullOrWhiteSpace(txtPrefix.Text))
                    {
                        newFileName = $"{txtPrefix.Text}-{newFileName}";
                    }

                    var newFilePath = Path.Combine(destFolder, newFileName);
                    File.Move(file, newFilePath);
                }

                MessageBox.Show("¥¶¿ÌÕÍ±œ!");
                btnHandle.Enabled = false;

            }, null);
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

            checkAndEnableHandleButton();
        }

        private void btnPrefixGenerator_Click(object sender, EventArgs e)
        {
            generateRandomPrefix();
            checkAndEnableHandleButton();
        }

        private void btnFileSelectOfAllFile_Click(object sender, EventArgs e)
        {
            txtFileFilter.Text = AllFileFilter;
        }

        private void btnFileSelectOfMP4_Click(object sender, EventArgs e)
        {
            txtFileFilter.Text = "*.mp4";
        }

        private void checkAndEnableHandleButton()
        {
            if (!string.IsNullOrWhiteSpace(txtSource.Text))
            {
                btnHandle.Enabled = true;
            }
        }

        protected void InvokeMainForm(Action act)
        {
            if (InvokeRequired)
            {
                Invoke(act);
            }
            else
            {
                act.Invoke();
            }
        }

        private void InvokeMainForm(Action<object> act, object obj)
        {
            if (InvokeRequired)
            {
                Invoke(act, obj);
            }
            else
            {
                act.Invoke(obj);
            }
        }
    }
}