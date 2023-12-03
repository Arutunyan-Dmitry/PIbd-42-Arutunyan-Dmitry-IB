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
            menuStrip1 = new MenuStrip();
            EncodeMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            InfoMenuItem = new ToolStripMenuItem();
            panel_Encode = new Panel();
            button_Cancel = new Button();
            panel_Drag = new Panel();
            label_Drag = new Label();
            button_Encode = new Button();
            label2 = new Label();
            button_Choose_Dir = new Button();
            textBox_SavePath = new TextBox();
            label1 = new Label();
            button_Choose_File = new Button();
            textBox_FilePath = new TextBox();
            panel_Info = new Panel();
            groupBox_individual = new GroupBox();
            label5 = new Label();
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
            menuStrip1.SuspendLayout();
            panel_Encode.SuspendLayout();
            panel_Drag.SuspendLayout();
            panel_Info.SuspendLayout();
            groupBox_individual.SuspendLayout();
            groupBox_Contacts.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { EncodeMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(521, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // EncodeMenuItem
            // 
            EncodeMenuItem.Name = "EncodeMenuItem";
            EncodeMenuItem.Size = new Size(116, 24);
            EncodeMenuItem.Text = "Шифрование";
            EncodeMenuItem.Click += EncodeMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { InfoMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // InfoMenuItem
            // 
            InfoMenuItem.Name = "InfoMenuItem";
            InfoMenuItem.Size = new Size(224, 26);
            InfoMenuItem.Text = "О программе";
            InfoMenuItem.Click += InfoMenuItem_Click;
            // 
            // panel_Encode
            // 
            panel_Encode.Controls.Add(button_Cancel);
            panel_Encode.Controls.Add(panel_Drag);
            panel_Encode.Controls.Add(button_Encode);
            panel_Encode.Controls.Add(label2);
            panel_Encode.Controls.Add(button_Choose_Dir);
            panel_Encode.Controls.Add(textBox_SavePath);
            panel_Encode.Controls.Add(label1);
            panel_Encode.Controls.Add(button_Choose_File);
            panel_Encode.Controls.Add(textBox_FilePath);
            panel_Encode.Location = new Point(12, 40);
            panel_Encode.Name = "panel_Encode";
            panel_Encode.Size = new Size(497, 391);
            panel_Encode.TabIndex = 1;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(307, 336);
            button_Cancel.Name = "button_Cancel";
            button_Cancel.Size = new Size(106, 29);
            button_Cancel.TabIndex = 9;
            button_Cancel.Text = "Отмена";
            button_Cancel.UseVisualStyleBackColor = true;
            button_Cancel.Click += button_Cancel_Click;
            // 
            // panel_Drag
            // 
            panel_Drag.AllowDrop = true;
            panel_Drag.Controls.Add(label_Drag);
            panel_Drag.Location = new Point(15, 92);
            panel_Drag.Name = "panel_Drag";
            panel_Drag.Size = new Size(468, 148);
            panel_Drag.TabIndex = 8;
            panel_Drag.DragDrop += panel_Drag_DragDrop;
            panel_Drag.DragEnter += panel_Drag_DragEnter;
            // 
            // label_Drag
            // 
            label_Drag.AutoSize = true;
            label_Drag.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_Drag.Location = new Point(101, 55);
            label_Drag.Name = "label_Drag";
            label_Drag.Size = new Size(255, 25);
            label_Drag.TabIndex = 1;
            label_Drag.Text = "Или перетащите файл сюда";
            // 
            // button_Encode
            // 
            button_Encode.Location = new Point(66, 336);
            button_Encode.Name = "button_Encode";
            button_Encode.Size = new Size(217, 29);
            button_Encode.TabIndex = 7;
            button_Encode.Text = "Зашифровать";
            button_Encode.UseVisualStyleBackColor = true;
            button_Encode.Click += button_Encode_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 253);
            label2.Name = "label2";
            label2.Size = new Size(410, 20);
            label2.TabIndex = 6;
            label2.Text = "Выберите папку для сохранения зашифрованного файла";
            // 
            // button_Choose_Dir
            // 
            button_Choose_Dir.Location = new Point(377, 285);
            button_Choose_Dir.Name = "button_Choose_Dir";
            button_Choose_Dir.Size = new Size(106, 29);
            button_Choose_Dir.TabIndex = 5;
            button_Choose_Dir.Text = "Обзор";
            button_Choose_Dir.UseVisualStyleBackColor = true;
            button_Choose_Dir.Click += button_Choose_Dir_Click;
            // 
            // textBox_SavePath
            // 
            textBox_SavePath.BackColor = SystemColors.Window;
            textBox_SavePath.Location = new Point(15, 285);
            textBox_SavePath.Name = "textBox_SavePath";
            textBox_SavePath.ReadOnly = true;
            textBox_SavePath.Size = new Size(356, 27);
            textBox_SavePath.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(240, 20);
            label1.TabIndex = 2;
            label1.Text = "Выберите файл для шифрования";
            // 
            // button_Choose_File
            // 
            button_Choose_File.Location = new Point(377, 45);
            button_Choose_File.Name = "button_Choose_File";
            button_Choose_File.Size = new Size(106, 29);
            button_Choose_File.TabIndex = 1;
            button_Choose_File.Text = "Обзор";
            button_Choose_File.UseVisualStyleBackColor = true;
            button_Choose_File.Click += button_Choose_File_Click;
            // 
            // textBox_FilePath
            // 
            textBox_FilePath.BackColor = SystemColors.Window;
            textBox_FilePath.Location = new Point(15, 45);
            textBox_FilePath.Name = "textBox_FilePath";
            textBox_FilePath.ReadOnly = true;
            textBox_FilePath.Size = new Size(356, 27);
            textBox_FilePath.TabIndex = 0;
            // 
            // panel_Info
            // 
            panel_Info.Controls.Add(groupBox_individual);
            panel_Info.Controls.Add(groupBox_Contacts);
            panel_Info.Controls.Add(label_Group);
            panel_Info.Controls.Add(label_Author);
            panel_Info.Controls.Add(label_Author_Hello);
            panel_Info.Location = new Point(0, 40);
            panel_Info.Name = "panel_Info";
            panel_Info.Size = new Size(509, 505);
            panel_Info.TabIndex = 2;
            // 
            // groupBox_individual
            // 
            groupBox_individual.Controls.Add(label5);
            groupBox_individual.Controls.Add(label_Ogr);
            groupBox_individual.Controls.Add(label_Variant);
            groupBox_individual.Location = new Point(15, 296);
            groupBox_individual.Name = "groupBox_individual";
            groupBox_individual.Size = new Size(491, 199);
            groupBox_individual.TabIndex = 11;
            groupBox_individual.TabStop = false;
            groupBox_individual.Text = "Индивидуальное задание";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 89);
            label5.Name = "label5";
            label5.Size = new Size(468, 100);
            label5.TabIndex = 2;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label_Ogr
            // 
            label_Ogr.AutoSize = true;
            label_Ogr.Location = new Point(17, 59);
            label_Ogr.Name = "label_Ogr";
            label_Ogr.Size = new Size(216, 20);
            label_Ogr.TabIndex = 1;
            label_Ogr.Text = "Реализация алгоритма SHA-1\r\n";
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
            groupBox_Contacts.Location = new Point(12, 137);
            groupBox_Contacts.Name = "groupBox_Contacts";
            groupBox_Contacts.Size = new Size(371, 136);
            groupBox_Contacts.TabIndex = 10;
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
            label_Group.Location = new Point(12, 94);
            label_Group.Name = "label_Group";
            label_Group.Size = new Size(132, 20);
            label_Group.TabIndex = 9;
            label_Group.Text = "Группа: ПИбд-42";
            // 
            // label_Author
            // 
            label_Author.AutoSize = true;
            label_Author.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_Author.Location = new Point(12, 54);
            label_Author.Name = "label_Author";
            label_Author.Size = new Size(300, 20);
            label_Author.TabIndex = 8;
            label_Author.Text = "Автор: Арутюнян Дмитрий Аркадьевич";
            // 
            // label_Author_Hello
            // 
            label_Author_Hello.AutoSize = true;
            label_Author_Hello.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_Author_Hello.Location = new Point(12, 3);
            label_Author_Hello.Name = "label_Author_Hello";
            label_Author_Hello.Size = new Size(129, 32);
            label_Author_Hello.TabIndex = 7;
            label_Author_Hello.Text = "Об авторе";
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 546);
            Controls.Add(panel_Info);
            Controls.Add(panel_Encode);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FMain";
            Text = "Приложение";
            Load += FMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel_Encode.ResumeLayout(false);
            panel_Encode.PerformLayout();
            panel_Drag.ResumeLayout(false);
            panel_Drag.PerformLayout();
            panel_Info.ResumeLayout(false);
            panel_Info.PerformLayout();
            groupBox_individual.ResumeLayout(false);
            groupBox_individual.PerformLayout();
            groupBox_Contacts.ResumeLayout(false);
            groupBox_Contacts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem EncodeMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem InfoMenuItem;
        private Panel panel_Encode;
        private Label label1;
        private Button button_Choose_File;
        private TextBox textBox_FilePath;
        private Button button_Choose_Dir;
        private TextBox textBox_SavePath;
        private Button button_Encode;
        private Label label2;
        private Panel panel_Drag;
        private Label label_Drag;
        private Button button_Cancel;
        private Panel panel_Info;
        private GroupBox groupBox_individual;
        private Label label5;
        private Label label_Ogr;
        private Label label_Variant;
        private GroupBox groupBox_Contacts;
        private LinkLabel linkLabel_Mail;
        private LinkLabel linkLabel_TG;
        private LinkLabel linkLabel_VK;
        private Label label_Mail;
        private Label label_TG;
        private Label label_VK;
        private Label label_Group;
        private Label label_Author;
        private Label label_Author_Hello;
    }
}