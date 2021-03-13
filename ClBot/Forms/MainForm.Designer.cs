namespace ClBot
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.members_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.message_RichText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.send_Button = new System.Windows.Forms.Button();
            this.parse_Button = new System.Windows.Forms.Button();
            this.settings_Button = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings_Button)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // members_Panel
            // 
            this.members_Panel.AutoScroll = true;
            this.members_Panel.BackColor = System.Drawing.Color.White;
            this.members_Panel.Location = new System.Drawing.Point(1, 1);
            this.members_Panel.Margin = new System.Windows.Forms.Padding(1);
            this.members_Panel.Name = "members_Panel";
            this.members_Panel.Size = new System.Drawing.Size(189, 271);
            this.members_Panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Участники";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.message_RichText);
            this.panel1.Location = new System.Drawing.Point(224, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 272);
            this.panel1.TabIndex = 2;
            // 
            // message_RichText
            // 
            this.message_RichText.BackColor = System.Drawing.Color.White;
            this.message_RichText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message_RichText.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.message_RichText.Location = new System.Drawing.Point(1, 1);
            this.message_RichText.Name = "message_RichText";
            this.message_RichText.Size = new System.Drawing.Size(334, 270);
            this.message_RichText.TabIndex = 0;
            this.message_RichText.TabStop = false;
            this.message_RichText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(220, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сообщение";
            // 
            // send_Button
            // 
            this.send_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.send_Button.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.send_Button.FlatAppearance.BorderSize = 0;
            this.send_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_Button.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.send_Button.ForeColor = System.Drawing.Color.White;
            this.send_Button.Location = new System.Drawing.Point(464, 322);
            this.send_Button.Name = "send_Button";
            this.send_Button.Size = new System.Drawing.Size(96, 34);
            this.send_Button.TabIndex = 4;
            this.send_Button.TabStop = false;
            this.send_Button.Text = "Отправить";
            this.send_Button.UseVisualStyleBackColor = false;
            this.send_Button.Click += new System.EventHandler(this.send_Button_Click);
            // 
            // parse_Button
            // 
            this.parse_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.parse_Button.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.parse_Button.FlatAppearance.BorderSize = 0;
            this.parse_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parse_Button.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.parse_Button.ForeColor = System.Drawing.Color.White;
            this.parse_Button.Location = new System.Drawing.Point(362, 322);
            this.parse_Button.Name = "parse_Button";
            this.parse_Button.Size = new System.Drawing.Size(96, 34);
            this.parse_Button.TabIndex = 5;
            this.parse_Button.TabStop = false;
            this.parse_Button.Text = "Собрать";
            this.parse_Button.UseVisualStyleBackColor = false;
            this.parse_Button.Click += new System.EventHandler(this.parse_Button_Click);
            // 
            // settings_Button
            // 
            this.settings_Button.Image = global::ClBot.Properties.Resources.Settings_Default;
            this.settings_Button.Location = new System.Drawing.Point(12, 322);
            this.settings_Button.Name = "settings_Button";
            this.settings_Button.Size = new System.Drawing.Size(31, 34);
            this.settings_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settings_Button.TabIndex = 6;
            this.settings_Button.TabStop = false;
            this.settings_Button.Click += new System.EventHandler(this.settings_Button_Click);
            this.settings_Button.MouseEnter += new System.EventHandler(this.settings_Button_Enter);
            this.settings_Button.MouseLeave += new System.EventHandler(this.settings_Button_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.members_Panel);
            this.panel2.Location = new System.Drawing.Point(12, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 273);
            this.panel2.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 363);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.settings_Button);
            this.Controls.Add(this.parse_Button);
            this.Controls.Add(this.send_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClBot";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settings_Button)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox message_RichText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button send_Button;
        private System.Windows.Forms.Button parse_Button;
        private System.Windows.Forms.PictureBox settings_Button;
        private System.Windows.Forms.FlowLayoutPanel members_Panel;
        private System.Windows.Forms.Panel panel2;
    }
}

