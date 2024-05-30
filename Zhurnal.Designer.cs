namespace Lab
{
    partial class Zhurnal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zhurnal));
            this.date = new System.Windows.Forms.DateTimePicker();
            this.extDate = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.harakt = new System.Windows.Forms.ComboBox();
            this.objec = new System.Windows.Forms.ComboBox();
            this.Obj = new System.Windows.Forms.Label();
            this.textHarakt = new System.Windows.Forms.Label();
            this.primech = new System.Windows.Forms.Label();
            this.prim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(147, 106);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(183, 22);
            this.date.TabIndex = 4;
            // 
            // extDate
            // 
            this.extDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.extDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.extDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.extDate.Location = new System.Drawing.Point(12, 106);
            this.extDate.Name = "extDate";
            this.extDate.Size = new System.Drawing.Size(129, 39);
            this.extDate.TabIndex = 6;
            this.extDate.Text = "Дата исследования";
            this.extDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LightGreen;
            this.save.Location = new System.Drawing.Point(12, 245);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(347, 37);
            this.save.TabIndex = 8;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // harakt
            // 
            this.harakt.ForeColor = System.Drawing.Color.Black;
            this.harakt.FormattingEnabled = true;
            this.harakt.Location = new System.Drawing.Point(147, 72);
            this.harakt.Name = "harakt";
            this.harakt.Size = new System.Drawing.Size(183, 24);
            this.harakt.TabIndex = 10;
            this.harakt.Text = "Характеристика";
            this.harakt.Enter += new System.EventHandler(this.harakt_Enter);
            // 
            // objec
            // 
            this.objec.ForeColor = System.Drawing.Color.Black;
            this.objec.FormattingEnabled = true;
            this.objec.Location = new System.Drawing.Point(147, 33);
            this.objec.Name = "objec";
            this.objec.Size = new System.Drawing.Size(183, 24);
            this.objec.TabIndex = 9;
            this.objec.Text = "Объект исследования";
            this.objec.Enter += new System.EventHandler(this.NeedForIssled_Enter);
            // 
            // Obj
            // 
            this.Obj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Obj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.Obj.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Obj.Location = new System.Drawing.Point(12, 27);
            this.Obj.Name = "Obj";
            this.Obj.Size = new System.Drawing.Size(129, 35);
            this.Obj.TabIndex = 12;
            this.Obj.Text = "Объект\r\nисследования";
            this.Obj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textHarakt
            // 
            this.textHarakt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textHarakt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.textHarakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textHarakt.Location = new System.Drawing.Point(12, 72);
            this.textHarakt.Name = "textHarakt";
            this.textHarakt.Size = new System.Drawing.Size(129, 35);
            this.textHarakt.TabIndex = 13;
            this.textHarakt.Text = "Исследуемая\r\nхарактеристика";
            this.textHarakt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // primech
            // 
            this.primech.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.primech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.primech.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.primech.Location = new System.Drawing.Point(12, 145);
            this.primech.Name = "primech";
            this.primech.Size = new System.Drawing.Size(129, 22);
            this.primech.TabIndex = 14;
            this.primech.Text = "Примечание";
            this.primech.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prim
            // 
            this.prim.Location = new System.Drawing.Point(147, 141);
            this.prim.Name = "prim";
            this.prim.Size = new System.Drawing.Size(183, 22);
            this.prim.TabIndex = 15;
            // 
            // Zhurnal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::Lab.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(371, 294);
            this.Controls.Add(this.prim);
            this.Controls.Add(this.primech);
            this.Controls.Add(this.textHarakt);
            this.Controls.Add(this.Obj);
            this.Controls.Add(this.harakt);
            this.Controls.Add(this.objec);
            this.Controls.Add(this.save);
            this.Controls.Add(this.extDate);
            this.Controls.Add(this.date);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zhurnal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая запись в журнале";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label extDate;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox harakt;
        private System.Windows.Forms.ComboBox objec;
        private System.Windows.Forms.Label Obj;
        private System.Windows.Forms.Label textHarakt;
        private System.Windows.Forms.Label primech;
        private System.Windows.Forms.TextBox prim;
    }
}