namespace ClBot.Forms.tabs
{
    partial class FormatSettings_Control
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.help1_Label = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.patternOutput_TextBox = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.date_TextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.help2_Label = new System.Windows.Forms.Label();
            this.help_Button = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_Button)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Формат вывода";
            // 
            // help1_Label
            // 
            this.help1_Label.AutoSize = true;
            this.help1_Label.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.help1_Label.ForeColor = System.Drawing.Color.Gray;
            this.help1_Label.Location = new System.Drawing.Point(157, 105);
            this.help1_Label.Name = "help1_Label";
            this.help1_Label.Size = new System.Drawing.Size(104, 90);
            this.help1_Label.TabIndex = 33;
            this.help1_Label.Text = "0 - номер пары\r\n1 - подгруппа\r\n2 - предмет\r\n3 - тип пары\r\n4 - преподаватель\r\n5 - " +
    "аудитория";
            this.help1_Label.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel7.Controls.Add(this.patternOutput_TextBox);
            this.panel7.Location = new System.Drawing.Point(29, 103);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(122, 94);
            this.panel7.TabIndex = 32;
            // 
            // patternOutput_TextBox
            // 
            this.patternOutput_TextBox.BackColor = System.Drawing.Color.White;
            this.patternOutput_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patternOutput_TextBox.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.patternOutput_TextBox.Location = new System.Drawing.Point(1, 1);
            this.patternOutput_TextBox.Name = "patternOutput_TextBox";
            this.patternOutput_TextBox.Size = new System.Drawing.Size(120, 92);
            this.patternOutput_TextBox.TabIndex = 22;
            this.patternOutput_TextBox.TabStop = false;
            this.patternOutput_TextBox.Text = "";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.Location = new System.Drawing.Point(141, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 1);
            this.panel6.TabIndex = 29;
            // 
            // date_TextBox
            // 
            this.date_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date_TextBox.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.date_TextBox.Location = new System.Drawing.Point(141, 35);
            this.date_TextBox.Name = "date_TextBox";
            this.date_TextBox.Size = new System.Drawing.Size(100, 20);
            this.date_TextBox.TabIndex = 31;
            this.date_TextBox.TabStop = false;
            this.date_TextBox.Text = "Text";
            this.date_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(25, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 21);
            this.label10.TabIndex = 30;
            this.label10.Text = "Расписание на";
            // 
            // help2_Label
            // 
            this.help2_Label.AutoSize = true;
            this.help2_Label.Font = new System.Drawing.Font("Segoe UI Light", 9F);
            this.help2_Label.ForeColor = System.Drawing.Color.Gray;
            this.help2_Label.Location = new System.Drawing.Point(27, 208);
            this.help2_Label.Name = "help2_Label";
            this.help2_Label.Size = new System.Drawing.Size(246, 30);
            this.help2_Label.TabIndex = 36;
            this.help2_Label.Text = "Цифры заключать в { ... }.\r\nНе использовать следующие символы:   %   =";
            this.help2_Label.Visible = false;
            // 
            // help_Button
            // 
            this.help_Button.Image = global::ClBot.Properties.Resources.help;
            this.help_Button.Location = new System.Drawing.Point(160, 138);
            this.help_Button.Name = "help_Button";
            this.help_Button.Size = new System.Drawing.Size(25, 25);
            this.help_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.help_Button.TabIndex = 37;
            this.help_Button.TabStop = false;
            this.help_Button.Click += new System.EventHandler(this.help_Button_Click);
            // 
            // FormatSettings_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.help_Button);
            this.Controls.Add(this.help2_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.help1_Label);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.date_TextBox);
            this.Controls.Add(this.label10);
            this.Name = "FormatSettings_Control";
            this.Size = new System.Drawing.Size(566, 238);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.help_Button)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label help1_Label;
        public System.Windows.Forms.RichTextBox patternOutput_TextBox;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox date_TextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label help2_Label;
        private System.Windows.Forms.PictureBox help_Button;
        public System.Windows.Forms.Panel panel7;
    }
}
