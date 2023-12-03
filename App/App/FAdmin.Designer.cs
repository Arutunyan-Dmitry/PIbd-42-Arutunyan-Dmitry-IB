namespace App
{
    partial class FAdmin
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
            panel_Users = new Panel();
            button_Delete = new Button();
            button_Update = new Button();
            button_Create = new Button();
            label_Users = new Label();
            dataGridView = new DataGridView();
            menu = new MenuStrip();
            пользователиToolStripMenuItem = new ToolStripMenuItem();
            личныйКабинетToolStripMenuItem = new ToolStripMenuItem();
            panel_Privacy = new Panel();
            groupBox_Password_Change = new GroupBox();
            label_Pswd_again = new Label();
            textBox_Password_New_Again = new TextBox();
            button_Change = new Button();
            label_New = new Label();
            label_Ex = new Label();
            textBox_New_Password = new TextBox();
            textBox_Ex_Password = new TextBox();
            label_pr_pl = new Label();
            button_Cancel = new Button();
            panel_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menu.SuspendLayout();
            panel_Privacy.SuspendLayout();
            groupBox_Password_Change.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Users
            // 
            panel_Users.Controls.Add(button_Delete);
            panel_Users.Controls.Add(button_Update);
            panel_Users.Controls.Add(button_Create);
            panel_Users.Controls.Add(label_Users);
            panel_Users.Controls.Add(dataGridView);
            panel_Users.Location = new Point(12, 31);
            panel_Users.Name = "panel_Users";
            panel_Users.Size = new Size(1118, 526);
            panel_Users.TabIndex = 0;
            // 
            // button_Delete
            // 
            button_Delete.Location = new Point(1010, 131);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(94, 29);
            button_Delete.TabIndex = 4;
            button_Delete.Text = "Удалить";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Update
            // 
            button_Update.Location = new Point(1010, 96);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(94, 29);
            button_Update.TabIndex = 3;
            button_Update.Text = "Изменить";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // button_Create
            // 
            button_Create.Location = new Point(1010, 61);
            button_Create.Name = "button_Create";
            button_Create.Size = new Size(94, 29);
            button_Create.TabIndex = 2;
            button_Create.Text = "Создать";
            button_Create.UseVisualStyleBackColor = true;
            button_Create.Click += button_Create_Click;
            // 
            // label_Users
            // 
            label_Users.AutoSize = true;
            label_Users.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Users.Location = new Point(16, 15);
            label_Users.Name = "label_Users";
            label_Users.Size = new Size(170, 32);
            label_Users.TabIndex = 1;
            label_Users.Text = "Пользователи";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(0, 61);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new Size(1004, 462);
            dataGridView.TabIndex = 0;
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { пользователиToolStripMenuItem, личныйКабинетToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1133, 28);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
            // 
            // пользователиToolStripMenuItem
            // 
            пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            пользователиToolStripMenuItem.Size = new Size(122, 24);
            пользователиToolStripMenuItem.Text = "Пользователи";
            пользователиToolStripMenuItem.Click += пользователиToolStripMenuItem_Click;
            // 
            // личныйКабинетToolStripMenuItem
            // 
            личныйКабинетToolStripMenuItem.Name = "личныйКабинетToolStripMenuItem";
            личныйКабинетToolStripMenuItem.Size = new Size(139, 24);
            личныйКабинетToolStripMenuItem.Text = "Личный кабинет";
            личныйКабинетToolStripMenuItem.Click += личныйКабинетToolStripMenuItem_Click;
            // 
            // panel_Privacy
            // 
            panel_Privacy.Controls.Add(groupBox_Password_Change);
            panel_Privacy.Controls.Add(label_pr_pl);
            panel_Privacy.Location = new Point(12, 31);
            panel_Privacy.Name = "panel_Privacy";
            panel_Privacy.Size = new Size(776, 419);
            panel_Privacy.TabIndex = 5;
            // 
            // groupBox_Password_Change
            // 
            groupBox_Password_Change.Controls.Add(button_Cancel);
            groupBox_Password_Change.Controls.Add(label_Pswd_again);
            groupBox_Password_Change.Controls.Add(textBox_Password_New_Again);
            groupBox_Password_Change.Controls.Add(button_Change);
            groupBox_Password_Change.Controls.Add(label_New);
            groupBox_Password_Change.Controls.Add(label_Ex);
            groupBox_Password_Change.Controls.Add(textBox_New_Password);
            groupBox_Password_Change.Controls.Add(textBox_Ex_Password);
            groupBox_Password_Change.Location = new Point(32, 61);
            groupBox_Password_Change.Name = "groupBox_Password_Change";
            groupBox_Password_Change.Size = new Size(351, 275);
            groupBox_Password_Change.TabIndex = 4;
            groupBox_Password_Change.TabStop = false;
            groupBox_Password_Change.Text = "Изменить пароль";
            // 
            // label_Pswd_again
            // 
            label_Pswd_again.AutoSize = true;
            label_Pswd_again.Location = new Point(6, 168);
            label_Pswd_again.Name = "label_Pswd_again";
            label_Pswd_again.Size = new Size(176, 20);
            label_Pswd_again.TabIndex = 6;
            label_Pswd_again.Text = "Подтверждение пароля";
            // 
            // textBox_Password_New_Again
            // 
            textBox_Password_New_Again.Location = new Point(6, 191);
            textBox_Password_New_Again.Name = "textBox_Password_New_Again";
            textBox_Password_New_Again.Size = new Size(333, 27);
            textBox_Password_New_Again.TabIndex = 5;
            textBox_Password_New_Again.UseSystemPasswordChar = true;
            // 
            // button_Change
            // 
            button_Change.Location = new Point(251, 240);
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
            // label_pr_pl
            // 
            label_pr_pl.AutoSize = true;
            label_pr_pl.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_pr_pl.Location = new Point(32, 15);
            label_pr_pl.Name = "label_pr_pl";
            label_pr_pl.Size = new Size(199, 32);
            label_pr_pl.TabIndex = 2;
            label_pr_pl.Text = "Личный кабинет";
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(151, 240);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(94, 29);
            button_Cancel.TabIndex = 7;
            button_Cancel.Text = "Отмена";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // FAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 569);
            Controls.Add(menu);
            Controls.Add(panel_Privacy);
            Controls.Add(panel_Users);
            MainMenuStrip = menu;
            Name = "FAdmin";
            Text = "Панель администратора";
            Load += FAdmin_Load;
            panel_Users.ResumeLayout(false);
            panel_Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            panel_Privacy.ResumeLayout(false);
            panel_Privacy.PerformLayout();
            groupBox_Password_Change.ResumeLayout(false);
            groupBox_Password_Change.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_Users;
        private DataGridView dataGridView;
        private MenuStrip menu;
        private ToolStripMenuItem пользователиToolStripMenuItem;
        private ToolStripMenuItem личныйКабинетToolStripMenuItem;
        private Button button_Delete;
        private Button button_Update;
        private Button button_Create;
        private Label label_Users;
        private Panel panel_Privacy;
        private Label label_pr_pl;
        private GroupBox groupBox_Password_Change;
        private Button button_Change;
        private Label label_New;
        private Label label_Ex;
        private TextBox textBox_New_Password;
        private TextBox textBox_Ex_Password;
        private Label label_Pswd_again;
        private TextBox textBox_Password_New_Again;
        private Button button_Cancel;
    }
}