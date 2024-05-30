namespace Lab
{
    partial class Avtoriz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtoriz));
            this.Person = new System.Windows.Forms.ComboBox();
            this.TextName = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.avtorizacia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Person
            // 
            this.Person.BackColor = System.Drawing.Color.White;
            this.Person.ForeColor = System.Drawing.Color.Black;
            this.Person.FormattingEnabled = true;
            this.Person.Location = new System.Drawing.Point(12, 28);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(339, 24);
            this.Person.TabIndex = 3;
            // 
            // TextName
            // 
            this.TextName.AutoSize = true;
            this.TextName.Location = new System.Drawing.Point(12, 9);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(168, 16);
            this.TextName.TabIndex = 2;
            this.TextName.Text = "Выберите пользователя";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(12, 79);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(339, 22);
            this.password.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите пароль";
            // 
            // avtorizacia
            // 
            this.avtorizacia.BackColor = System.Drawing.Color.LightGreen;
            this.avtorizacia.Location = new System.Drawing.Point(84, 145);
            this.avtorizacia.Name = "avtorizacia";
            this.avtorizacia.Size = new System.Drawing.Size(189, 23);
            this.avtorizacia.TabIndex = 6;
            this.avtorizacia.Text = "Войти";
            this.avtorizacia.UseVisualStyleBackColor = false;
            this.avtorizacia.Click += new System.EventHandler(this.Person_Clik);
            // 
            // avtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::Lab.Properties.Resources.фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(363, 194);
            this.Controls.Add(this.avtorizacia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Person);
            this.Controls.Add(this.TextName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "avtoriz";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Person;
        private System.Windows.Forms.Label TextName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button avtorizacia;
    }
}