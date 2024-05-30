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
    public partial class Reaktiv : Form
    {
        public Reaktiv()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-L97FM9K\\MSSQLSERVER19;" +
                                                     "Initial Catalog=Lab;" + "User ID=sa;" +
                                                     "Password=03102003;");

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmdCreateGSO = con.CreateCommand();
                cmdCreateGSO.CommandText = "NewReak @name, @izgot, @kom, @stand ";
                cmdCreateGSO.Parameters.Add("@name", SqlDbType.NVarChar, 300, "Название").Value = name.Text;
                cmdCreateGSO.Parameters.Add("@izgot", SqlDbType.NVarChar, 100, "Изготовитель").Value = izgot.Text;
                cmdCreateGSO.Parameters.Add("@kom", SqlDbType.NVarChar, 500, "Комментарий").Value = prim.Text;
                cmdCreateGSO.Parameters.Add("@stand", SqlDbType.NVarChar, 50, "Стандарт").Value = standart.Text;
                cmdCreateGSO.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Информация добавлена", "Успех");
                Close();
            }
            catch 
            {
                MessageBox.Show("Проверьте корректность данных", "Ошибка");
            }
        }
    }
}
