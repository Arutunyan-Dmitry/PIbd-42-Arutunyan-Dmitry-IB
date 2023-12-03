using AssetRipper.HashAlgorithms;
using Contracts.BindingModels;
using Contracts.BusinessLogicContracts;
using Contracts.ViewModels;
using System.Text;
using Unity;

namespace App
{
    public partial class FAuthorisation : Form
    {
        private readonly IUserLogic _userLogic;
        private int counter = 0;
        public FAuthorisation(IUserLogic userLogic)
        {
            InitializeComponent();
            panel_Auth.Visible = true;
            panel_Auth_fst.Visible = false;
            _userLogic = userLogic;
        }
        private void FAuthorisation_Load(object sender, EventArgs e)
        {
            _userLogic.CheckPasswordLifeTime();
        }
        private void button_Submit_Click(object sender, EventArgs e)
        {
            UserViewModel user;
            if (counter >= 2)
            {
                MessageBox.Show("Превышено кол-во попыток ввода пароля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            if (!textBox_Name.Text.Equals("") || !textBox_Name_fst.Text.Equals(""))
            {
                var users = _userLogic.Read(new UserBindingModel
                {
                    Name = textBox_Name.Text
                });
                if (users.Count == 0)
                {
                    MessageBox.Show("Проверьте корректность написания имени пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else
                {
                    user = users[0];
                }
                if (user.isDisabled)
                {
                    MessageBox.Show("Вы не можете пользоваться данным приложением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                if (user.Password.Equals(""))
                {
                    panel_Auth.Visible = false;
                    panel_Auth_fst.Visible = true;
                    textBox_Name_fst.Text = textBox_Name.Text;
                    if (!textBox_Password_fst.Text.Equals("") && !textBox_Password_again_fst.Text.Equals(""))
                    {                      
                        if (textBox_Password_fst.Text.Equals(textBox_Password_again_fst.Text))
                        {
                            try
                            {
                                _userLogic.ChangePassword(new UserBindingModel
                                {
                                    Name = user.Name,
                                    Password = textBox_Password_fst.Text,
                                });
                            } catch(Exception ex) 
                            {
                                MessageBox.Show(ex.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            if (textBox_Name_fst.Text == "ADMIN")
                            {
                                this.Hide();
                                var form = Program.Container.Resolve<FAdmin>();
                                form.Closed += (s, args) => this.Close();
                                form.Show();
                            }
                            else
                            {
                                this.Hide();
                                var form = Program.Container.Resolve<FMain>();
                                form.Name = user.Name;
                                form.Closed += (s, args) => this.Close();
                                form.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пароль и его подтверждение должны совпадать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    panel_Auth.Visible = true;
                    panel_Auth_fst.Visible = false;
                    if (!textBox_Password.Text.Equals(""))
                    {     
                        if (HashPassword(textBox_Password.Text).Equals(user.Password, StringComparison.OrdinalIgnoreCase))
                        {
                            if (textBox_Name.Text == "ADMIN")
                            {
                                this.Hide();
                                var form = Program.Container.Resolve<FAdmin>();
                                form.Closed += (s, args) => this.Close();
                                form.Show();
                            }
                            else
                            {
                                this.Hide();
                                var form = Program.Container.Resolve<FMain>();
                                form.Name = user.Name;
                                form.Closed += (s, args) => this.Close();
                                form.Show();
                            }
                        }
                        else
                        {
                            counter++;
                            MessageBox.Show("Пароль неверный. Кол-во попыток: " + (3 - counter), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите пароль.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите имя пользователя.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void linkLabel_first_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_Auth.Visible = false;
            panel_Auth_fst.Visible = true;
        }
        private void button_Back_Click(object sender, EventArgs e)
        {
            panel_Auth.Visible = true;
            panel_Auth_fst.Visible = false;
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
