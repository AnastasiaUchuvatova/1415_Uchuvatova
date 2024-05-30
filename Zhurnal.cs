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
    public partial class Zhurnal : Form
    {
        public Zhurnal(int person)
        {
            InitializeComponent();
            this.person = person;

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-L97FM9K\\MSSQLSERVER19;" +
                                                    "Initial Catalog=Lab;" + "User ID=sa;" +
                                                    "Password=03102003;");
        int person;
        int ID;
        private void save_Click(object sender, EventArgs e)
        {
            con.Open();
            if (person != 0)
            {
                try
                {
                    SqlCommand cmdID = con.CreateCommand();
                    cmdID.CommandText = "Select ID from [Вид исследований] where [Объект испытаний]=@obj and [Определяемая характеристика]=@har";
                    cmdID.Parameters.Add("@obj", SqlDbType.NVarChar, 50, "Объект").Value = objec.Text;
                    cmdID.Parameters.Add("@har", SqlDbType.NVarChar, 100, "Характеристика").Value = harakt.Text;
                    ID = Int32.Parse(cmdID.ExecuteScalar().ToString());

                    SqlCommand cmdCreateZhuenal = con.CreateCommand();
                    cmdCreateZhuenal.CommandText = "Insert into Журнал (Персонал, Исследование, Дата, Примечание) Values (@person, @issled, @date, @primechanie) ";
                    cmdCreateZhuenal.Parameters.Add("@person", SqlDbType.Int, 30, "Персонал").Value = person;
                    cmdCreateZhuenal.Parameters.Add("@issled", SqlDbType.Int, 30, "Исследование").Value = ID;
                    cmdCreateZhuenal.Parameters.Add("@date", SqlDbType.Date, 30, "Дата").Value = date.Text;
                    cmdCreateZhuenal.Parameters.Add("@primechanie", SqlDbType.NVarChar, 500, "Примечание").Value = prim.Text;
                    cmdCreateZhuenal.ExecuteNonQuery();
                    MessageBox.Show("Информация добавлена", "Успех");
                    Close();
                }
                catch 
                {
                    MessageBox.Show("Проверьте корректность данных", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя и повторите попытку", "Ошибка");
                Close();
            }
            con.Close();
        }
        private void NeedForIssled_Enter(object sender, EventArgs e)
        {
            objec.Items.Clear();
            harakt.Items.Clear();
            harakt.Text = "Характеристика";
            con.Open();
            SqlCommand cmdObekt = con.CreateCommand();
            cmdObekt.CommandText = "Select [Объект испытаний] as Объект from [Вид исследований] group by [Объект испытаний]";
            SqlDataReader obj = cmdObekt.ExecuteReader();
            String str;
            while (obj.Read())
            {
                str = Convert.ToString(obj["Объект"]);
                objec.Items.Add(str);
            }
            obj.Close();
            con.Close();
        }

        private void harakt_Enter(object sender, EventArgs e)
        {
            harakt.Items.Clear();
            con.Open();
            SqlCommand cmdObekt = con.CreateCommand();
            cmdObekt.CommandText = "Select [Определяемая характеристика] as Характеристика from [Вид исследований] where [Объект испытаний]=@obj";
            cmdObekt.Parameters.Add("@obj", SqlDbType.NVarChar, 50, "Объект").Value = objec.Text;
            SqlDataReader har = cmdObekt.ExecuteReader();
            String str;
            while (har.Read())
            {
                str = Convert.ToString(har["Характеристика"]);
                harakt.Items.Add(str);
            }
            har.Close();
            con.Close();
        }

    }
}
