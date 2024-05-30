using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{
    public partial class Avtoriz : Form
    {
        public Avtoriz()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmdObekt = con.CreateCommand();
            cmdObekt.CommandText = "Select * from Персонал";
            SqlDataReader pers = cmdObekt.ExecuteReader();
            String str;
            while (pers.Read())
            {
                str = Convert.ToString(pers["ID"] + "  " + pers["ФИО"]);
                Person.Items.Add(str);
            }
            pers.Close();
            con.Close();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-L97FM9K\\MSSQLSERVER19;" +
                                                     "Initial Catalog=Lab;" + "User ID=sa;" +
                                                     "Password=03102003;");
        public static int person;
        string[] passwords = new string[] { "123", "456", "789" };

        private void Person_Clik(object sender, EventArgs e)
        {
            if (Person.Text!="")
            {
                if (passwords[Convert.ToInt32(Person.Text.Substring(0, 3)) - 1] == password.Text)
                {
                    Lab.person = Convert.ToInt32(Person.Text.Substring(0, 3));
                    Close();
                }
                else
                {
                    MessageBox.Show("Неправильный пароль", "Ошибка");
                }
            }
        }
    }
}
