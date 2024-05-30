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
    public partial class Postavka : Form
    {
        public Postavka()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmdObekt = con.CreateCommand();
            cmdObekt.CommandText = "Select ID, Название from Химикаты";
            SqlDataReader chim = cmdObekt.ExecuteReader();
            String str;
            while (chim.Read())
            {
                str = Convert.ToString(chim["ID"]+"   " + chim["Название"]);
                name.Items.Add(str);
            }
            chim.Close();
            con.Close();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-L97FM9K\\MSSQLSERVER19;" +
                                                    "Initial Catalog=Lab;" + "User ID=sa;" +
                                                    "Password=03102003;");

        private void save_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmdCreatePostavka = con.CreateCommand();
                cmdCreatePostavka.CommandText = "If not exists(select * from Партии where Химикат=@chim and [Дата производства]=@date) " +
                    "Insert into Партии (Химикат, Остаток, [Дата производства], [Срок годности]) Values (@chim, @ostat, @date, @srok) ";
                cmdCreatePostavka.Parameters.Add("@chim", SqlDbType.Int, 30, "КолРесурса").Value = name.Text.Substring(0, 3);
                cmdCreatePostavka.Parameters.Add("@ostat", SqlDbType.Int, 30, "Дата сбора").Value = count.Text;
                cmdCreatePostavka.Parameters.Add("@date", SqlDbType.Date, 30, "КолРесурса").Value = date.Text;
                cmdCreatePostavka.Parameters.Add("@srok", SqlDbType.Int, 30, "Дата сбора").Value = srok.Text;
                cmdCreatePostavka.ExecuteNonQuery();
                MessageBox.Show("Информация добавлена", "Успех");
                Close();
            }
            catch
            {
                MessageBox.Show("Проверьте корректность данных", "Ошибка");
            }
            con.Close();
        }
    }
}
