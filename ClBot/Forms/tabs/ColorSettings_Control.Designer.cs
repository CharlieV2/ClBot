namespace ClBot.Forms.tabs
{
    partial class ColorSettings_Control
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
            this.label3 = new System.Windows.Forms.Label();
            this.sample0_Button = new System.Windows.Forms.Button();
            this.sample1_Button = new System.Windows.Forms.Button();
            this.knownColor_ComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(42, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Цвет";
            // 
            // sample0_Button
            // 
            this.sample0_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.sample0_Button.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.sample0_Button.FlatAppearance.BorderSize = 0;
            this.sample0_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sample0_Button.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.sample0_Button.ForeColor = System.Drawing.Color.White;
            this.sample0_Button.Location = new System.Drawing.Point(46, 115);
            this.sample0_Button.Name = "sample0_Button";
            this.sample0_Button.Size = new System.Drawing.Size(96, 34);
            this.sample0_Button.TabIndex = 32;
            this.sample0_Button.TabStop = false;
            this.sample0_Button.Text = "Пример";
            this.sample0_Button.UseVisualStyleBackColor = false;
            // 
            // sample1_Button
            // 
            this.sample1_Button.BackColor = System.Drawing.Color.White;
            this.sample1_Button.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.sample1_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sample1_Button.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.sample1_Button.ForeColor = System.Drawing.Color.Black;
            this.sample1_Button.Location = new System.Drawing.Point(158, 115);
            this.sample1_Button.Name = "sample1_Button";
            this.sample1_Button.Size = new System.Drawing.Size(96, 34);
            this.sample1_Button.TabIndex = 33;
            this.sample1_Button.TabStop = false;
            this.sample1_Button.Text = "Пример";
            this.sample1_Button.UseVisualStyleBackColor = false;
            // 
            // knownColor_ComboBox
            // 
            this.knownColor_ComboBox.BackColor = System.Drawing.Color.White;
            this.knownColor_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.knownColor_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.knownColor_ComboBox.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.knownColor_ComboBox.FormattingEnabled = true;
            this.knownColor_ComboBox.Location = new System.Drawing.Point(1, 1);
            this.knownColor_ComboBox.Name = "knownColor_ComboBox";
            this.knownColor_ComboBox.Size = new System.Drawing.Size(136, 25);
            this.knownColor_ComboBox.TabIndex = 34;
            this.knownColor_ComboBox.TabStop = false;
            this.knownColor_ComboBox.SelectedIndexChanged += new System.EventHandler(this.knownColor_ComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.knownColor_ComboBox);
            this.panel1.Location = new System.Drawing.Point(91, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 27);
            this.panel1.TabIndex = 35;
            // 
            // ColorSettings_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sample1_Button);
            this.Controls.Add(this.sample0_Button);
            this.Controls.Add(this.label3);
            this.Name = "ColorSettings_Control";
            this.Size = new System.Drawing.Size(566, 238);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sample0_Button;
        private System.Windows.Forms.Button sample1_Button;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox knownColor_ComboBox;
    }
}
