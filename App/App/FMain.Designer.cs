namespace App
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            menu = new MenuStrip();
            главнаяToolStripMenuItem = new ToolStripMenuItem();
            личныйКабинетToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оToolStripMenuItem = new ToolStripMenuItem();
            panel_Main = new Panel();
            label_text = new Label();
            label_Hello = new Label();
            panel_User = new Panel();
            groupBox_Password_Change = new GroupBox();
            button_Cancel = new Button();
            label_Pswd_again = new Label();
            textBox_New_Password_Again = new TextBox();
            button_Change = new Button();
            label_New = new Label();
            label_Ex = new Label();
            textBox_New_Password = new TextBox();
            textBox_Ex_Password = new TextBox();
            label_User = new Label();
            label_Priv_Inf = new Label();
            panel_Author = new Panel();
            groupBox_individual = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label_Ogr = new Label();
            label_Variant = new Label();
            groupBox_Contacts = new GroupBox();
            linkLabel_Mail = new LinkLabel();
            linkLabel_TG = new LinkLabel();
            linkLabel_VK = new LinkLabel();
            label_Mail = new Label();
            label_TG = new Label();
            label_VK = new Label();
            label_Group = new Label();
            label_Author = new Label();
            label_Author_Hello = new Label();
            menu.SuspendLayout();
            panel_Main.SuspendLayout();
            panel_User.SuspendLayout();
            groupBox_Password_Change.SuspendLayout();
            panel_Author.SuspendLayout();
            groupBox_individual.SuspendLayout();
            groupBox_Contacts.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { главнаяToolStripMenuItem, личныйКабинетToolStripMenuItem, справкаToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 28);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            главнаяToolStripMenuItem.Size = new Size(79, 24);
            главнаяToolStripMenuItem.Text = "Главная";
            главнаяToolStripMenuItem.Click += главнаяToolStripMenuItem_Click;
            // 
            // личныйКабинетToolStripMenuItem
            // 
            личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            личныйКабинетToolStripMenuItem.Size = new Size(139, 24);
            личныйКабинетToolStripMenuItem.Text = "Личный кабинет";
            личныйКабинетToolStripMenuItem.Click += личныйКабинетToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // оToolStripMenuItem
            // 
            оToolStripMenuItem.Name = "оToolStripMenuItem";
            оToolStripMenuItem.Size = new Size(187, 26);
            оToolStripMenuItem.Text = "О программе";
            оToolStripMenuItem.Click += оToolStripMenuItem_Click;
            // 
            // panel_Main
            // 
            panel_Main.Controls.Add(label_text);
            panel_Main.Controls.Add(label_Hello);
            panel_Main.Location = new Point(12, 31);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(776, 176);
            panel_Main.TabIndex = 1;
            panel_Main.Visible = false;
            // 
            // label_text
            // 
            label_text.AutoSize = true;
            label_text.Location = new Point(12, 64);
            label_text.Name = "label_text";
            label_text.Size = new Size(736, 60);
            label_text.TabIndex = 1;
            label_text.Text = resources.GetString("label_text.Text");
            // 
            // label_Hello
            // 
            label_Hello.AutoSize = true;
            label_Hello.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Hello.Location = new Point(12, 13);
            label_Hello.Name = "label_Hello";
            label_Hello.Size = new Size(238, 32);
            label_Hello.TabIndex = 0;
            label_Hello.Text = "Добро пожаловать, ";
            // 
            // panel_User
            // 
            panel_User.Controls.Add(groupBox_Password_Change);
            panel_User.Controls.Add(label_User);
            panel_User.Controls.Add(label_Priv_Inf);
            panel_User.Location = new Point(8, 31);
            panel_User.Name = "panel_User";
            panel_User.Size = new Size(780, 396);
            panel_User.TabIndex = 2;
            // 
            // groupBox_Password_Change
            // 
            groupBox_Password_Change.Controls.Add(button_Cancel);
            groupBox_Password_Change.Controls.Add(label_Pswd_again);
            groupBox_Password_Change.Controls.Add(textBox_New_Password_Again);
            groupBox_Password_Change.Controls.Add(button_Change);
            groupBox_Password_Change.Controls.Add(label_New);
            groupBox_Password_Change.Controls.Add(label_Ex);
            groupBox_Password_Change.Controls.Add(textBox_New_Password);
            groupBox_Password_Change.Controls.Add(textBox_Ex_Password);
            groupBox_Password_Change.Location = new Point(31, 111);
            groupBox_Password_Change.Name = "groupBox_Password_Change";
            groupBox_Password_Change.Size = new Size(351, 268);
            groupBox_Password_Change.TabIndex = 3;
            groupBox_Password_Change.TabStop = false;
            groupBox_Password_Change.Text = "Изменить пароль";
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(145, 229);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(94, 29);
            button_Cancel.TabIndex = 7;
            button_Cancel.Text = "Отмена";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // label_Pswd_again
            // 
            label_Pswd_again.AutoSize = true;
            label_Pswd_again.Location = new Point(6, 169);
            label_Pswd_again.Name = "label_Pswd_again";
            label_Pswd_again.Size = new Size(139, 20);
            label_Pswd_again.TabIndex = 6;
            label_Pswd_again.Text = "Повторите пароль";
            // 
            // textBox_New_Password_Again
            // 
            textBox_New_Password_Again.Location = new Point(6, 192);
            textBox_New_Password_Again.Name = "textBox_New_Password_Again";
            textBox_New_Password_Again.Size = new Size(333, 27);
            textBox_New_Password_Again.TabIndex = 5;
            textBox_New_Password_Again.UseSystemPasswordChar = true;
            // 
            // button_Change
            // 
            button_Change.Location = new Point(245, 229);
            button_Change.Name = "button_Change";
            button_Change.Size = new Size(94, 29);
            button_Change.TabIndex = 4;
            button_Change.Text = "Изменить";
            button_Change.UseVisualStyleBackColor = true;
            button_Change.Click += button_Change_Click;
            // 
            // label_New
            // 
            label_New.AutoSize = true;
            label_New.Location = new Point(6, 102);
            label_New.Name = "label_New";
            label_New.Size = new Size(113, 20);
            label_New.TabIndex = 3;
            label_New.Text = "Новый пороль";
            // 
            // label_Ex
            // 
            label_Ex.AutoSize = true;
            label_Ex.Location = new Point(6, 42);
            label_Ex.Name = "label_Ex";
            label_Ex.Size = new Size(125, 20);
            label_Ex.TabIndex = 2;
            label_Ex.Text = "Текущий пороль";
            // 
            // textBox_New_Password
            // 
            textBox_New_Password.Location = new Point(6, 125);
            textBox_New_Password.Name = "textBox_New_Password";
            textBox_New_Password.Size = new Size(333, 27);
            textBox_New_Password.TabIndex = 1;
            textBox_New_Password.UseSystemPasswordChar = true;
            // 
            // textBox_Ex_Password
            // 
            textBox_Ex_Password.Location = new Point(6, 65);
            textBox_Ex_Password.Name = "textBox_Ex_Password";
            textBox_Ex_Password.Size = new Size(333, 27);
            textBox_Ex_Password.TabIndex = 0;
            textBox_Ex_Password.UseSystemPasswordChar = true;
            // 
            // label_User
            // 
            label_User.AutoSize = true;
            label_User.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_User.Location = new Point(31, 64);
            label_User.Name = "label_User";
            label_User.Size = new Size(119, 20);
            label_User.TabIndex = 2;
            label_User.Text = "Пользователь: ";
            // 
            // label_Priv_Inf
            // 
            label_Priv_Inf.AutoSize = true;
            label_Priv_Inf.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Priv_Inf.Location = new Point(31, 13);
            label_Priv_Inf.Name = "label_Priv_Inf";
            label_Priv_Inf.Size = new Size(199, 32);
            label_Priv_Inf.TabIndex = 1;
            label_Priv_Inf.Text = "Личный кабинет";
            // 
            // panel_Author
            // 
            panel_Author.Controls.Add(groupBox_individual);
            panel_Author.Controls.Add(groupBox_Contacts);
            panel_Author.Controls.Add(label_Group);
            panel_Author.Controls.Add(label_Author);
            panel_Author.Controls.Add(label_Author_Hello);
            panel_Author.Location = new Point(8, 31);
            panel_Author.Name = "panel_Author";
            panel_Author.Size = new Size(777, 562);
            panel_Author.TabIndex = 3;
            // 
            // groupBox_individual
            // 
            groupBox_individual.Controls.Add(label3);
            groupBox_individual.Controls.Add(label2);
            groupBox_individual.Controls.Add(label1);
            groupBox_individual.Controls.Add(label_Ogr);
            groupBox_individual.Controls.Add(label_Variant);
            groupBox_individual.Location = new Point(31, 303);
            groupBox_individual.Name = "groupBox_individual";
            groupBox_individual.Size = new Size(601, 248);
            groupBox_individual.TabIndex = 6;
            groupBox_individual.TabStop = false;
            groupBox_individual.Text = "Индивидуальное задание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 215);
            label3.Name = "label3";
            label3.Size = new Size(378, 20);
            label3.TabIndex = 4;
            label3.Text = "Используемый алгоритм хеширования пароля: MD4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 172);
            label2.Name = "label2";
            label2.Size = new Size(338, 20);
            label2.TabIndex = 3;
            label2.Text = "Добавление к ключу случайного значения: Нет";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 133);
            label1.Name = "label1";
            label1.Size = new Size(574, 20);
            label1.TabIndex = 2;
            label1.Text = "Используемый режим шифрования алгоритма DES для шифрования файла: OFB";
            // 
            // label_Ogr
            // 
            label_Ogr.AutoSize = true;
            label_Ogr.Location = new Point(17, 79);
            label_Ogr.Name = "label_Ogr";
            label_Ogr.Size = new Size(513, 40);
            label_Ogr.TabIndex = 1;
            label_Ogr.Text = "Ограничения на выбираемые пароли:\r\nНаличие букв, знаков препинания и знаков арифметических операций.\r\n";
            // 
            // label_Variant
            // 
            label_Variant.AutoSize = true;
            label_Variant.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_Variant.Location = new Point(17, 39);
            label_Variant.Name = "label_Variant";
            label_Variant.Size = new Size(86, 20);
            label_Variant.TabIndex = 0;
            label_Variant.Text = "Вариант: 4";
            // 
            // groupBox_Contacts
            // 
            groupBox_Contacts.Controls.Add(linkLabel_Mail);
            groupBox_Contacts.Controls.Add(linkLabel_TG);
            groupBox_Contacts.Controls.Add(linkLabel_VK);
            groupBox_Contacts.Controls.Add(label_Mail);
            groupBox_Contacts.Controls.Add(label_TG);
            groupBox_Contacts.Controls.Add(label_VK);
            groupBox_Contacts.Location = new Point(28, 152);
            groupBox_Contacts.Name = "groupBox_Contacts";
            groupBox_Contacts.Size = new Size(371, 136);
            groupBox_Contacts.TabIndex = 5;
            groupBox_Contacts.TabStop = false;
            groupBox_Contacts.Text = "Контактная информация";
            // 
            // linkLabel_Mail
            // 
            linkLabel_Mail.AutoSize = true;
            linkLabel_Mail.Location = new Point(121, 99);
            linkLabel_Mail.Name = "linkLabel_Mail";
            linkLabel_Mail.Size = new Size(137, 20);
            linkLabel_Mail.TabIndex = 5;
            linkLabel_Mail.TabStop = true;
            linkLabel_Mail.Text = "Retr073@yandex.ru";
            // 
            // linkLabel_TG
            // 
            linkLabel_TG.AutoSize = true;
            linkLabel_TG.Location = new Point(121, 69);
            linkLabel_TG.Name = "linkLabel_TG";
            linkLabel_TG.Size = new Size(218, 20);
            linkLabel_TG.TabIndex = 4;
            linkLabel_TG.TabStop = true;
            linkLabel_TG.Text = "https://t.me/drinking_sweatshirt";
            // 
            // linkLabel_VK
            // 
            linkLabel_VK.AutoSize = true;
            linkLabel_VK.Location = new Point(121, 39);
            linkLabel_VK.Name = "linkLabel_VK";
            linkLabel_VK.Size = new Size(235, 20);
            linkLabel_VK.TabIndex = 3;
            linkLabel_VK.TabStop = true;
            linkLabel_VK.Text = "https://vk.com/drinking_sweatshirt";
            // 
            // label_Mail
            // 
            label_Mail.AutoSize = true;
            label_Mail.Location = new Point(17, 99);
            label_Mail.Name = "label_Mail";
            label_Mail.Size = new Size(76, 20);
            label_Mail.TabIndex = 2;
            label_Mail.Text = "Эл. почта:";
            // 
            // label_TG
            // 
            label_TG.AutoSize = true;
            label_TG.Location = new Point(17, 69);
            label_TG.Name = "label_TG";
            label_TG.Size = new Size(62, 20);
            label_TG.TabIndex = 1;
            label_TG.Text = "Мой ТГ:";
            // 
            // label_VK
            // 
            label_VK.AutoSize = true;
            label_VK.Location = new Point(17, 39);
            label_VK.Name = "label_VK";
            label_VK.Size = new Size(65, 20);
            label_VK.TabIndex = 0;
            label_VK.Text = "Мой ВК:";
            // 
            // label_Group
            // 
            label_Group.AutoSize = true;
            label_Group.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_Group.Location = new Point(28, 101);
            label_Group.Name = "label_Group";
            label_Group.Size = new Size(132, 20);
            label_Group.TabIndex = 4;
            label_Group.Text = "Группа: ПИбд-42";
            // 
            // label_Author
            // 
            label_Author.AutoSize = true;
            label_Author.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_Author.Location = new Point(28, 61);
            label_Author.Name = "label_Author";
            label_Author.Size = new Size(300, 20);
            label_Author.TabIndex = 3;
            label_Author.Text = "Автор: Арутюнян Дмитрий Аркадьевич";
            // 
            // label_Author_Hello
            // 
            label_Author_Hello.AutoSize = true;
            label_Author_Hello.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Author_Hello.Location = new Point(28, 10);
            label_Author_Hello.Name = "label_Author_Hello";
            label_Author_Hello.Size = new Size(129, 32);
            label_Author_Hello.TabIndex = 2;
            label_Author_Hello.Text = "Об авторе";
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 605);
            Controls.Add(menu);
            Controls.Add(panel_Author);
            Controls.Add(panel_User);
            Controls.Add(panel_Main);
            Name = "FMain";
            Text = "Приложение";
            Load += FMain_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            panel_Main.ResumeLayout(false);
            panel_Main.PerformLayout();
            panel_User.ResumeLayout(false);
            panel_User.PerformLayout();
            groupBox_Password_Change.ResumeLayout(false);
            groupBox_Password_Change.PerformLayout();
            panel_Author.ResumeLayout(false);
            panel_Author.PerformLayout();
            groupBox_individual.ResumeLayout(false);
            groupBox_individual.PerformLayout();
            groupBox_Contacts.ResumeLayout(false);
            groupBox_Contacts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem главнаяToolStripMenuItem;
        private ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оToolStripMenuItem;
        private Panel panel_Main;
        private Label label_Hello;
        private Label label_text;
        private Panel panel_User;
        private Label label_User;
        private Label label_Priv_Inf;
        private GroupBox groupBox_Password_Change;
        private Button button_Change;
        private Label label_New;
        private Label label_Ex;
        private TextBox textBox_New_Password;
        private TextBox textBox_Ex_Password;
        private Panel panel_Author;
        private Label label_Group;
        private Label label_Author;
        private Label label_Author_Hello;
        private GroupBox groupBox_Contacts;
        private LinkLabel linkLabel_Mail;
        private LinkLabel linkLabel_TG;
        private LinkLabel linkLabel_VK;
        private Label label_Mail;
        private Label label_TG;
        private Label label_VK;
        private Label label_Pswd_again;
        private TextBox textBox_New_Password_Again;
        private GroupBox groupBox_individual;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private Label label1;
        private Label label2;
        private Label label_Variant;
        private Label label3;
        private Label label_Ogr;
        private Button button_Cancel;
    }
}