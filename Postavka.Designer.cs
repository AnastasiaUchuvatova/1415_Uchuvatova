namespace Lab
{
    partial class Postavka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postavka));
            this.Chimikat = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.ComboBox();
            this.Ostatok = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.DataProizvodstva = new System.Windows.Forms.Label();
            this.srok = new System.Windows.Forms.TextBox();
            this.SroGodnosty = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chimikat
            // 
            this.Chimikat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Chimikat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.Chimikat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chimikat.Location = new System.Drawing.Point(7, 14);
            this.Chimikat.Name = "Chimikat";
            this.Chimikat.Size = new System.Drawing.Size(134, 57);
            this.Chimikat.TabIndex = 0;
            this.Chimikat.Text = "Химикат";
            this.Chimikat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.FormattingEnabled = true;
            this.name.Location = new System.Drawing.Point(147, 28);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 24);
            this.name.TabIndex = 1;
            // 
            // Ostatok
            // 
            this.Ostatok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ostatok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.Ostatok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ostatok.Location = new System.Drawing.Point(7, 71);
            this.Ostatok.Name = "Ostatok";
            this.Ostatok.Size = new System.Drawing.Size(134, 57);
            this.Ostatok.TabIndex = 2;
            this.Ostatok.Text = "Количество";
            this.Ostatok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(147, 85);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(200, 22);
            this.count.TabIndex = 3;
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(147, 140);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 4;
            // 
            // DataProizvodstva
            // 
            this.DataProizvodstva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataProizvodstva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.DataProizvodstva.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataProizvodstva.Location = new System.Drawing.Point(7, 128);
            this.DataProizvodstva.Name = "DataProizvodstva";
            this.DataProizvodstva.Size = new System.Drawing.Size(134, 57);
            this.DataProizvodstva.TabIndex = 5;
            this.DataProizvodstva.Text = "Дата\r\nпроизводства";
            this.DataProizvodstva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // srok
            // 
            this.srok.Location = new System.Drawing.Point(147, 199);
            this.srok.Name = "srok";
            this.srok.Size = new System.Drawing.Size(200, 22);
            this.srok.TabIndex = 7;
            // 
            // SroGodnosty
            // 
            this.SroGodnosty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SroGodnosty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(188)))), ((int)(((byte)(131)))));
            this.SroGodnosty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SroGodnosty.Location = new System.Drawing.Point(7, 185);
            this.SroGodnosty.Name = "SroGodnosty";
            this.SroGodnosty.Size = new System.Drawing.Size(134, 57);
            this.SroGodnosty.TabIndex = 6;
            this.SroGodnosty.Text = "Срок годности\r\n(в месецах)";
            this.SroGodnosty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // Postavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::Lab.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(371, 294);
            this.Controls.Add(this.save);
            this.Controls.Add(this.srok);
            this.Controls.Add(this.SroGodnosty);
            this.Controls.Add(this.DataProizvodstva);
            this.Controls.Add(this.date);
            this.Controls.Add(this.count);
            this.Controls.Add(this.Ostatok);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Chimikat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Postavka";
            this.Text = "Новая поставка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Chimikat;
        private System.Windows.Forms.ComboBox name;
        private System.Windows.Forms.Label Ostatok;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label DataProizvodstva;
        private System.Windows.Forms.TextBox srok;
        private System.Windows.Forms.Label SroGodnosty;
        private System.Windows.Forms.Button save;
    }
}