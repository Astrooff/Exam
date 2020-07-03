namespace Exam
{
    partial class Company
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
            this.labelIdAgent = new System.Windows.Forms.Label();
            this.comboBoxAgent = new System.Windows.Forms.ComboBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSur = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.textBoxKPP = new System.Windows.Forms.TextBox();
            this.textBoxShortName = new System.Windows.Forms.TextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewCompany = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelIdAgent
            // 
            this.labelIdAgent.AutoSize = true;
            this.labelIdAgent.Location = new System.Drawing.Point(13, 169);
            this.labelIdAgent.Name = "labelIdAgent";
            this.labelIdAgent.Size = new System.Drawing.Size(60, 13);
            this.labelIdAgent.TabIndex = 66;
            this.labelIdAgent.Text = "Менеджер";
            // 
            // comboBoxAgent
            // 
            this.comboBoxAgent.FormattingEnabled = true;
            this.comboBoxAgent.Location = new System.Drawing.Point(14, 185);
            this.comboBoxAgent.Name = "comboBoxAgent";
            this.comboBoxAgent.Size = new System.Drawing.Size(100, 21);
            this.comboBoxAgent.TabIndex = 65;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(520, 270);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 62;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(13, 52);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(38, 13);
            this.labelAdress.TabIndex = 58;
            this.labelAdress.Text = "Адрес";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(11, 91);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(31, 13);
            this.labelLastName.TabIndex = 59;
            this.labelLastName.Text = "ИНН";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 130);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(30, 13);
            this.labelName.TabIndex = 60;
            this.labelName.Text = "КПП";
            // 
            // labelSur
            // 
            this.labelSur.AutoSize = true;
            this.labelSur.Location = new System.Drawing.Point(11, 12);
            this.labelSur.Name = "labelSur";
            this.labelSur.Size = new System.Drawing.Size(126, 13);
            this.labelSur.TabIndex = 61;
            this.labelSur.Text = "Кроткое наименование";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(12, 68);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdress.TabIndex = 57;
            // 
            // textBoxINN
            // 
            this.textBoxINN.Location = new System.Drawing.Point(14, 107);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(100, 20);
            this.textBoxINN.TabIndex = 56;
            this.textBoxINN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxINN_KeyPress);
            // 
            // textBoxKPP
            // 
            this.textBoxKPP.Location = new System.Drawing.Point(14, 146);
            this.textBoxKPP.Name = "textBoxKPP";
            this.textBoxKPP.Size = new System.Drawing.Size(100, 20);
            this.textBoxKPP.TabIndex = 55;
            this.textBoxKPP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxKPP_KeyPress);
            // 
            // textBoxShortName
            // 
            this.textBoxShortName.Location = new System.Drawing.Point(14, 29);
            this.textBoxShortName.Name = "textBoxShortName";
            this.textBoxShortName.Size = new System.Drawing.Size(100, 20);
            this.textBoxShortName.TabIndex = 54;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(601, 270);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 53;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(439, 270);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 52;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listViewCompany
            // 
            this.listViewCompany.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.listViewCompany.FullRowSelect = true;
            this.listViewCompany.GridLines = true;
            this.listViewCompany.HideSelection = false;
            this.listViewCompany.Location = new System.Drawing.Point(143, 12);
            this.listViewCompany.MultiSelect = false;
            this.listViewCompany.Name = "listViewCompany";
            this.listViewCompany.Size = new System.Drawing.Size(556, 252);
            this.listViewCompany.TabIndex = 51;
            this.listViewCompany.UseCompatibleStateImageBehavior = false;
            this.listViewCompany.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "№";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Краткое наименование ";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Адрес";
            this.columnHeader3.Width = 68;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ИНН";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "КПП";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Менеджер";
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 304);
            this.Controls.Add(this.labelIdAgent);
            this.Controls.Add(this.comboBoxAgent);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSur);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxINN);
            this.Controls.Add(this.textBoxKPP);
            this.Controls.Add(this.textBoxShortName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewCompany);
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdAgent;
        private System.Windows.Forms.ComboBox comboBoxAgent;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSur;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.TextBox textBoxKPP;
        private System.Windows.Forms.TextBox textBoxShortName;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewCompany;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}