namespace App
{
    partial class FAuthorisation
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
            panel_Auth = new Panel();
            linkLabel_first = new LinkLabel();
            button_Submit = new Button();
            label_Password = new Label();
            label_Name = new Label();
            textBox_Password = new TextBox();
            textBox_Name = new TextBox();
            label_Enter = new Label();
            panel_Auth_fst = new Panel();
            button_Back = new Button();
            label3 = new Label();
            textBox_Password_again_fst = new TextBox();
            button_Submit_fst = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_Password_fst = new TextBox();
            textBox_Name_fst = new TextBox();
            label_Enter_fst = new Label();
            panel_Auth.SuspendLayout();
            panel_Auth_fst.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Auth
            // 
            panel_Auth.Controls.Add(linkLabel_first);
            panel_Auth.Controls.Add(button_Submit);
            panel_Auth.Controls.Add(label_Password);
            panel_Auth.Controls.Add(label_Name);
            panel_Auth.Controls.Add(textBox_Password);
            panel_Auth.Controls.Add(textBox_Name);
            panel_Auth.Controls.Add(label_Enter);
            panel_Auth.Location = new Point(12, 12);
            panel_Auth.Name = "panel_Auth";
            panel_Auth.Size = new Size(299, 322);
            panel_Auth.TabIndex = 7;
            // 
            // linkLabel_first
            // 
            linkLabel_first.AutoSize = true;
            linkLabel_first.Location = new Point(17, 216);
            linkLabel_first.Name = "linkLabel_first";
            linkLabel_first.Size = new Size(106, 20);
            linkLabel_first.TabIndex = 13;
            linkLabel_first.TabStop = true;
            linkLabel_first.Text = "Я тут впервые";
            linkLabel_first.LinkClicked += linkLabel_first_LinkClicked;
            // 
            // button_Submit
            // 
            button_Submit.Location = new Point(101, 281);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(94, 29);
            button_Submit.TabIndex = 12;
            button_Submit.Text = "Войти";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Location = new Point(17, 152);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(62, 20);
            label_Password.TabIndex = 11;
            label_Password.Text = "Пароль";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(17, 84);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(139, 20);
            label_Name.TabIndex = 10;
            label_Name.Text = "Имя пользователя";
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(17, 175);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(264, 27);
            textBox_Password.TabIndex = 9;
            textBox_Password.UseSystemPasswordChar = true;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(17, 107);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(264, 27);
            textBox_Name.TabIndex = 8;
            // 
            // label_Enter
            // 
            label_Enter.AutoSize = true;
            label_Enter.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_Enter.Location = new Point(101, 12);
            label_Enter.Name = "label_Enter";
            label_Enter.Size = new Size(94, 46);
            label_Enter.TabIndex = 7;
            label_Enter.Text = "Вход";
            // 
            // panel_Auth_fst
            // 
            panel_Auth_fst.Controls.Add(button_Back);
            panel_Auth_fst.Controls.Add(label3);
            panel_Auth_fst.Controls.Add(textBox_Password_again_fst);
            panel_Auth_fst.Controls.Add(button_Submit_fst);
            panel_Auth_fst.Controls.Add(label1);
            panel_Auth_fst.Controls.Add(label2);
            panel_Auth_fst.Controls.Add(textBox_Password_fst);
            panel_Auth_fst.Controls.Add(textBox_Name_fst);
            panel_Auth_fst.Controls.Add(label_Enter_fst);
            panel_Auth_fst.Location = new Point(12, 12);
            panel_Auth_fst.Name = "panel_Auth_fst";
            panel_Auth_fst.Size = new Size(309, 322);
            panel_Auth_fst.TabIndex = 8;
            // 
            // button_Back
            // 
            button_Back.Location = new Point(47, 275);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(94, 29);
            button_Back.TabIndex = 21;
            button_Back.Text = "Назад";
            button_Back.UseVisualStyleBackColor = true;
            button_Back.Click += button_Back_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 205);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 20;
            label3.Text = "Повторите пароль";
            // 
            // textBox_Password_again_fst
            // 
            textBox_Password_again_fst.Location = new Point(18, 228);
            textBox_Password_again_fst.Name = "textBox_Password_again_fst";
            textBox_Password_again_fst.Size = new Size(264, 27);
            textBox_Password_again_fst.TabIndex = 19;
            textBox_Password_again_fst.UseSystemPasswordChar = true;
            // 
            // button_Submit_fst
            // 
            button_Submit_fst.Location = new Point(147, 275);
            button_Submit_fst.Name = "button_Submit_fst";
            button_Submit_fst.Size = new Size(94, 29);
            button_Submit_fst.TabIndex = 18;
            button_Submit_fst.Text = "Войти";
            button_Submit_fst.UseVisualStyleBackColor = true;
            button_Submit_fst.Click += button_Submit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 143);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 17;
            label1.Text = "Придумайте пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 84);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 16;
            label2.Text = "Имя пользователя";
            // 
            // textBox_Password_fst
            // 
            textBox_Password_fst.Location = new Point(18, 166);
            textBox_Password_fst.Name = "textBox_Password_fst";
            textBox_Password_fst.Size = new Size(264, 27);
            textBox_Password_fst.TabIndex = 15;
            textBox_Password_fst.UseSystemPasswordChar = true;
            // 
            // textBox_Name_fst
            // 
            textBox_Name_fst.Location = new Point(18, 107);
            textBox_Name_fst.Name = "textBox_Name_fst";
            textBox_Name_fst.Size = new Size(264, 27);
            textBox_Name_fst.TabIndex = 14;
            // 
            // label_Enter_fst
            // 
            label_Enter_fst.AutoSize = true;
            label_Enter_fst.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_Enter_fst.Location = new Point(102, 12);
            label_Enter_fst.Name = "label_Enter_fst";
            label_Enter_fst.Size = new Size(94, 46);
            label_Enter_fst.TabIndex = 13;
            label_Enter_fst.Text = "Вход";
            // 
            // FAuthorisation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 346);
            Controls.Add(panel_Auth);
            Controls.Add(panel_Auth_fst);
            Name = "FAuthorisation";
            Text = "Вход";
            Load += FAuthorisation_Load;
            panel_Auth.ResumeLayout(false);
            panel_Auth.PerformLayout();
            panel_Auth_fst.ResumeLayout(false);
            panel_Auth_fst.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_Auth;
        private LinkLabel linkLabel_first;
        private Button button_Submit;
        private Label label_Password;
        private Label label_Name;
        private TextBox textBox_Password;
        private TextBox textBox_Name;
        private Label label_Enter;
        private Panel panel_Auth_fst;
        private Button button_Back;
        private Label label3;
        private TextBox textBox_Password_again_fst;
        private Button button_Submit_fst;
        private Label label1;
        private Label label2;
        private TextBox textBox_Password_fst;
        private TextBox textBox_Name_fst;
        private Label label_Enter_fst;
    }
}