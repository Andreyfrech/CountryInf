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
            this.components = new System.ComponentModel.Container();
            this.textBoxEnterCountry = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFaile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.labelEnterCountry = new System.Windows.Forms.Label();
            this.buttonSerch = new System.Windows.Forms.Button();
            this.countryInfDataSet = new CountryInf.CountryInfDataSet();
            this.countryInfDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listViewCoutryInfo = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCodeCoutry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCapital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPopulation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryInfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryInfDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxEnterCountry
            // 
            this.textBoxEnterCountry.Location = new System.Drawing.Point(12, 91);
            this.textBoxEnterCountry.Name = "textBoxEnterCountry";
            this.textBoxEnterCountry.Size = new System.Drawing.Size(618, 22);
            this.textBoxEnterCountry.TabIndex = 0;
            this.textBoxEnterCountry.TextChanged += new System.EventHandler(this.textBoxEnterCountry_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFaile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 28);
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
            this.ToolStripMenuItemSave.Size = new System.Drawing.Size(207, 26);
            this.ToolStripMenuItemSave.Text = "Сохранить";
            this.ToolStripMenuItemSave.Click += new System.EventHandler(this.ToolStripMenuItemSave_Click);
            // 
            // ToolStripMenuItemLoad
            // 
            this.ToolStripMenuItemLoad.Name = "ToolStripMenuItemLoad";
            this.ToolStripMenuItemLoad.Size = new System.Drawing.Size(207, 26);
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
            this.buttonSerch.Enabled = false;
            this.buttonSerch.Location = new System.Drawing.Point(12, 153);
            this.buttonSerch.Name = "buttonSerch";
            this.buttonSerch.Size = new System.Drawing.Size(618, 27);
            this.buttonSerch.TabIndex = 3;
            this.buttonSerch.Text = "Поиск";
            this.buttonSerch.UseVisualStyleBackColor = true;
            this.buttonSerch.Click += new System.EventHandler(this.buttonSerch_Click);
            // 
            // countryInfDataSet
            // 
            this.countryInfDataSet.DataSetName = "CountryInfDataSet";
            this.countryInfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryInfDataSetBindingSource
            // 
            this.countryInfDataSetBindingSource.DataSource = this.countryInfDataSet;
            this.countryInfDataSetBindingSource.Position = 0;
            // 
            // listViewCoutryInfo
            // 
            this.listViewCoutryInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderCodeCoutry,
            this.columnHeaderCapital,
            this.columnHeaderArea,
            this.columnHeaderPopulation,
            this.columnHeaderRegion});
            this.listViewCoutryInfo.HideSelection = false;
            this.listViewCoutryInfo.Location = new System.Drawing.Point(12, 216);
            this.listViewCoutryInfo.Name = "listViewCoutryInfo";
            this.listViewCoutryInfo.Size = new System.Drawing.Size(891, 194);
            this.listViewCoutryInfo.TabIndex = 4;
            this.listViewCoutryInfo.UseCompatibleStateImageBehavior = false;
            this.listViewCoutryInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Название";
            this.columnHeaderName.Width = 160;
            // 
            // columnHeaderCodeCoutry
            // 
            this.columnHeaderCodeCoutry.Text = "Код страны";
            this.columnHeaderCodeCoutry.Width = 100;
            // 
            // columnHeaderCapital
            // 
            this.columnHeaderCapital.Text = "Столица";
            this.columnHeaderCapital.Width = 150;
            // 
            // columnHeaderArea
            // 
            this.columnHeaderArea.Text = "Площадь";
            this.columnHeaderArea.Width = 100;
            // 
            // columnHeaderPopulation
            // 
            this.columnHeaderPopulation.Text = "Население";
            this.columnHeaderPopulation.Width = 100;
            // 
            // columnHeaderRegion
            // 
            this.columnHeaderRegion.Text = "Регион";
            this.columnHeaderRegion.Width = 140;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.listViewCoutryInfo);
            this.Controls.Add(this.buttonSerch);
            this.Controls.Add(this.labelEnterCountry);
            this.Controls.Add(this.textBoxEnterCountry);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Информация по странам";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryInfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryInfDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource countryInfDataSetBindingSource;
        private CountryInfDataSet countryInfDataSet;
        public System.Windows.Forms.ListView listViewCoutryInfo;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderCodeCoutry;
        private System.Windows.Forms.ColumnHeader columnHeaderCapital;
        private System.Windows.Forms.ColumnHeader columnHeaderArea;
        private System.Windows.Forms.ColumnHeader columnHeaderPopulation;
        private System.Windows.Forms.ColumnHeader columnHeaderRegion;
    }
}

