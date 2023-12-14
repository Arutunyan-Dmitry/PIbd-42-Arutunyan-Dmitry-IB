using BusinessLogic;
using System.Text.RegularExpressions;

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
            panel_Drag_D.BorderStyle = BorderStyle.FixedSingle;
        }
        private void FMain_Load(object sender, EventArgs e)
        {
            textBox_Format.Text = ".";
            label_Key.Text = "";
            panel_Encode.Visible = true;
            panel_Decode.Visible = false;
            panel_Info.Visible = false;
            EncodeMenuItem.Enabled = false;
            DecodeMenuItem.Enabled = true;
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
                    label_Key.Text = "";
                    FileGetPath = files[0];
                    panel_Drag.BackColor = Color.LightGreen;
                    panel_Drag_D.BackColor = Color.LightGreen;
                    label_Drag.Text = "Файл успешно перемещён";
                    label_Drag_D.Text = "Файл успешно перемещён";
                    textBox_FilePath.Text = FileGetPath;
                    textBox_FilePath_D.Text = FileGetPath;
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
                label_Key.Text = "";
                FileGetPath = openFileDialog.FileName;
                textBox_FilePath.Text = FileGetPath;
                textBox_FilePath_D.Text = FileGetPath;
                panel_Drag.BackColor = Color.Transparent;
                panel_Drag_D.BackColor = Color.Transparent;
                label_Drag.Text = "Или перетащите файл сюда";
                label_Drag_D.Text = "Или перетащите файл сюда";
            }
        }
        private void button_Choose_Dir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Выберите папку";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                label_Key.Text = "";
                FileSavePath = folderBrowserDialog.SelectedPath;
                textBox_SavePath.Text = FileSavePath;
                textBox_SavePath_D.Text = FileSavePath;
            }
        }
        private void button_Encode_Click(object sender, EventArgs e)
        {
            byte[] Key;
            DESofb d = new DESofb();
            if (!FileGetPath.Equals("") && !FileSavePath.Equals(""))
            {
                FEncKey form = new FEncKey();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Key = form.Key;
                }
                else
                {
                    return;
                }
                byte[] message = File.ReadAllBytes(FileGetPath);
                string crypt = BitConverter.ToString(d.Crypt(message, Key)).Replace("-", "").ToLower();
                using (StreamWriter stream = new StreamWriter(FileSavePath + "\\rezult.bin"))
                {
                    stream.WriteLine(crypt);
                }
                label_Key.Text = BitConverter.ToString(Key).Replace("-", "").ToLower();
                MessageBox.Show("Файл успешно сохранён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_Decode_Click(object sender, EventArgs e)
        {
            DESofb d = new DESofb();
            if (!FileGetPath.Equals("") && !FileSavePath.Equals("") && !textBox_Format.Equals("") && !textBox_Key.Text.Equals(""))
            {
                string[] byteValues = Regex.Matches(File.ReadAllLines(FileGetPath)[0].ToUpper(), ".{1,2}")
                                           .Cast<Match>()
                                           .Select(m => m.Value)
                                           .ToArray();
                byte[] message = new byte[byteValues.Length];
                for (int i = 0; i < byteValues.Length; i++)
                {
                    message[i] = byte.Parse(byteValues[i], System.Globalization.NumberStyles.HexNumber);
                }
                byteValues = Regex.Matches(textBox_Key.Text.ToUpper(), ".{1,2}")
                                  .Cast<Match>()
                                  .Select(m => m.Value)
                                  .ToArray();
                byte[] key = new byte[byteValues.Length];
                for (int i = 0; i < byteValues.Length; i++)
                {
                    key[i] = byte.Parse(byteValues[i], System.Globalization.NumberStyles.HexNumber);
                }
                byte[] crypt = d.Crypt(message, key);
                using (StreamWriter stream = new StreamWriter(FileSavePath + "\\rezult" + textBox_Format.Text))
                {
                    stream.BaseStream.Write(crypt, 0, crypt.Length);
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
            label_Key.Text = "";
            FileGetPath = "";
            FileSavePath = "";
            textBox_Format.Text = ".";
            textBox_Key.Text = "";
            textBox_SavePath.Text = FileSavePath;
            textBox_SavePath_D.Text = FileSavePath;
            textBox_FilePath.Text = FileGetPath;
            textBox_FilePath_D.Text = FileGetPath;
            panel_Drag.BackColor = Color.Transparent;
            panel_Drag_D.BackColor = Color.Transparent;
            label_Drag.Text = "Или перетащите файл сюда";
            label_Drag_D.Text = "Или перетащите файл сюда";
        }
        private void label_Key_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label_Key.Text);
        }

        private void EncodeMenuItem_Click(object sender, EventArgs e)
        {
            panel_Encode.Visible = true;
            panel_Decode.Visible = false;
            panel_Info.Visible = false;
            EncodeMenuItem.Enabled = false;
            DecodeMenuItem.Enabled = true;
            InfoMenuItem.Enabled = true;
            label_Key.Text = "";
            FileGetPath = "";
            FileSavePath = "";
            textBox_SavePath.Text = FileSavePath;
            textBox_FilePath.Text = FileGetPath;
            panel_Drag.BackColor = Color.Transparent;
            label_Drag.Text = "Или перетащите файл сюда";
        }

        private void DecodeMenuItem_Click(object sender, EventArgs e)
        {
            panel_Encode.Visible = false;
            panel_Decode.Visible = true;
            panel_Info.Visible = false;
            EncodeMenuItem.Enabled = true;
            DecodeMenuItem.Enabled = false;
            InfoMenuItem.Enabled = true;
            FileGetPath = "";
            FileSavePath = "";
            textBox_Format.Text = ".";
            textBox_SavePath_D.Text = FileSavePath;
            textBox_FilePath_D.Text = FileGetPath;
            textBox_Key.Text = "";
            panel_Drag_D.BackColor = Color.Transparent;
            label_Drag_D.Text = "Или перетащите файл сюда";
        }

        private void InfoMenuItem_Click(object sender, EventArgs e)
        {
            panel_Encode.Visible = false;
            panel_Decode.Visible = false;
            panel_Info.Visible = true;
            EncodeMenuItem.Enabled = true;
            DecodeMenuItem.Enabled = true;
            InfoMenuItem.Enabled = false;
        }
    }
}
