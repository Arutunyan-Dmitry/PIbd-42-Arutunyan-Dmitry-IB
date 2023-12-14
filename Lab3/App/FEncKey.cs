using System.Text;
using System.Text.RegularExpressions;

namespace App
{
    public partial class FEncKey : Form
    {
        public byte[] Key;
        public FEncKey()
        {
            InitializeComponent();
            panel_Drag.BorderStyle = BorderStyle.FixedSingle;
        }
        private void textBox_Key_TextChanged(object sender, EventArgs e)
        {
            panel_Drag.BackColor = Color.Transparent;
            label_Drag.Text = "Или перетащите файл сюда";
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
                    string[] byteValues = Regex.Matches(File.ReadAllLines(files[0])[0].ToUpper(), ".{1,2}")
                                           .Cast<Match>()
                                           .Select(m => m.Value)
                                           .ToArray();
                    byte[] fileBytes = new byte[byteValues.Length];
                    for (int i = 0; i < byteValues.Length; i++)
                    {
                        fileBytes[i] = byte.Parse(byteValues[i], System.Globalization.NumberStyles.HexNumber);
                    }
                    if (fileBytes.Length >= 8)
                    {
                        Key = fileBytes.Take(8).ToArray();
                        panel_Drag.BackColor = Color.LightGreen;
                        label_Drag.Text = "Файл успешно перемещён";
                    }
                    else
                    {
                        MessageBox.Show("Пароль должен содержать не менее 8 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Перетаскивать можно только файлы!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button_Ok_Click(object sender, EventArgs e)
        {
            if (!textBox_Key.Text.Equals("")) 
            {
                if (textBox_Key.Text.Length >= 8) 
                {
                    char[] pswd = textBox_Key.Text.ToCharArray();
                    Key = Encoding.UTF8.GetBytes(pswd).Take(8).ToArray();
                    DialogResult = DialogResult.OK;
                    Close();
                } else
                {
                    MessageBox.Show("Пароль должен содержать не менее 8 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                if (Key != null) 
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }       
        }
    }
}
