namespace Task1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMelodies = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lbSelectedMelodies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оберіть пісні";
            // 
            // cbMelodies
            // 
            this.cbMelodies.FormattingEnabled = true;
            this.cbMelodies.Items.AddRange(new object[] {
            "Бумбокс — Вахтерам",
            "Бумбокс — Наодинці",
            "ТІК — Альона",
            "ТІК — Олені",
            "Океан Ельзи — Обійми",
            "Океан Ельзи — Без бою",
            "Скрябін — Старі фотографії",
            "Скрябін — Мовчати",
            "Бумбокс — Та4то",
            "Океан Ельзи — Я так хочу до тебе"});
            this.cbMelodies.Location = new System.Drawing.Point(160, 126);
            this.cbMelodies.Name = "cbMelodies";
            this.cbMelodies.Size = new System.Drawing.Size(205, 28);
            this.cbMelodies.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(160, 193);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 48);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Location = new System.Drawing.Point(483, 93);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(117, 20);
            this.lblListTitle.TabIndex = 3;
            this.lblListTitle.Text = "Улюблені пісні";
            // 
            // lbSelectedMelodies
            // 
            this.lbSelectedMelodies.FormattingEnabled = true;
            this.lbSelectedMelodies.ItemHeight = 20;
            this.lbSelectedMelodies.Location = new System.Drawing.Point(487, 138);
            this.lbSelectedMelodies.Name = "lbSelectedMelodies";
            this.lbSelectedMelodies.Size = new System.Drawing.Size(221, 164);
            this.lbSelectedMelodies.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSelectedMelodies);
            this.Controls.Add(this.lblListTitle);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbMelodies);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMelodies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.ListBox lbSelectedMelodies;
    }
}

