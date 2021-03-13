namespace ClBot.Forms.tabs
{
    partial class VKSettings_Control
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupID_TextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.token_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(135, 66);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 1);
            this.panel5.TabIndex = 23;
            // 
            // groupID_TextBox
            // 
            this.groupID_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.groupID_TextBox.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.groupID_TextBox.Location = new System.Drawing.Point(135, 46);
            this.groupID_TextBox.Name = "groupID_TextBox";
            this.groupID_TextBox.Size = new System.Drawing.Size(100, 20);
            this.groupID_TextBox.TabIndex = 27;
            this.groupID_TextBox.TabStop = false;
            this.groupID_TextBox.Text = "Text";
            this.groupID_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(135, 103);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 1);
            this.panel4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(22, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "ID группы";
            // 
            // token_TextBox
            // 
            this.token_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.token_TextBox.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.token_TextBox.Location = new System.Drawing.Point(135, 83);
            this.token_TextBox.Name = "token_TextBox";
            this.token_TextBox.Size = new System.Drawing.Size(148, 20);
            this.token_TextBox.TabIndex = 26;
            this.token_TextBox.TabStop = false;
            this.token_TextBox.Text = "Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(22, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ключ доступа";
            // 
            // VKSettings_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.groupID_TextBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.token_TextBox);
            this.Controls.Add(this.label4);
            this.Name = "VKSettings_Control";
            this.Size = new System.Drawing.Size(566, 238);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox groupID_TextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox token_TextBox;
        private System.Windows.Forms.Label label4;
    }
}
