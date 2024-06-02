namespace Lab
{
    partial class Lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab));
            this.mainForm = new System.Windows.Forms.TabControl();
            this.Create = new System.Windows.Forms.TabPage();
            this.newPrekursor = new System.Windows.Forms.Button();
            this.newReaktiv = new System.Windows.Forms.Button();
            this.newPostavka = new System.Windows.Forms.Button();
            this.newGSO = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.TabPage();
            this.updSrIzmer = new System.Windows.Forms.Button();
            this.PlanZakaza = new System.Windows.Forms.TabPage();
            this.dgPlanZakaza = new System.Windows.Forms.DataGridView();
            this.PlanPoverok = new System.Windows.Forms.TabPage();
            this.dgPlanPoverok = new System.Windows.Forms.DataGridView();
            this.tabGurnal = new System.Windows.Forms.TabPage();
            this.otchetIssledovaniya = new System.Windows.Forms.Button();
            this.NewIssled = new System.Windows.Forms.Button();
            this.dgGurnal = new System.Windows.Forms.DataGridView();
            this.ProsrochChim = new System.Windows.Forms.TabPage();
            this.dgProsrChim = new System.Windows.Forms.DataGridView();
            this.NeedPoverka = new System.Windows.Forms.TabPage();
            this.dgPover = new System.Windows.Forms.DataGridView();
            this.Ocenka = new System.Windows.Forms.TabPage();
            this.dgZaGod = new System.Windows.Forms.DataGridView();
            this.NeedForIssled = new System.Windows.Forms.TabPage();
            this.ShowForIssled = new System.Windows.Forms.Button();
            this.harakt = new System.Windows.Forms.ComboBox();
            this.objec = new System.Windows.Forms.ComboBox();
            this.textForIsled = new System.Windows.Forms.Label();
            this.dgForIssled = new System.Windows.Forms.DataGridView();
            this.otchetHimikat = new System.Windows.Forms.Button();
            this.mainForm.SuspendLayout();
            this.Create.SuspendLayout();
            this.update.SuspendLayout();
            this.PlanZakaza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanZakaza)).BeginInit();
            this.PlanPoverok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanPoverok)).BeginInit();
            this.tabGurnal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGurnal)).BeginInit();
            this.ProsrochChim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProsrChim)).BeginInit();
            this.NeedPoverka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPover)).BeginInit();
            this.Ocenka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgZaGod)).BeginInit();
            this.NeedForIssled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgForIssled)).BeginInit();
            this.SuspendLayout();
            // 
            // mainForm
            // 
            this.mainForm.Controls.Add(this.Create);
            this.mainForm.Controls.Add(this.update);
            this.mainForm.Controls.Add(this.PlanZakaza);
            this.mainForm.Controls.Add(this.PlanPoverok);
            this.mainForm.Controls.Add(this.tabGurnal);
            this.mainForm.Controls.Add(this.ProsrochChim);
            this.mainForm.Controls.Add(this.NeedPoverka);
            this.mainForm.Controls.Add(this.Ocenka);
            this.mainForm.Controls.Add(this.NeedForIssled);
            this.mainForm.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainForm.Location = new System.Drawing.Point(13, 13);
            this.mainForm.Multiline = true;
            this.mainForm.Name = "mainForm";
            this.mainForm.SelectedIndex = 0;
            this.mainForm.Size = new System.Drawing.Size(797, 425);
            this.mainForm.TabIndex = 1;
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Create.BackgroundImage")));
            this.Create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Create.Controls.Add(this.newPrekursor);
            this.Create.Controls.Add(this.newReaktiv);
            this.Create.Controls.Add(this.newPostavka);
            this.Create.Controls.Add(this.newGSO);
            this.Create.Location = new System.Drawing.Point(4, 46);
            this.Create.Name = "Create";
            this.Create.Padding = new System.Windows.Forms.Padding(3);
            this.Create.Size = new System.Drawing.Size(789, 375);
            this.Create.TabIndex = 1;
            this.Create.Text = "Добавление";
            // 
            // newPrekursor
            // 
            this.newPrekursor.BackColor = System.Drawing.Color.LightGreen;
            this.newPrekursor.Location = new System.Drawing.Point(259, 170);
            this.newPrekursor.Name = "newPrekursor";
            this.newPrekursor.Size = new System.Drawing.Size(206, 67);
            this.newPrekursor.TabIndex = 3;
            this.newPrekursor.Text = "Добавить прекурсор";
            this.newPrekursor.UseVisualStyleBackColor = false;
            this.newPrekursor.Click += new System.EventHandler(this.newPrekursor_Click);
            // 
            // newReaktiv
            // 
            this.newReaktiv.BackColor = System.Drawing.Color.LightGreen;
            this.newReaktiv.Location = new System.Drawing.Point(259, 97);
            this.newReaktiv.Name = "newReaktiv";
            this.newReaktiv.Size = new System.Drawing.Size(206, 67);
            this.newReaktiv.TabIndex = 2;
            this.newReaktiv.Text = "Добавить химический реактив\r\n";
            this.newReaktiv.UseVisualStyleBackColor = false;
            this.newReaktiv.Click += new System.EventHandler(this.newReaktiv_Click);
            // 
            // newPostavka
            // 
            this.newPostavka.BackColor = System.Drawing.Color.LightGreen;
            this.newPostavka.Location = new System.Drawing.Point(53, 24);
            this.newPostavka.Name = "newPostavka";
            this.newPostavka.Size = new System.Drawing.Size(168, 67);
            this.newPostavka.TabIndex = 1;
            this.newPostavka.Text = "Новая поставка";
            this.newPostavka.UseVisualStyleBackColor = false;
            this.newPostavka.Click += new System.EventHandler(this.newPostavka_Click);
            // 
            // newGSO
            // 
            this.newGSO.BackColor = System.Drawing.Color.LightGreen;
            this.newGSO.Location = new System.Drawing.Point(259, 24);
            this.newGSO.Name = "newGSO";
            this.newGSO.Size = new System.Drawing.Size(206, 67);
            this.newGSO.TabIndex = 0;
            this.newGSO.Text = "Добавить ГСО";
            this.newGSO.UseVisualStyleBackColor = false;
            this.newGSO.Click += new System.EventHandler(this.newGSO_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(188)))), ((int)(((byte)(138)))));
            this.update.BackgroundImage = global::Lab.Properties.Resources.фон;
            this.update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.update.Controls.Add(this.updSrIzmer);
            this.update.Location = new System.Drawing.Point(4, 46);
            this.update.Name = "update";
            this.update.Padding = new System.Windows.Forms.Padding(3);
            this.update.Size = new System.Drawing.Size(789, 375);
            this.update.TabIndex = 9;
            this.update.Text = "Обновление";
            // 
            // updSrIzmer
            // 
            this.updSrIzmer.BackColor = System.Drawing.Color.LightGreen;
            this.updSrIzmer.Location = new System.Drawing.Point(46, 37);
            this.updSrIzmer.Name = "updSrIzmer";
            this.updSrIzmer.Size = new System.Drawing.Size(206, 67);
            this.updSrIzmer.TabIndex = 11;
            this.updSrIzmer.Text = "Обновить средство измерения";
            this.updSrIzmer.UseVisualStyleBackColor = false;
            this.updSrIzmer.Click += new System.EventHandler(this.updSrIzmer_Click);
            // 
            // PlanZakaza
            // 
            this.PlanZakaza.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PlanZakaza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlanZakaza.BackgroundImage")));
            this.PlanZakaza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlanZakaza.Controls.Add(this.dgPlanZakaza);
            this.PlanZakaza.Location = new System.Drawing.Point(4, 46);
            this.PlanZakaza.Name = "PlanZakaza";
            this.PlanZakaza.Padding = new System.Windows.Forms.Padding(3);
            this.PlanZakaza.Size = new System.Drawing.Size(789, 375);
            this.PlanZakaza.TabIndex = 5;
            this.PlanZakaza.Text = "Планирование заказов";
            // 
            // dgPlanZakaza
            // 
            this.dgPlanZakaza.AllowUserToAddRows = false;
            this.dgPlanZakaza.AllowUserToDeleteRows = false;
            this.dgPlanZakaza.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgPlanZakaza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanZakaza.Location = new System.Drawing.Point(4, 9);
            this.dgPlanZakaza.Name = "dgPlanZakaza";
            this.dgPlanZakaza.ReadOnly = true;
            this.dgPlanZakaza.RowHeadersWidth = 51;
            this.dgPlanZakaza.RowTemplate.Height = 24;
            this.dgPlanZakaza.Size = new System.Drawing.Size(759, 356);
            this.dgPlanZakaza.TabIndex = 1;
            // 
            // PlanPoverok
            // 
            this.PlanPoverok.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PlanPoverok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlanPoverok.BackgroundImage")));
            this.PlanPoverok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlanPoverok.Controls.Add(this.dgPlanPoverok);
            this.PlanPoverok.Location = new System.Drawing.Point(4, 46);
            this.PlanPoverok.Name = "PlanPoverok";
            this.PlanPoverok.Padding = new System.Windows.Forms.Padding(3);
            this.PlanPoverok.Size = new System.Drawing.Size(789, 375);
            this.PlanPoverok.TabIndex = 6;
            this.PlanPoverok.Text = "Планирование поверок";
            // 
            // dgPlanPoverok
            // 
            this.dgPlanPoverok.AllowUserToAddRows = false;
            this.dgPlanPoverok.AllowUserToDeleteRows = false;
            this.dgPlanPoverok.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgPlanPoverok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlanPoverok.Location = new System.Drawing.Point(4, 9);
            this.dgPlanPoverok.Name = "dgPlanPoverok";
            this.dgPlanPoverok.ReadOnly = true;
            this.dgPlanPoverok.RowHeadersWidth = 51;
            this.dgPlanPoverok.RowTemplate.Height = 24;
            this.dgPlanPoverok.Size = new System.Drawing.Size(759, 356);
            this.dgPlanPoverok.TabIndex = 1;
            // 
            // tabGurnal
            // 
            this.tabGurnal.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabGurnal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabGurnal.BackgroundImage")));
            this.tabGurnal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabGurnal.Controls.Add(this.otchetIssledovaniya);
            this.tabGurnal.Controls.Add(this.NewIssled);
            this.tabGurnal.Controls.Add(this.dgGurnal);
            this.tabGurnal.Location = new System.Drawing.Point(4, 46);
            this.tabGurnal.Name = "tabGurnal";
            this.tabGurnal.Padding = new System.Windows.Forms.Padding(3);
            this.tabGurnal.Size = new System.Drawing.Size(789, 375);
            this.tabGurnal.TabIndex = 8;
            this.tabGurnal.Text = "Журнал";
            // 
            // otchetIssledovaniya
            // 
            this.otchetIssledovaniya.BackColor = System.Drawing.Color.LightGreen;
            this.otchetIssledovaniya.Location = new System.Drawing.Point(388, 331);
            this.otchetIssledovaniya.Name = "otchetIssledovaniya";
            this.otchetIssledovaniya.Size = new System.Drawing.Size(395, 45);
            this.otchetIssledovaniya.TabIndex = 6;
            this.otchetIssledovaniya.Text = "Сформировать отчет об исследованиях за год";
            this.otchetIssledovaniya.UseVisualStyleBackColor = false;
            // 
            // NewIssled
            // 
            this.NewIssled.BackColor = System.Drawing.Color.LightGreen;
            this.NewIssled.Location = new System.Drawing.Point(4, 331);
            this.NewIssled.Name = "NewIssled";
            this.NewIssled.Size = new System.Drawing.Size(387, 48);
            this.NewIssled.TabIndex = 5;
            this.NewIssled.Text = "Новая запись";
            this.NewIssled.UseVisualStyleBackColor = false;
            // 
            // dgGurnal
            // 
            this.dgGurnal.AllowUserToAddRows = false;
            this.dgGurnal.AllowUserToDeleteRows = false;
            this.dgGurnal.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgGurnal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGurnal.GridColor = System.Drawing.Color.DarkSeaGreen;
            this.dgGurnal.Location = new System.Drawing.Point(4, 9);
            this.dgGurnal.Name = "dgGurnal";
            this.dgGurnal.ReadOnly = true;
            this.dgGurnal.RowHeadersWidth = 51;
            this.dgGurnal.RowTemplate.Height = 24;
            this.dgGurnal.Size = new System.Drawing.Size(779, 324);
            this.dgGurnal.TabIndex = 2;
            // 
            // ProsrochChim
            // 
            this.ProsrochChim.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ProsrochChim.Controls.Add(this.dgProsrChim);
            this.ProsrochChim.Location = new System.Drawing.Point(4, 46);
            this.ProsrochChim.Name = "ProsrochChim";
            this.ProsrochChim.Padding = new System.Windows.Forms.Padding(3);
            this.ProsrochChim.Size = new System.Drawing.Size(789, 375);
            this.ProsrochChim.TabIndex = 2;
            this.ProsrochChim.Text = "Просроченные химикаты";
            // 
            // dgProsrChim
            // 
            this.dgProsrChim.AllowUserToAddRows = false;
            this.dgProsrChim.AllowUserToDeleteRows = false;
            this.dgProsrChim.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgProsrChim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProsrChim.Location = new System.Drawing.Point(4, 9);
            this.dgProsrChim.Name = "dgProsrChim";
            this.dgProsrChim.ReadOnly = true;
            this.dgProsrChim.RowHeadersWidth = 51;
            this.dgProsrChim.RowTemplate.Height = 24;
            this.dgProsrChim.Size = new System.Drawing.Size(759, 356);
            this.dgProsrChim.TabIndex = 1;
            // 
            // NeedPoverka
            // 
            this.NeedPoverka.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.NeedPoverka.Controls.Add(this.dgPover);
            this.NeedPoverka.Location = new System.Drawing.Point(4, 46);
            this.NeedPoverka.Name = "NeedPoverka";
            this.NeedPoverka.Padding = new System.Windows.Forms.Padding(3);
            this.NeedPoverka.Size = new System.Drawing.Size(789, 375);
            this.NeedPoverka.TabIndex = 3;
            this.NeedPoverka.Text = "Необходимо поверить";
            // 
            // dgPover
            // 
            this.dgPover.AllowUserToAddRows = false;
            this.dgPover.AllowUserToDeleteRows = false;
            this.dgPover.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgPover.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPover.Location = new System.Drawing.Point(4, 9);
            this.dgPover.Name = "dgPover";
            this.dgPover.ReadOnly = true;
            this.dgPover.RowHeadersWidth = 51;
            this.dgPover.RowTemplate.Height = 24;
            this.dgPover.Size = new System.Drawing.Size(759, 356);
            this.dgPover.TabIndex = 1;
            // 
            // Ocenka
            // 
            this.Ocenka.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Ocenka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ocenka.BackgroundImage")));
            this.Ocenka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ocenka.Controls.Add(this.otchetHimikat);
            this.Ocenka.Controls.Add(this.dgZaGod);
            this.Ocenka.Location = new System.Drawing.Point(4, 46);
            this.Ocenka.Name = "Ocenka";
            this.Ocenka.Padding = new System.Windows.Forms.Padding(3);
            this.Ocenka.Size = new System.Drawing.Size(789, 375);
            this.Ocenka.TabIndex = 7;
            this.Ocenka.Text = "Оценивание расходов за год";
            // 
            // dgZaGod
            // 
            this.dgZaGod.AllowUserToAddRows = false;
            this.dgZaGod.AllowUserToDeleteRows = false;
            this.dgZaGod.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgZaGod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZaGod.Location = new System.Drawing.Point(4, 9);
            this.dgZaGod.Name = "dgZaGod";
            this.dgZaGod.ReadOnly = true;
            this.dgZaGod.RowHeadersWidth = 51;
            this.dgZaGod.RowTemplate.Height = 24;
            this.dgZaGod.Size = new System.Drawing.Size(785, 330);
            this.dgZaGod.TabIndex = 1;
            // 
            // NeedForIssled
            // 
            this.NeedForIssled.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.NeedForIssled.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NeedForIssled.BackgroundImage")));
            this.NeedForIssled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NeedForIssled.Controls.Add(this.ShowForIssled);
            this.NeedForIssled.Controls.Add(this.harakt);
            this.NeedForIssled.Controls.Add(this.objec);
            this.NeedForIssled.Controls.Add(this.textForIsled);
            this.NeedForIssled.Controls.Add(this.dgForIssled);
            this.NeedForIssled.Location = new System.Drawing.Point(4, 46);
            this.NeedForIssled.Name = "NeedForIssled";
            this.NeedForIssled.Padding = new System.Windows.Forms.Padding(3);
            this.NeedForIssled.Size = new System.Drawing.Size(789, 375);
            this.NeedForIssled.TabIndex = 4;
            this.NeedForIssled.Text = "Для исследования";
            // 
            // ShowForIssled
            // 
            this.ShowForIssled.BackColor = System.Drawing.Color.LightGreen;
            this.ShowForIssled.Location = new System.Drawing.Point(10, 125);
            this.ShowForIssled.Name = "ShowForIssled";
            this.ShowForIssled.Size = new System.Drawing.Size(186, 35);
            this.ShowForIssled.TabIndex = 5;
            this.ShowForIssled.Text = "Показать";
            this.ShowForIssled.UseVisualStyleBackColor = false;
            this.ShowForIssled.Click += new System.EventHandler(this.ShowForIssled_Click);
            // 
            // harakt
            // 
            this.harakt.ForeColor = System.Drawing.Color.Black;
            this.harakt.FormattingEnabled = true;
            this.harakt.Location = new System.Drawing.Point(10, 77);
            this.harakt.Name = "harakt";
            this.harakt.Size = new System.Drawing.Size(183, 24);
            this.harakt.TabIndex = 4;
            this.harakt.Text = "Характеристика";
            this.harakt.Enter += new System.EventHandler(this.harakt_Enter);
            // 
            // objec
            // 
            this.objec.ForeColor = System.Drawing.Color.Black;
            this.objec.FormattingEnabled = true;
            this.objec.Location = new System.Drawing.Point(10, 47);
            this.objec.Name = "objec";
            this.objec.Size = new System.Drawing.Size(183, 24);
            this.objec.TabIndex = 3;
            this.objec.Text = "Объект исследования";
            this.objec.Enter += new System.EventHandler(this.NeedForIssled_Enter);
            // 
            // textForIsled
            // 
            this.textForIsled.AutoSize = true;
            this.textForIsled.Location = new System.Drawing.Point(7, 13);
            this.textForIsled.Name = "textForIsled";
            this.textForIsled.Size = new System.Drawing.Size(169, 16);
            this.textForIsled.TabIndex = 2;
            this.textForIsled.Text = "Выберите исследование";
            // 
            // dgForIssled
            // 
            this.dgForIssled.AllowUserToAddRows = false;
            this.dgForIssled.AllowUserToDeleteRows = false;
            this.dgForIssled.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgForIssled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgForIssled.Location = new System.Drawing.Point(214, 13);
            this.dgForIssled.Name = "dgForIssled";
            this.dgForIssled.ReadOnly = true;
            this.dgForIssled.RowHeadersWidth = 51;
            this.dgForIssled.RowTemplate.Height = 24;
            this.dgForIssled.Size = new System.Drawing.Size(547, 356);
            this.dgForIssled.TabIndex = 1;
            // 
            // otchetHimikat
            // 
            this.otchetHimikat.BackColor = System.Drawing.Color.LightGreen;
            this.otchetHimikat.Location = new System.Drawing.Point(3, 334);
            this.otchetHimikat.Name = "otchetHimikat";
            this.otchetHimikat.Size = new System.Drawing.Size(786, 38);
            this.otchetHimikat.TabIndex = 5;
            this.otchetHimikat.Text = "Сформировать отчет об использовании химикатов за год";
            this.otchetHimikat.UseVisualStyleBackColor = false;
            // 
            // Lab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.mainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab";
            this.mainForm.ResumeLayout(false);
            this.Create.ResumeLayout(false);
            this.update.ResumeLayout(false);
            this.PlanZakaza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanZakaza)).EndInit();
            this.PlanPoverok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlanPoverok)).EndInit();
            this.tabGurnal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGurnal)).EndInit();
            this.ProsrochChim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProsrChim)).EndInit();
            this.NeedPoverka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPover)).EndInit();
            this.Ocenka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgZaGod)).EndInit();
            this.NeedForIssled.ResumeLayout(false);
            this.NeedForIssled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgForIssled)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainForm;
        private System.Windows.Forms.TabPage Create;
        private System.Windows.Forms.Button newPrekursor;
        private System.Windows.Forms.Button newReaktiv;
        private System.Windows.Forms.Button newPostavka;
        private System.Windows.Forms.Button newGSO;
        private System.Windows.Forms.TabPage ProsrochChim;
        private System.Windows.Forms.TabPage NeedPoverka;
        private System.Windows.Forms.TabPage NeedForIssled;
        private System.Windows.Forms.TabPage PlanZakaza;
        private System.Windows.Forms.TabPage PlanPoverok;
        private System.Windows.Forms.TabPage Ocenka;
        private System.Windows.Forms.DataGridView dgProsrChim;
        private System.Windows.Forms.DataGridView dgPover;
        private System.Windows.Forms.DataGridView dgForIssled;
        private System.Windows.Forms.DataGridView dgPlanZakaza;
        private System.Windows.Forms.DataGridView dgPlanPoverok;
        private System.Windows.Forms.DataGridView dgZaGod;
        private System.Windows.Forms.Label textForIsled;
        private System.Windows.Forms.Button ShowForIssled;
        private System.Windows.Forms.ComboBox harakt;
        private System.Windows.Forms.ComboBox objec;
        private System.Windows.Forms.TabPage tabGurnal;
        private System.Windows.Forms.DataGridView dgGurnal;
        private System.Windows.Forms.TabPage update;
        private System.Windows.Forms.Button updSrIzmer;
        private System.Windows.Forms.Button NewIssled;
        private System.Windows.Forms.Button otchetIssledovaniya;
        private System.Windows.Forms.Button otchetHimikat;
    }
}

