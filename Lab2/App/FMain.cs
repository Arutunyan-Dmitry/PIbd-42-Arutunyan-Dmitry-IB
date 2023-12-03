using BusinessLogic;

namespace App
{
    public partial class FMain : Form
    {
        private string FileGetPath = "";
        private string FileSavePath = "";
        public FMain()
        {
            InitializeComponent();
            panel_Drag.BorderStyle = BorderStyle.FixedSingle;
        }
        private void FMain_Load(object sender, EventArgs e)
        {
            panel_Encode.Visible = true;
            panel_Info.Visible = false;
            EncodeMenuItem.Enabled = false;
            InfoMenuItem.Enabled = true;
        }
        private void panel_Drag_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void panel_Drag_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (File.Exists(files[0]))
                {
                    FileGetPath = files[0];
                    panel_Drag.BackColor = Color.LightGreen;
                    label_Drag.Text = "Файл успешно перемещён";
                    textBox_FilePath.Text = FileGetPath;
                }
                else
                {
                    MessageBox.Show("Перетаскивать можно только файлы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button_Choose_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Выберите файл";
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileGetPath = openFileDialog.FileName;
                textBox_FilePath.Text = FileGetPath;
                panel_Drag.BackColor = Color.Transparent;
                label_Drag.Text = "Или перетащите файл сюда";
            }
        }
        private void button_Choose_Dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберите папку";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FileSavePath = folderBrowserDialog.SelectedPath;
                textBox_SavePath.Text = FileSavePath;
            }
        }
        private void button_Encode_Click(object sender, EventArgs e)
        {
            if (!FileGetPath.Equals("") && !FileSavePath.Equals(""))
            {
                byte[] message = File.ReadAllBytes(FileGetPath);
                string hash = BitConverter.ToString(SHA1.Generate(message)).Replace("-", "").ToLower();
                string hash1 = "";
                using (var sha = System.Security.Cryptography.SHA1.Create())
                {
                    hash1 = BitConverter.ToString(sha.ComputeHash(message)).Replace("-", "").ToLower();
                }

                using (StreamWriter stream = new StreamWriter(FileSavePath + "\\rezult.bin"))
                {
                    stream.WriteLine("Реализованный алгоритм");
                    stream.WriteLine(hash);
                    stream.WriteLine("");
                    stream.WriteLine("Алгоритм SHA1 библиотеки Security.Cryptography");
                    stream.WriteLine(hash1);
                }
                MessageBox.Show("Файл успешно сохранён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            textBox_FilePath.Text = "";
            textBox_SavePath.Text = "";
            FileGetPath = "";
            FileSavePath = "";
            panel_Drag.BackColor = Color.Transparent;
            label_Drag.Text = "Или перетащите файл сюда";
        }
        private void EncodeMenuItem_Click(object sender, EventArgs e)
        {
            panel_Encode.Visible = true;
            panel_Info.Visible = false;
            EncodeMenuItem.Enabled = false;
            InfoMenuItem.Enabled = true;
        }
        private void InfoMenuItem_Click(object sender, EventArgs e)
        {
            panel_Encode.Visible = false;
            panel_Info.Visible = true;
            EncodeMenuItem.Enabled = true;
            InfoMenuItem.Enabled = false;
        }
    }
}
