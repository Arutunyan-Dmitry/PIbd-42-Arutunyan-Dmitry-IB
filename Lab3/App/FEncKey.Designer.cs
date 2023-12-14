namespace App
{
    partial class FEncKey
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
            textBox_Key = new TextBox();
            label1 = new Label();
            panel_Drag = new Panel();
            label_Drag = new Label();
            button_Ok = new Button();
            panel_Drag.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Key
            // 
            textBox_Key.Location = new Point(12, 32);
            textBox_Key.Name = "textBox_Key";
            textBox_Key.Size = new Size(289, 27);
            textBox_Key.TabIndex = 0;
            textBox_Key.TextChanged += textBox_Key_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(274, 20);
            label1.TabIndex = 1;
            label1.Text = "Введите пароль для генерации ключа";
            // 
            // panel_Drag
            // 
            panel_Drag.AllowDrop = true;
            panel_Drag.Controls.Add(label_Drag);
            panel_Drag.Location = new Point(12, 65);
            panel_Drag.Name = "panel_Drag";
            panel_Drag.Size = new Size(289, 99);
            panel_Drag.TabIndex = 9;
            panel_Drag.DragDrop += panel_Drag_DragDrop;
            panel_Drag.DragEnter += panel_Drag_DragEnter;
            // 
            // label_Drag
            // 
            label_Drag.AutoSize = true;
            label_Drag.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label_Drag.Location = new Point(19, 37);
            label_Drag.Name = "label_Drag";
            label_Drag.Size = new Size(255, 25);
            label_Drag.TabIndex = 1;
            label_Drag.Text = "Или перетащите файл сюда";
            // 
            // button_Ok
            // 
            button_Ok.Location = new Point(207, 170);
            button_Ok.Name = "button_Ok";
            button_Ok.Size = new Size(94, 29);
            button_Ok.TabIndex = 10;
            button_Ok.Text = "Ok";
            button_Ok.UseVisualStyleBackColor = true;
            button_Ok.Click += button_Ok_Click;
            // 
            // FEncKey
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 213);
            Controls.Add(button_Ok);
            Controls.Add(panel_Drag);
            Controls.Add(label1);
            Controls.Add(textBox_Key);
            Name = "FEncKey";
            Text = "Генерация ключа";
            panel_Drag.ResumeLayout(false);
            panel_Drag.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Key;
        private Label label1;
        private Panel panel_Drag;
        private Label label_Drag;
        private Button button_Ok;
    }
}