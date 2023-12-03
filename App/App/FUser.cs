using Contracts.BindingModels;
using Contracts.BusinessLogicContracts;

namespace App
{
    public partial class FUser : Form
    {
        private readonly IUserLogic _logic;
        public int Id { set { id = value; } }
        private int? id;
        public FUser(IUserLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }
        private void FUser_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                checkBox_Update.Visible = true;
                var view = _logic.Read(new UserBindingModel { Id = id })?[0];
                if (view != null)
                {
                    textBox_Name.Text = view.Name;
                    numericUpDown_Length.Value = view.PasswordLength;
                    numericUpDown_Lifetime.Value = view.PasswordLifetime;
                    checkBox_isDisabled.Checked = view.isDisabled;
                    checkBox_isLetters.Checked = view.isLettersRequired;
                    checkBox_isSymb.Checked = view.isSymbolsRequired;
                    checkBox_isAryphm.Checked = view.isAryphmsRequired;
                }
            } else
            {
                checkBox_Update.Visible = false;
            }
        }
        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text.Equals(""))
            {
                MessageBox.Show("Заполните имя пользователя.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (id.HasValue)
            {
                var user_old = _logic.Read(new UserBindingModel { Id = id })?[0];
                UserBindingModel user_new = new UserBindingModel 
                { 
                    Id = user_old.Id,
                    Name = textBox_Name.Text,
                    Password = user_old.Password,
                    PasswordLength = Convert.ToInt32(numericUpDown_Length.Value),
                    PasswordLifetime = Convert.ToInt32(numericUpDown_Lifetime.Value),
                    isDisabled = checkBox_isDisabled.Checked,
                    isLettersRequired = checkBox_isLetters.Checked,
                    isSymbolsRequired = checkBox_isSymb.Checked,
                    isAryphmsRequired = checkBox_isAryphm.Checked,
                    inUsage = user_old.inUsage
                };
                if (user_old.isLettersRequired != user_new.isLettersRequired || 
                    user_old.isSymbolsRequired != user_new.isSymbolsRequired || 
                    user_old.isAryphmsRequired != user_new.isAryphmsRequired ||
                    user_old.Password.Length < Convert.ToInt32(numericUpDown_Length.Value)) 
                {
                    user_new.Password = "";
                }
                if (checkBox_Update.Checked)
                {
                    user_new.inUsage = DateTime.Now;
                }
                _logic.CreateOrUpdate(user_new);
            } else
            {
                _logic.CreateOrUpdate(new UserBindingModel
                {
                    Name = textBox_Name.Text,
                    Password = "",
                    PasswordLength = Convert.ToInt32(numericUpDown_Length.Value),
                    PasswordLifetime = Convert.ToInt32(numericUpDown_Lifetime.Value),
                    isDisabled = checkBox_isDisabled.Checked,
                    isLettersRequired = checkBox_isLetters.Checked,
                    isSymbolsRequired = checkBox_isSymb.Checked,
                    isAryphmsRequired = checkBox_isAryphm.Checked
                });
            }
            MessageBox.Show("Успешно.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void button_Back_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
