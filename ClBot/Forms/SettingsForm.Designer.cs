namespace ClBot.Forms
{
    partial class SettingsForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HelpLink = new System.Windows.Forms.Label();
            this.MstuLink = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.saveSettings_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl_Panel = new System.Windows.Forms.Panel();
            this.mstu_Button = new System.Windows.Forms.Button();
            this.vk_Button = new System.Windows.Forms.Button();
            this.format_Button = new System.Windows.Forms.Button();
            this.theme_Button = new System.Windows.Forms.Button();
            this.back_Button = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(367, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Помощь";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(388, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "МГТУ";
            // 
            // HelpLink
            // 
            this.HelpLink.AutoSize = true;
            this.HelpLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpLink.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpLink.ForeColor = System.Drawing.Color.RoyalBlue;
            this.HelpLink.Location = new System.Drawing.Point(443, 332);
            this.HelpLink.Name = "HelpLink";
            this.HelpLink.Size = new System.Drawing.Size(126, 21);
            this.HelpLink.TabIndex = 16;
            this.HelpLink.Text = "vk.com/danyanet";
            this.HelpLink.Click += new System.EventHandler(this.Link_Click);
            // 
            // MstuLink
            // 
            this.MstuLink.AutoSize = true;
            this.MstuLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MstuLink.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MstuLink.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MstuLink.Location = new System.Drawing.Point(443, 308);
            this.MstuLink.Name = "MstuLink";
            this.MstuLink.Size = new System.Drawing.Size(127, 21);
            this.MstuLink.TabIndex = 15;
            this.MstuLink.Text = "www.mstu.edu.ru";
            this.MstuLink.Click += new System.EventHandler(this.Link_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(3, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 1);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Агрегатор расписания для\r\nстудентов МГТУ любого направления.\r\n";
            // 
            // saveSettings_Button
            // 
            this.saveSettings_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.saveSettings_Button.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.saveSettings_Button.FlatAppearance.BorderSize = 0;
            this.saveSettings_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSettings_Button.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.saveSettings_Button.ForeColor = System.Drawing.Color.White;
            this.saveSettings_Button.Location = new System.Drawing.Point(469, 256);
            this.saveSettings_Button.Name = "saveSettings_Button";
            this.saveSettings_Button.Size = new System.Drawing.Size(96, 34);
            this.saveSettings_Button.TabIndex = 20;
            this.saveSettings_Button.TabStop = false;
            this.saveSettings_Button.Text = "Сохранить";
            this.saveSettings_Button.UseVisualStyleBackColor = false;
            this.saveSettings_Button.Click += new System.EventHandler(this.saveSettings_Button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(3, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 1);
            this.panel2.TabIndex = 15;
            // 
            // tabControl_Panel
            // 
            this.tabControl_Panel.Location = new System.Drawing.Point(3, 56);
            this.tabControl_Panel.Name = "tabControl_Panel";
            this.tabControl_Panel.Size = new System.Drawing.Size(566, 238);
            this.tabControl_Panel.TabIndex = 21;
            // 
            // mstu_Button
            // 
            this.mstu_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.mstu_Button.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.mstu_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mstu_Button.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.mstu_Button.ForeColor = System.Drawing.Color.White;
            this.mstu_Button.Location = new System.Drawing.Point(12, 22);
            this.mstu_Button.Name = "mstu_Button";
            this.mstu_Button.Size = new System.Drawing.Size(82, 35);
            this.mstu_Button.TabIndex = 22;
            this.mstu_Button.TabStop = false;
            this.mstu_Button.Tag = "0";
            this.mstu_Button.Text = "МГТУ";
            this.mstu_Button.UseVisualStyleBackColor = false;
            this.mstu_Button.Click += new System.EventHandler(this.Transform);
            // 
            // vk_Button
            // 
            this.vk_Button.BackColor = System.Drawing.Color.White;
            this.vk_Button.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.vk_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vk_Button.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.vk_Button.ForeColor = System.Drawing.Color.Black;
            this.vk_Button.Location = new System.Drawing.Point(91, 24);
            this.vk_Button.Name = "vk_Button";
            this.vk_Button.Size = new System.Drawing.Size(78, 33);
            this.vk_Button.TabIndex = 23;
            this.vk_Button.TabStop = false;
            this.vk_Button.Tag = "1";
            this.vk_Button.Text = "ВК";
            this.vk_Button.UseVisualStyleBackColor = false;
            this.vk_Button.Click += new System.EventHandler(this.Transform);
            // 
            // format_Button
            // 
            this.format_Button.BackColor = System.Drawing.Color.White;
            this.format_Button.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.format_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.format_Button.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.format_Button.ForeColor = System.Drawing.Color.Black;
            this.format_Button.Location = new System.Drawing.Point(168, 24);
            this.format_Button.Name = "format_Button";
            this.format_Button.Size = new System.Drawing.Size(78, 33);
            this.format_Button.TabIndex = 24;
            this.format_Button.TabStop = false;
            this.format_Button.Tag = "2";
            this.format_Button.Text = "Формат";
            this.format_Button.UseVisualStyleBackColor = false;
            this.format_Button.Click += new System.EventHandler(this.Transform);
            // 
            // theme_Button
            // 
            this.theme_Button.BackColor = System.Drawing.Color.White;
            this.theme_Button.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.theme_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theme_Button.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.theme_Button.ForeColor = System.Drawing.Color.Black;
            this.theme_Button.Location = new System.Drawing.Point(245, 24);
            this.theme_Button.Name = "theme_Button";
            this.theme_Button.Size = new System.Drawing.Size(78, 33);
            this.theme_Button.TabIndex = 25;
            this.theme_Button.TabStop = false;
            this.theme_Button.Tag = "3";
            this.theme_Button.Text = "Тема";
            this.theme_Button.UseVisualStyleBackColor = false;
            this.theme_Button.Click += new System.EventHandler(this.Transform);
            // 
            // back_Button
            // 
            this.back_Button.Image = global::ClBot.Properties.Resources.Back_Default;
            this.back_Button.Location = new System.Drawing.Point(534, 7);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(31, 34);
            this.back_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_Button.TabIndex = 19;
            this.back_Button.TabStop = false;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            this.back_Button.MouseEnter += new System.EventHandler(this.back_Button_Enter);
            this.back_Button.MouseLeave += new System.EventHandler(this.back_Button_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClBot.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.theme_Button);
            this.Controls.Add(this.format_Button);
            this.Controls.Add(this.mstu_Button);
            this.Controls.Add(this.vk_Button);
            this.Controls.Add(this.saveSettings_Button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.back_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HelpLink);
            this.Controls.Add(this.MstuLink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl_Panel);
            this.Name = "SettingsForm";
            this.Size = new System.Drawing.Size(572, 363);
            this.VisibleChanged += new System.EventHandler(this.Update);
            ((System.ComponentModel.ISupportInitialize)(this.back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label HelpLink;
        private System.Windows.Forms.Label MstuLink;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox back_Button;
        private System.Windows.Forms.Button saveSettings_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel tabControl_Panel;
        private System.Windows.Forms.Button mstu_Button;
        private System.Windows.Forms.Button vk_Button;
        private System.Windows.Forms.Button format_Button;
        private System.Windows.Forms.Button theme_Button;
    }
}
