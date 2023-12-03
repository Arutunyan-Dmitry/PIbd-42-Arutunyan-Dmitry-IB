namespace App
{
    partial class FUser
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
            label_Text = new Label();
            textBox_Name = new TextBox();
            label_Name = new Label();
            checkBox_isDisabled = new CheckBox();
            numericUpDown_Length = new NumericUpDown();
            numericUpDown_Lifetime = new NumericUpDown();
            label_Length = new Label();
            label_Lifetime = new Label();
            groupBox_Pswd_Spec = new GroupBox();
            checkBox_isAryphm = new CheckBox();
            checkBox_isSymb = new CheckBox();
            checkBox_isLetters = new CheckBox();
            button_Submit = new Button();
            button_Back = new Button();
            checkBox_Update = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Length).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Lifetime).BeginInit();
            groupBox_Pswd_Spec.SuspendLayout();
            SuspendLayout();
            // 
            // label_Text
            // 
            label_Text.AutoSize = true;
            label_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Text.Location = new Point(12, 9);
            label_Text.Name = "label_Text";
            label_Text.Size = new Size(84, 28);
            label_Text.TabIndex = 0;
            label_Text.Text = "Создать";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(12, 83);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(281, 27);
            textBox_Name.TabIndex = 1;
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(12, 60);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(139, 20);
            label_Name.TabIndex = 2;
            label_Name.Text = "Имя пользователя";
            // 
            // checkBox_isDisabled
            // 
            checkBox_isDisabled.AutoSize = true;
            checkBox_isDisabled.Location = new Point(12, 219);
            checkBox_isDisabled.Name = "checkBox_isDisabled";
            checkBox_isDisabled.Size = new Size(237, 24);
            checkBox_isDisabled.TabIndex = 3;
            checkBox_isDisabled.Text = "Заблокировать пользователя";
            checkBox_isDisabled.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_Length
            // 
            numericUpDown_Length.Location = new Point(235, 128);
            numericUpDown_Length.Maximum = new decimal(new int[] { -1981284352, -1966660860, 0, 0 });
            numericUpDown_Length.Name = "numericUpDown_Length";
            numericUpDown_Length.Size = new Size(58, 27);
            numericUpDown_Length.TabIndex = 5;
            // 
            // numericUpDown_Lifetime
            // 
            numericUpDown_Lifetime.Location = new Point(235, 175);
            numericUpDown_Lifetime.Maximum = new decimal(new int[] { -1981284352, -1966660860, 0, 0 });
            numericUpDown_Lifetime.Name = "numericUpDown_Lifetime";
            numericUpDown_Lifetime.Size = new Size(58, 27);
            numericUpDown_Lifetime.TabIndex = 6;
            // 
            // label_Length
            // 
            label_Length.AutoSize = true;
            label_Length.Location = new Point(12, 130);
            label_Length.Name = "label_Length";
            label_Length.Size = new Size(210, 20);
            label_Length.TabIndex = 7;
            label_Length.Text = "Минимальная длина пароля";
            // 
            // label_Lifetime
            // 
            label_Lifetime.AutoSize = true;
            label_Lifetime.Location = new Point(12, 177);
            label_Lifetime.Name = "label_Lifetime";
            label_Lifetime.Size = new Size(208, 20);
            label_Lifetime.TabIndex = 8;
            label_Lifetime.Text = "Срок действия пароля (мес.)";
            // 
            // groupBox_Pswd_Spec
            // 
            groupBox_Pswd_Spec.Controls.Add(checkBox_isAryphm);
            groupBox_Pswd_Spec.Controls.Add(checkBox_isSymb);
            groupBox_Pswd_Spec.Controls.Add(checkBox_isLetters);
            groupBox_Pswd_Spec.Location = new Point(320, 60);
            groupBox_Pswd_Spec.Name = "groupBox_Pswd_Spec";
            groupBox_Pswd_Spec.Size = new Size(361, 142);
            groupBox_Pswd_Spec.TabIndex = 9;
            groupBox_Pswd_Spec.TabStop = false;
            groupBox_Pswd_Spec.Text = "Ограничения пароля";
            // 
            // checkBox_isAryphm
            // 
            checkBox_isAryphm.AutoSize = true;
            checkBox_isAryphm.Location = new Point(18, 101);
            checkBox_isAryphm.Name = "checkBox_isAryphm";
            checkBox_isAryphm.Size = new Size(338, 24);
            checkBox_isAryphm.TabIndex = 2;
            checkBox_isAryphm.Text = "Наличие знаков арифметических операций";
            checkBox_isAryphm.UseVisualStyleBackColor = true;
            // 
            // checkBox_isSymb
            // 
            checkBox_isSymb.AutoSize = true;
            checkBox_isSymb.Location = new Point(18, 71);
            checkBox_isSymb.Name = "checkBox_isSymb";
            checkBox_isSymb.Size = new Size(235, 24);
            checkBox_isSymb.TabIndex = 1;
            checkBox_isSymb.Text = "Наличие знаков препинания";
            checkBox_isSymb.UseVisualStyleBackColor = true;
            // 
            // checkBox_isLetters
            // 
            checkBox_isLetters.AutoSize = true;
            checkBox_isLetters.Location = new Point(18, 36);
            checkBox_isLetters.Name = "checkBox_isLetters";
            checkBox_isLetters.Size = new Size(127, 24);
            checkBox_isLetters.TabIndex = 0;
            checkBox_isLetters.Text = "Наличие букв";
            checkBox_isLetters.UseVisualStyleBackColor = true;
            // 
            // button_Submit
            // 
            button_Submit.Location = new Point(582, 267);
            button_Submit.Name = "button_Submit";
            button_Submit.Size = new Size(94, 29);
            button_Submit.TabIndex = 10;
            button_Submit.Text = "Сохранить";
            button_Submit.UseVisualStyleBackColor = true;
            button_Submit.Click += button_Submit_Click;
            // 
            // button_Back
            // 
            button_Back.Location = new Point(479, 267);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(94, 29);
            button_Back.TabIndex = 11;
            button_Back.Text = "Отмена";
            button_Back.UseVisualStyleBackColor = true;
            button_Back.Click += button_Back_Click;
            // 
            // checkBox_Update
            // 
            checkBox_Update.AutoSize = true;
            checkBox_Update.Location = new Point(338, 219);
            checkBox_Update.Name = "checkBox_Update";
            checkBox_Update.Size = new Size(320, 24);
            checkBox_Update.TabIndex = 12;
            checkBox_Update.Text = "Сбросить счётчик срока действия пароля";
            checkBox_Update.UseVisualStyleBackColor = true;
            // 
            // FUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 308);
            Controls.Add(checkBox_Update);
            Controls.Add(button_Back);
            Controls.Add(button_Submit);
            Controls.Add(groupBox_Pswd_Spec);
            Controls.Add(label_Lifetime);
            Controls.Add(label_Length);
            Controls.Add(numericUpDown_Lifetime);
            Controls.Add(numericUpDown_Length);
            Controls.Add(checkBox_isDisabled);
            Controls.Add(label_Name);
            Controls.Add(textBox_Name);
            Controls.Add(label_Text);
            Name = "FUser";
            Text = "Пользователь";
            Load += FUser_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Length).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Lifetime).EndInit();
            groupBox_Pswd_Spec.ResumeLayout(false);
            groupBox_Pswd_Spec.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Text;
        private TextBox textBox_Name;
        private Label label_Name;
        private CheckBox checkBox_isDisabled;
        private NumericUpDown numericUpDown_Length;
        private NumericUpDown numericUpDown_Lifetime;
        private Label label_Length;
        private Label label_Lifetime;
        private GroupBox groupBox_Pswd_Spec;
        private CheckBox checkBox_isAryphm;
        private CheckBox checkBox_isSymb;
        private CheckBox checkBox_isLetters;
        private Button button_Submit;
        private Button button_Back;
        private CheckBox checkBox_Update;
    }
}