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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace Lab
{
    public partial class GSO : Form
    {
        public GSO()
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
                cmdCreateGSO.CommandText = "NewGSO @name, @izgot, @kom, @number, @naznach, @znach, @pogreschn ";
                cmdCreateGSO.Parameters.Add("@name", SqlDbType.NVarChar, 300, "Название").Value = name.Text;
                cmdCreateGSO.Parameters.Add("@izgot", SqlDbType.NVarChar, 100, "Изготовитель").Value = izgot.Text;
                cmdCreateGSO.Parameters.Add("@kom", SqlDbType.NVarChar, 500, "Комментарий").Value = prim.Text;
                cmdCreateGSO.Parameters.Add("@number", SqlDbType.NVarChar, 10, "Номер").Value = number.Text;
                cmdCreateGSO.Parameters.Add("@naznach", SqlDbType.NVarChar, 100, "Назначение").Value = naznash.Text;
                cmdCreateGSO.Parameters.Add("@znach", SqlDbType.NVarChar, 20, "Значение").Value = znach.Text;
                cmdCreateGSO.Parameters.Add("@pogreschn", SqlDbType.NVarChar, 10, "Погрешность").Value = pogreshn.Text;
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
