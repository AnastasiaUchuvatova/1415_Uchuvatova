namespace Lab
{
    partial class updSrIzmer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(updSrIzmer));
            this.name = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.Label();
            this.textType = new System.Windows.Forms.Label();
            this.dateVup = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.textDateVvoda = new System.Windows.Forms.Label();
            this.dateVvoda = new System.Windows.Forms.DateTimePicker();
            this.textDiap = new System.Windows.Forms.Label();
            this.diap = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.textPogreshn = new System.Windows.Forms.Label();
            this.pogreshn = new System.Windows.Forms.TextBox();
            this.textNumberSvidet = new System.Windows.Forms.Label();
            this.organPov = new System.Windows.Forms.TextBox();
            this.datePov = new System.Windows.Forms.DateTimePicker();
            this.numberSv = new System.Windows.Forms.TextBox();
            this.textDataPov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.srok = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrim = new System.Windows.Forms.Label();
            this.prim = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(151, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(183, 24);
            this.name.TabIndex = 2;
            this.name.SelectedIndexChanged += new System.EventHandler(this.name_TextChanged);
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(151, 118);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(183, 22);
            this.type.TabIndex = 54;
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textName.Location = new System.Drawing.Point(16, 42);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(129, 22);
            this.textName.TabIndex = 53;
            this.textName.Text = "Название";
            this.textName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textType
            // 
            this.textType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.textType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textType.Location = new System.Drawing.Point(16, 120);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(129, 22);
            this.textType.TabIndex = 55;
            this.textType.Text = "Тип";
            this.textType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateVup
            // 
            this.dateVup.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVup.Location = new System.Drawing.Point(151, 148);
            this.dateVup.Name = "dateVup";
            this.dateVup.Size = new System.Drawing.Size(183, 22);
            this.dateVup.TabIndex = 56;
            this.dateVup.Value = new System.DateTime(2024, 5, 26, 23, 0, 36, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 57;
            this.label1.Text = "Дата выпуска";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text
            // 
            this.text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(121, 9);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(504, 22);
            this.text.TabIndex = 58;
            this.text.Text = "Для редактирования выберите название средства измерения";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textDateVvoda
            // 
            this.textDateVvoda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDateVvoda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.textDateVvoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDateVvoda.Location = new System.Drawing.Point(16, 170);
            this.textDateVvoda.Name = "textDateVvoda";
            this.textDateVvoda.Size = new System.Drawing.Size(129, 40);
            this.textDateVvoda.TabIndex = 60;
            this.textDateVvoda.Text = "Дата ввода в эксплуатацию";
            this.textDateVvoda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateVvoda
            // 
            this.dateVvoda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateVvoda.Location = new System.Drawing.Point(151, 177);
            this.dateVvoda.Name = "dateVvoda";
            this.dateVvoda.Size = new System.Drawing.Size(183, 22);
            this.dateVvoda.TabIndex = 59;
            this.dateVvoda.Value = new System.DateTime(2024, 5, 26, 23, 0, 44, 0);
            // 
            // textDiap
            // 
            this.textDiap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDiap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.textDiap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDiap.Location = new System.Drawing.Point(16, 210);
            this.textDiap.Name = "textDiap";
            this.textDiap.Size = new System.Drawing.Size(129, 38);
            this.textDiap.TabIndex = 62;
            this.textDiap.Text = "Диапазон  измерений";
            this.textDiap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diap
            // 
            this.diap.Location = new System.Drawing.Point(151, 218);
            this.diap.Name = "diap";
            this.diap.Size = new System.Drawing.Size(183, 22);
            this.diap.TabIndex = 61;
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.LightGreen;
            this.update.Location = new System.Drawing.Point(151, 292);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(341, 32);
            this.update.TabIndex = 63;
            this.update.Text = "Обновить";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // textPogreshn
            // 
            this.textPogreshn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPogreshn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.textPogreshn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPogreshn.Location = new System.Drawing.Point(12, 246);
            this.textPogreshn.Name = "textPogreshn";
            this.textPogreshn.Size = new System.Drawing.Size(129, 22);
            this.textPogreshn.TabIndex = 65;
            this.textPogreshn.Text = "Погрешность";
            this.textPogreshn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pogreshn
            // 
            this.pogreshn.Location = new System.Drawing.Point(151, 246);
            this.pogreshn.Name = "pogreshn";
            this.pogreshn.Size = new System.Drawing.Size(183, 22);
            this.pogreshn.TabIndex = 64;
            // 
            // textNumberSvidet
            // 
            this.textNumberSvidet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textNumberSvidet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.textNumberSvidet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNumberSvidet.Location = new System.Drawing.Point(364, 64);
            this.textNumberSvidet.Name = "textNumberSvidet";
            this.textNumberSvidet.Size = new System.Drawing.Size(129, 58);
            this.textNumberSvidet.TabIndex = 73;
            this.textNumberSvidet.Text = "Номер свидетельства о поверке";
            this.textNumberSvidet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // organPov
            // 
            this.organPov.Location = new System.Drawing.Point(499, 202);
            this.organPov.Name = "organPov";
            this.organPov.Size = new System.Drawing.Size(183, 22);
            this.organPov.TabIndex = 72;
            // 
            // datePov
            // 
            this.datePov.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePov.Location = new System.Drawing.Point(499, 127);
            this.datePov.Name = "datePov";
            this.datePov.Size = new System.Drawing.Size(183, 22);
            this.datePov.TabIndex = 70;
            this.datePov.Value = new System.DateTime(2024, 5, 26, 23, 0, 50, 0);
            // 
            // numberSv
            // 
            this.numberSv.Location = new System.Drawing.Point(499, 82);
            this.numberSv.Name = "numberSv";
            this.numberSv.Size = new System.Drawing.Size(183, 22);
            this.numberSv.TabIndex = 66;
            // 
            // textDataPov
            // 
            this.textDataPov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDataPov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.textDataPov.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textDataPov.Location = new System.Drawing.Point(353, 127);
            this.textDataPov.Name = "textDataPov";
            this.textDataPov.Size = new System.Drawing.Size(140, 22);
            this.textDataPov.TabIndex = 74;
            this.textDataPov.Text = "Дата поверки";
            this.textDataPov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(353, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 35);
            this.label2.TabIndex = 75;
            this.label2.Text = "Срок действия поверки";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srok
            // 
            this.srok.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.srok.Location = new System.Drawing.Point(499, 166);
            this.srok.Name = "srok";
            this.srok.Size = new System.Drawing.Size(183, 22);
            this.srok.TabIndex = 76;
            this.srok.Value = new System.DateTime(2024, 5, 26, 23, 0, 55, 0);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(353, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 49);
            this.label3.TabIndex = 77;
            this.label3.Text = "Организация, осуществляющая поверку";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textPrim
            // 
            this.textPrim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPrim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.textPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrim.Location = new System.Drawing.Point(353, 243);
            this.textPrim.Name = "textPrim";
            this.textPrim.Size = new System.Drawing.Size(140, 22);
            this.textPrim.TabIndex = 79;
            this.textPrim.Text = "Примечание";
            this.textPrim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prim
            // 
            this.prim.Location = new System.Drawing.Point(499, 245);
            this.prim.Name = "prim";
            this.prim.Size = new System.Drawing.Size(183, 22);
            this.prim.TabIndex = 78;
            // 
            // textNumber
            // 
            this.textNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.textNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNumber.Location = new System.Drawing.Point(16, 70);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(129, 34);
            this.textNumber.TabIndex = 81;
            this.textNumber.Text = "Заводской номер";
            this.textNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(151, 76);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(183, 22);
            this.number.TabIndex = 80;
            // 
            // updSrIzmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::Lab.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(703, 336);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.number);
            this.Controls.Add(this.textPrim);
            this.Controls.Add(this.prim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.srok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDataPov);
            this.Controls.Add(this.textNumberSvidet);
            this.Controls.Add(this.organPov);
            this.Controls.Add(this.datePov);
            this.Controls.Add(this.numberSv);
            this.Controls.Add(this.textPogreshn);
            this.Controls.Add(this.pogreshn);
            this.Controls.Add(this.update);
            this.Controls.Add(this.textDiap);
            this.Controls.Add(this.diap);
            this.Controls.Add(this.textDateVvoda);
            this.Controls.Add(this.dateVvoda);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateVup);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.type);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "updSrIzmer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение информации о средстве измерения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.Label textType;
        private System.Windows.Forms.DateTimePicker dateVup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Label textDateVvoda;
        private System.Windows.Forms.DateTimePicker dateVvoda;
        private System.Windows.Forms.Label textDiap;
        private System.Windows.Forms.TextBox diap;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label textPogreshn;
        private System.Windows.Forms.TextBox pogreshn;
        private System.Windows.Forms.Label textNumberSvidet;
        private System.Windows.Forms.TextBox organPov;
        private System.Windows.Forms.DateTimePicker datePov;
        private System.Windows.Forms.TextBox numberSv;
        private System.Windows.Forms.Label textDataPov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker srok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textPrim;
        private System.Windows.Forms.TextBox prim;
        private System.Windows.Forms.Label textNumber;
        private System.Windows.Forms.TextBox number;
    }
}