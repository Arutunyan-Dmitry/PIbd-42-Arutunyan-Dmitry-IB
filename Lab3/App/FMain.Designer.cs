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
            panel_Encode = new Panel();
            label3 = new Label();
            label_Key = new Label();
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
            menuStrip1 = new MenuStrip();
            EncodeMenuItem = new ToolStripMenuItem();
            DecodeMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            InfoMenuItem = new ToolStripMenuItem();
            panel_Decode = new Panel();
            textBox_Key = new TextBox();
            label6 = new Label();
            textBox_Format = new TextBox();
            button1 = new Button();
            panel_Drag_D = new Panel();
            label_Drag_D = new Label();
            button_Decode = new Button();
            label4 = new Label();
            button3 = new Button();
            textBox_SavePath_D = new TextBox();
            label5 = new Label();
            button4 = new Button();
            textBox_FilePath_D = new TextBox();
            panel_Info = new Panel();
            groupBox_individual = new GroupBox();
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
            textBox_Des = new TextBox();
            panel_Encode.SuspendLayout();
            panel_Drag.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel_Decode.SuspendLayout();
            panel_Drag_D.SuspendLayout();
            panel_Info.SuspendLayout();
            groupBox_individual.SuspendLayout();
            groupBox_Contacts.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Encode
            // 
            panel_Encode.Controls.Add(label3);
            panel_Encode.Controls.Add(label_Key);
            panel_Encode.Controls.Add(button_Cancel);
            panel_Encode.Controls.Add(panel_Drag);
            panel_Encode.Controls.Add(button_Encode);
            panel_Encode.Controls.Add(label2);
            panel_Encode.Controls.Add(button_Choose_Dir);
            panel_Encode.Controls.Add(textBox_SavePath);
            panel_Encode.Controls.Add(label1);
            panel_Encode.Controls.Add(button_Choose_File);
            panel_Encode.Controls.Add(textBox_FilePath);
            panel_Encode.Location = new Point(10, 31);
            panel_Encode.Name = "panel_Encode";
            panel_Encode.Size = new Size(497, 410);
            panel_Encode.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 327);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 11;
            label3.Text = "Ключ:";
            // 
            // label_Key
            // 
            label_Key.AutoSize = true;
            label_Key.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label_Key.ForeColor = SystemColors.Highlight;
            label_Key.Location = new Point(66, 327);
            label_Key.Name = "label_Key";
            label_Key.Size = new Size(76, 20);
            label_Key.TabIndex = 10;
            label_Key.Text = "Ключ:_Тут";
            label_Key.Click += label_Key_Click;
            // 
            // button_Cancel
            // 
            button_Cancel.Location = new Point(238, 362);
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
            button_Encode.Location = new Point(15, 362);
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { EncodeMenuItem, DecodeMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(529, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // EncodeMenuItem
            // 
            EncodeMenuItem.Name = "EncodeMenuItem";
            EncodeMenuItem.Size = new Size(116, 24);
            EncodeMenuItem.Text = "Шифрование";
            EncodeMenuItem.Click += EncodeMenuItem_Click;
            // 
            // DecodeMenuItem
            // 
            DecodeMenuItem.Name = "DecodeMenuItem";
            DecodeMenuItem.Size = new Size(137, 24);
            DecodeMenuItem.Text = "Расшифрование";
            DecodeMenuItem.Click += DecodeMenuItem_Click;
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
            // panel_Decode
            // 
            panel_Decode.Controls.Add(textBox_Key);
            panel_Decode.Controls.Add(label6);
            panel_Decode.Controls.Add(textBox_Format);
            panel_Decode.Controls.Add(button1);
            panel_Decode.Controls.Add(panel_Drag_D);
            panel_Decode.Controls.Add(button_Decode);
            panel_Decode.Controls.Add(label4);
            panel_Decode.Controls.Add(button3);
            panel_Decode.Controls.Add(textBox_SavePath_D);
            panel_Decode.Controls.Add(label5);
            panel_Decode.Controls.Add(button4);
            panel_Decode.Controls.Add(textBox_FilePath_D);
            panel_Decode.Location = new Point(10, 31);
            panel_Decode.Name = "panel_Decode";
            panel_Decode.Size = new Size(497, 407);
            panel_Decode.TabIndex = 10;
            // 
            // textBox_Key
            // 
            textBox_Key.Location = new Point(70, 320);
            textBox_Key.Name = "textBox_Key";
            textBox_Key.Size = new Size(413, 27);
            textBox_Key.TabIndex = 13;
            textBox_Key.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 327);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 12;
            label6.Text = "Ключ:";
            // 
            // textBox_Format
            // 
            textBox_Format.Location = new Point(401, 285);
            textBox_Format.Name = "textBox_Format";
            textBox_Format.Size = new Size(82, 27);
            textBox_Format.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(238, 362);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 9;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Cancel_Click;
            // 
            // panel_Drag_D
            // 
            panel_Drag_D.AllowDrop = true;
            panel_Drag_D.Controls.Add(label_Drag_D);
            panel_Drag_D.Location = new Point(15, 92);
            panel_Drag_D.Name = "panel_Drag_D";
            panel_Drag_D.Size = new Size(468, 148);
            panel_Drag_D.TabIndex = 8;
            panel_Drag_D.DragDrop += panel_Drag_DragDrop;
            panel_Drag_D.DragEnter += panel_Drag_DragEnter;
            // 
            // label_Drag_D
            // 
            label_Drag_D.AutoSize = true;
            label_Drag_D.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_Drag_D.Location = new Point(101, 55);
            label_Drag_D.Name = "label_Drag_D";
            label_Drag_D.Size = new Size(255, 25);
            label_Drag_D.TabIndex = 1;
            label_Drag_D.Text = "Или перетащите файл сюда";
            // 
            // button_Decode
            // 
            button_Decode.Location = new Point(15, 362);
            button_Decode.Name = "button_Decode";
            button_Decode.Size = new Size(217, 29);
            button_Decode.TabIndex = 7;
            button_Decode.Text = "Расшифровать";
            button_Decode.UseVisualStyleBackColor = true;
            button_Decode.Click += button_Decode_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 253);
            label4.Name = "label4";
            label4.Size = new Size(354, 20);
            label4.TabIndex = 6;
            label4.Text = "Выберите папку и формат для сохранения файла";
            // 
            // button3
            // 
            button3.Location = new Point(289, 285);
            button3.Name = "button3";
            button3.Size = new Size(106, 29);
            button3.TabIndex = 5;
            button3.Text = "Обзор";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Choose_Dir_Click;
            // 
            // textBox_SavePath_D
            // 
            textBox_SavePath_D.BackColor = SystemColors.Window;
            textBox_SavePath_D.Location = new Point(15, 285);
            textBox_SavePath_D.Name = "textBox_SavePath_D";
            textBox_SavePath_D.ReadOnly = true;
            textBox_SavePath_D.Size = new Size(268, 27);
            textBox_SavePath_D.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 13);
            label5.Name = "label5";
            label5.Size = new Size(264, 20);
            label5.TabIndex = 2;
            label5.Text = "Выберите файл для расшифрования";
            // 
            // button4
            // 
            button4.Location = new Point(377, 45);
            button4.Name = "button4";
            button4.Size = new Size(106, 29);
            button4.TabIndex = 1;
            button4.Text = "Обзор";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Choose_File_Click;
            // 
            // textBox_FilePath_D
            // 
            textBox_FilePath_D.BackColor = SystemColors.Window;
            textBox_FilePath_D.Location = new Point(15, 45);
            textBox_FilePath_D.Name = "textBox_FilePath_D";
            textBox_FilePath_D.ReadOnly = true;
            textBox_FilePath_D.Size = new Size(356, 27);
            textBox_FilePath_D.TabIndex = 0;
            // 
            // panel_Info
            // 
            panel_Info.Controls.Add(groupBox_individual);
            panel_Info.Controls.Add(groupBox_Contacts);
            panel_Info.Controls.Add(label_Group);
            panel_Info.Controls.Add(label_Author);
            panel_Info.Controls.Add(label_Author_Hello);
            panel_Info.Location = new Point(10, 31);
            panel_Info.Name = "panel_Info";
            panel_Info.Size = new Size(509, 505);
            panel_Info.TabIndex = 11;
            // 
            // groupBox_individual
            // 
            groupBox_individual.Controls.Add(textBox_Des);
            groupBox_individual.Controls.Add(label_Ogr);
            groupBox_individual.Controls.Add(label_Variant);
            groupBox_individual.Location = new Point(15, 296);
            groupBox_individual.Name = "groupBox_individual";
            groupBox_individual.Size = new Size(491, 199);
            groupBox_individual.TabIndex = 11;
            groupBox_individual.TabStop = false;
            groupBox_individual.Text = "Индивидуальное задание";
            // 
            // label_Ogr
            // 
            label_Ogr.AutoSize = true;
            label_Ogr.Location = new Point(17, 59);
            label_Ogr.Name = "label_Ogr";
            label_Ogr.Size = new Size(303, 20);
            label_Ogr.TabIndex = 1;
            label_Ogr.Text = "Реализация алгоритма DES в режиме OFB\r\n";
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
            // textBox_Des
            // 
            textBox_Des.Location = new Point(8, 87);
            textBox_Des.Multiline = true;
            textBox_Des.Name = "textBox_Des";
            textBox_Des.ReadOnly = true;
            textBox_Des.ScrollBars = ScrollBars.Vertical;
            textBox_Des.Size = new Size(474, 112);
            textBox_Des.TabIndex = 3;
            textBox_Des.Text = resources.GetString("textBox_Des.Text");
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 546);
            Controls.Add(panel_Info);
            Controls.Add(panel_Decode);
            Controls.Add(panel_Encode);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FMain";
            Text = "Приложение";
            Load += FMain_Load;
            panel_Encode.ResumeLayout(false);
            panel_Encode.PerformLayout();
            panel_Drag.ResumeLayout(false);
            panel_Drag.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel_Decode.ResumeLayout(false);
            panel_Decode.PerformLayout();
            panel_Drag_D.ResumeLayout(false);
            panel_Drag_D.PerformLayout();
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

        private Panel panel_Encode;
        private Button button_Cancel;
        private Panel panel_Drag;
        private Label label_Drag;
        private Button button_Encode;
        private Label label2;
        private Button button_Choose_Dir;
        private TextBox textBox_SavePath;
        private Label label1;
        private Button button_Choose_File;
        private TextBox textBox_FilePath;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem EncodeMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem InfoMenuItem;
        private ToolStripMenuItem DecodeMenuItem;
        private Panel panel_Decode;
        private Button button1;
        private Panel panel_Drag_D;
        private Label label_Drag_D;
        private Button button_Decode;
        private Label label4;
        private Button button3;
        private TextBox textBox_SavePath_D;
        private Label label5;
        private Button button4;
        private TextBox textBox_FilePath_D;
        private TextBox textBox_Format;
        private Label label_Key;
        private Label label3;
        private TextBox textBox_Key;
        private Label label6;
        private Panel panel_Info;
        private GroupBox groupBox_individual;
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
        private TextBox textBox_Des;
    }
}