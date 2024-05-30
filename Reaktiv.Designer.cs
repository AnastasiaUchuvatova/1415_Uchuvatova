namespace Lab
{
    partial class Reaktiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reaktiv));
            this.standart = new System.Windows.Forms.TextBox();
            this.izgot = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.textStandart = new System.Windows.Forms.Label();
            this.textIzgot = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.Label();
            this.prim = new System.Windows.Forms.TextBox();
            this.textPrim = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // standart
            // 
            this.standart.Location = new System.Drawing.Point(171, 77);
            this.standart.Name = "standart";
            this.standart.Size = new System.Drawing.Size(183, 22);
            this.standart.TabIndex = 64;
            // 
            // izgot
            // 
            this.izgot.Location = new System.Drawing.Point(171, 49);
            this.izgot.Name = "izgot";
            this.izgot.Size = new System.Drawing.Size(183, 22);
            this.izgot.TabIndex = 63;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(171, 21);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(183, 22);
            this.name.TabIndex = 62;
            // 
            // textStandart
            // 
            this.textStandart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textStandart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(188)))), ((int)(((byte)(138)))));
            this.textStandart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textStandart.Location = new System.Drawing.Point(11, 77);
            this.textStandart.Name = "textStandart";
            this.textStandart.Size = new System.Drawing.Size(129, 22);
            this.textStandart.TabIndex = 61;
            this.textStandart.Text = "Стандарт";
            this.textStandart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textIzgot
            // 
            this.textIzgot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textIzgot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(188)))), ((int)(((byte)(138)))));
            this.textIzgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textIzgot.Location = new System.Drawing.Point(11, 49);
            this.textIzgot.Name = "textIzgot";
            this.textIzgot.Size = new System.Drawing.Size(129, 22);
            this.textIzgot.TabIndex = 60;
            this.textIzgot.Text = "Изготовитель";
            this.textIzgot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textName
            // 
            this.textName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(188)))), ((int)(((byte)(138)))));
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textName.Location = new System.Drawing.Point(11, 21);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(129, 22);
            this.textName.TabIndex = 59;
            this.textName.Text = "Название";
            this.textName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prim
            // 
            this.prim.Location = new System.Drawing.Point(171, 105);
            this.prim.Name = "prim";
            this.prim.Size = new System.Drawing.Size(183, 22);
            this.prim.TabIndex = 58;
            // 
            // textPrim
            // 
            this.textPrim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPrim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(188)))), ((int)(((byte)(138)))));
            this.textPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPrim.Location = new System.Drawing.Point(11, 104);
            this.textPrim.Name = "textPrim";
            this.textPrim.Size = new System.Drawing.Size(129, 22);
            this.textPrim.TabIndex = 57;
            this.textPrim.Text = "Примечание";
            this.textPrim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LightGreen;
            this.save.Location = new System.Drawing.Point(14, 246);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(340, 37);
            this.save.TabIndex = 56;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Reaktiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(188)))), ((int)(((byte)(138)))));
            this.BackgroundImage = global::Lab.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(365, 294);
            this.Controls.Add(this.standart);
            this.Controls.Add(this.izgot);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textStandart);
            this.Controls.Add(this.textIzgot);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.prim);
            this.Controls.Add(this.textPrim);
            this.Controls.Add(this.save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reaktiv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый реактив";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox standart;
        private System.Windows.Forms.TextBox izgot;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label textStandart;
        private System.Windows.Forms.Label textIzgot;
        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.TextBox prim;
        private System.Windows.Forms.Label textPrim;
        private System.Windows.Forms.Button save;
    }
}