namespace Exam
{
    partial class Menu
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
            this.buttonAgents = new System.Windows.Forms.Button();
            this.buttonPerosn = new System.Windows.Forms.Button();
            this.buttonCompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgents
            // 
            this.buttonAgents.Location = new System.Drawing.Point(12, 12);
            this.buttonAgents.Name = "buttonAgents";
            this.buttonAgents.Size = new System.Drawing.Size(153, 43);
            this.buttonAgents.TabIndex = 0;
            this.buttonAgents.Text = "Менеджеры";
            this.buttonAgents.UseVisualStyleBackColor = true;
            this.buttonAgents.Click += new System.EventHandler(this.buttonAgents_Click);
            // 
            // buttonPerosn
            // 
            this.buttonPerosn.Location = new System.Drawing.Point(12, 61);
            this.buttonPerosn.Name = "buttonPerosn";
            this.buttonPerosn.Size = new System.Drawing.Size(153, 43);
            this.buttonPerosn.TabIndex = 1;
            this.buttonPerosn.Text = "Физические лица";
            this.buttonPerosn.UseVisualStyleBackColor = true;
            this.buttonPerosn.Click += new System.EventHandler(this.buttonPerosn_Click);
            // 
            // buttonCompany
            // 
            this.buttonCompany.Location = new System.Drawing.Point(12, 110);
            this.buttonCompany.Name = "buttonCompany";
            this.buttonCompany.Size = new System.Drawing.Size(153, 43);
            this.buttonCompany.TabIndex = 2;
            this.buttonCompany.Text = "Юридические лица";
            this.buttonCompany.UseVisualStyleBackColor = true;
            this.buttonCompany.Click += new System.EventHandler(this.buttonCompany_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(177, 165);
            this.Controls.Add(this.buttonCompany);
            this.Controls.Add(this.buttonPerosn);
            this.Controls.Add(this.buttonAgents);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAgents;
        private System.Windows.Forms.Button buttonPerosn;
        private System.Windows.Forms.Button buttonCompany;
    }
}

