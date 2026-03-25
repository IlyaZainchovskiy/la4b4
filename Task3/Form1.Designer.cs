namespace Task3
{
    partial class Form1
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
            this.clbSettings = new System.Windows.Forms.CheckedListBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clbSettings
            // 
            this.clbSettings.FormattingEnabled = true;
            this.clbSettings.Items.AddRange(new object[] {
            "Дозволити виконання JavaScript",
            "Блокувати спливаючі вікна",
            "Приймати файли Cookies",
            "Увімкнути темну тему",
            "Показувати панель закладок",
            "Надсилати запит Do Not Track",
            "Очищувати кеш при закритті",
            "Використовувати апаратне прискорення",
            "Синхронізувати паролі",
            "Увімкнути захист від фішингу"});
            this.clbSettings.Location = new System.Drawing.Point(16, 25);
            this.clbSettings.Name = "clbSettings";
            this.clbSettings.Size = new System.Drawing.Size(362, 211);
            this.clbSettings.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(453, 58);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(137, 52);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Застосувати";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(408, 159);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(350, 279);
            this.txtSummary.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.clbSettings);
            this.Name = "Form1";
            this.Text = "Параметри браузера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbSettings;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtSummary;
    }
}

