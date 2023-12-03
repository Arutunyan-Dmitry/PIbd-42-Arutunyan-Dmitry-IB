using AssetRipper.HashAlgorithms;
using Contracts.BindingModels;
using Contracts.BusinessLogicContracts;
using System.Text;
using Unity;

namespace App
{
    public partial class FAdmin : Form
    {
        private readonly IUserLogic _logic;
        public FAdmin(IUserLogic logic)
        {
            InitializeComponent();
            panel_Users.Visible = true;
            panel_Privacy.Visible = false;
            пользователиToolStripMenuItem.Enabled = false;
            личныйКабинетToolStripMenuItem.Enabled = true;
            _logic = logic;
        }
        private void FAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = _logic.Read(null);
                list.RemoveAt(0);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[2].Visible = false;
                    dataGridView.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Users.Visible = true;
            panel_Privacy.Visible = false;
            пользователиToolStripMenuItem.Enabled = false;
            личныйКабинетToolStripMenuItem.Enabled = true;
        }
        private void личныйКабинетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Users.Visible = false;
            panel_Privacy.Visible = true;
            пользователиToolStripMenuItem.Enabled = true;
            личныйКабинетToolStripMenuItem.Enabled = false;
        }
        private void button_Create_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FUser>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void button_Update_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FUser>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _logic.Delete(new UserBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button_Change_Click(object sender, EventArgs e)
        {
            if (!textBox_Ex_Password.Text.Equals("") && !textBox_New_Password.Text.Equals("") && !textBox_Password_New_Again.Text.Equals(""))
            {
                var admin = _logic.Read(new UserBindingModel
                {
                    Name = "ADMIN"
                })[0];
                if (HashPassword(textBox_Ex_Password.Text).Equals(admin.Password, StringComparison.OrdinalIgnoreCase))
                {
                    if (textBox_New_Password.Text.Equals(textBox_Password_New_Again.Text))
                    {
                        try
                        {
                            _logic.ChangePassword(new UserBindingModel
                            {
                                Name = admin.Name,
                                Password = textBox_New_Password.Text,
                            });
                            textBox_Ex_Password.Text = string.Empty;
                            textBox_New_Password.Text = string.Empty;
                            textBox_Password_New_Again.Text = string.Empty;
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
            textBox_Password_New_Again.Text = string.Empty;
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            textBox_Ex_Password.Text = string.Empty;
            textBox_New_Password.Text = string.Empty;
            textBox_Password_New_Again.Text = string.Empty;
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
