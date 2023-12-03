using AssetRipper.HashAlgorithms;
using Contracts.BindingModels;
using Contracts.BusinessLogicContracts;
using System.Text;

namespace App
{
    public partial class FMain : Form
    {
        private readonly IUserLogic _logic;
        public string Name { set { name = value; } }
        private string name;
        public FMain(IUserLogic logic)
        {
            InitializeComponent();
            panel_Main.Visible = true;
            panel_User.Visible = false;
            panel_Author.Visible = false;
            главнаяToolStripMenuItem.Enabled = false;
            личныйКабинетToolStripMenuItem.Enabled = true;
            оToolStripMenuItem.Enabled = true;
            _logic = logic;
        }
        private void FMain_Load(object sender, EventArgs e)
        {
            if (!name.Equals(""))
            {
                var user = _logic.Read(new UserBindingModel { Name = name })[0];
                label_Hello.Text = "Добро пожаловать, " + user.Name;
                label_User.Text = "Пользователь: " + user.Name;
            }
            else
            {
                MessageBox.Show("Ошибка чтения пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Visible = true;
            panel_User.Visible = false;
            panel_Author.Visible = false;
            главнаяToolStripMenuItem.Enabled = false;
            личныйКабинетToolStripMenuItem.Enabled = true;
            оToolStripMenuItem.Enabled = true;
        }
        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Visible = false;
            panel_User.Visible = true;
            panel_Author.Visible = false;
            главнаяToolStripMenuItem.Enabled = true;
            личныйКабинетToolStripMenuItem.Enabled = false;
            оToolStripMenuItem.Enabled = true;
        }
        private void оToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Main.Visible = false;
            panel_User.Visible = false;
            panel_Author.Visible = true;
            главнаяToolStripMenuItem.Enabled = true;
            личныйКабинетToolStripMenuItem.Enabled = true;
            оToolStripMenuItem.Enabled = false;
        }
        private void button_Change_Click(object sender, EventArgs e)
        {
            if (!textBox_Ex_Password.Text.Equals("") && !textBox_New_Password.Text.Equals("") && !textBox_New_Password_Again.Text.Equals(""))
            {
                var user = _logic.Read(new UserBindingModel
                {
                    Name = name
                })[0];
                if (HashPassword(textBox_Ex_Password.Text).Equals(user.Password, StringComparison.OrdinalIgnoreCase))
                {
                    if (textBox_New_Password.Text.Equals(textBox_New_Password_Again.Text))
                    {
                        try
                        {
                            _logic.ChangePassword(new UserBindingModel
                            {
                                Name = user.Name,
                                Password = textBox_New_Password.Text,
                            });
                            textBox_Ex_Password.Text = string.Empty;
                            textBox_New_Password.Text = string.Empty;
                            textBox_New_Password_Again.Text = string.Empty;
                            MessageBox.Show("Пароль изменён.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Пароль и его подтверждение должны совпадать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Старый пароль заполнен неверно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните поля текущего пароля, пароля и подтверждения пароля.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox_Ex_Password.Text = string.Empty;
            textBox_New_Password.Text = string.Empty;
            textBox_New_Password_Again.Text = string.Empty;
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            textBox_Ex_Password.Text = string.Empty;
            textBox_New_Password.Text = string.Empty;
            textBox_New_Password_Again.Text = string.Empty;
        }
        private string HashPassword(string password)
        {
            MD4 md4 = new MD4();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = md4.ComputeHash(passwordBytes);
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
        }
    }
}
