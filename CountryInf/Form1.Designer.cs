namespace CountryInf
{
    partial class FormMain
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
            this.textBoxEnterCountry = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFaile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEnterCountry = new System.Windows.Forms.Label();
            this.buttonSerch = new System.Windows.Forms.Button();
            this.listBoxCountryInf = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxEnterCountry
            // 
            this.textBoxEnterCountry.Location = new System.Drawing.Point(12, 91);
            this.textBoxEnterCountry.Name = "textBoxEnterCountry";
            this.textBoxEnterCountry.Size = new System.Drawing.Size(441, 22);
            this.textBoxEnterCountry.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFaile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(468, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFaile
            // 
            this.ToolStripMenuItemFaile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSave,
            this.ToolStripMenuItemLoad});
            this.ToolStripMenuItemFaile.Name = "ToolStripMenuItemFaile";
            this.ToolStripMenuItemFaile.Size = new System.Drawing.Size(59, 24);
            this.ToolStripMenuItemFaile.Text = "Файл";
            // 
            // ToolStripMenuItemSave
            // 
            this.ToolStripMenuItemSave.Name = "ToolStripMenuItemSave";
            this.ToolStripMenuItemSave.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemSave.Text = "Сохранить";
            // 
            // ToolStripMenuItemLoad
            // 
            this.ToolStripMenuItemLoad.Name = "ToolStripMenuItemLoad";
            this.ToolStripMenuItemLoad.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItemLoad.Text = "Выгрузить из БД";
            // 
            // labelEnterCountry
            // 
            this.labelEnterCountry.AutoSize = true;
            this.labelEnterCountry.Location = new System.Drawing.Point(15, 60);
            this.labelEnterCountry.Name = "labelEnterCountry";
            this.labelEnterCountry.Size = new System.Drawing.Size(112, 17);
            this.labelEnterCountry.TabIndex = 2;
            this.labelEnterCountry.Text = "Введите страну";
            // 
            // buttonSerch
            // 
            this.buttonSerch.Location = new System.Drawing.Point(12, 153);
            this.buttonSerch.Name = "buttonSerch";
            this.buttonSerch.Size = new System.Drawing.Size(441, 27);
            this.buttonSerch.TabIndex = 3;
            this.buttonSerch.Text = "Поиск";
            this.buttonSerch.UseVisualStyleBackColor = true;
          
            // 
            // listBoxCountryInf
            // 
            this.listBoxCountryInf.FormattingEnabled = true;
            this.listBoxCountryInf.ItemHeight = 16;
            this.listBoxCountryInf.Location = new System.Drawing.Point(12, 234);
            this.listBoxCountryInf.Name = "listBoxCountryInf";
            this.listBoxCountryInf.Size = new System.Drawing.Size(441, 116);
            this.listBoxCountryInf.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.listBoxCountryInf);
            this.Controls.Add(this.buttonSerch);
            this.Controls.Add(this.labelEnterCountry);
            this.Controls.Add(this.textBoxEnterCountry);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Информация по странам";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEnterCountry;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFaile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLoad;
        private System.Windows.Forms.Label labelEnterCountry;
        private System.Windows.Forms.Button buttonSerch;
        private System.Windows.Forms.ListBox listBoxCountryInf;
    }
}

