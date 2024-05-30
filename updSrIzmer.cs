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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Lab
{
    public partial class updSrIzmer : Form
    {
        public updSrIzmer()
        {
            InitializeComponent();
            con.Open();
            SqlCommand cmdObekt = con.CreateCommand();
            cmdObekt.CommandText = "Select * from [Средства измерения]";
            SqlDataReader nameSI = cmdObekt.ExecuteReader();
            String str;
            while (nameSI.Read())
            {
                str = Convert.ToString(nameSI["ID"]+"  "+nameSI["Название"]);
                name.Items.Add(str);
            }
            nameSI.Close();
            con.Close();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-L97FM9K\\MSSQLSERVER19;" +
                                                     "Initial Catalog=Lab;" + "User ID=sa;" +
                                                     "Password=03102003;");
        private void name_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmdZapoln = con.CreateCommand();
            cmdZapoln.CommandText = "Select * from [Средства измерения] where @ID=ID";
            cmdZapoln.Parameters.Add("@ID", SqlDbType.Int, 50, "ID").Value = Convert.ToInt32(name.Text.Substring(0,3));
            SqlDataReader Zapoln = cmdZapoln.ExecuteReader();
            while (Zapoln.Read())
            {
                number.Text = Convert.ToString(Zapoln["Заводской номер"]);
                type.Text = Convert.ToString(Zapoln["Тип"]);
                dateVup.Text = Convert.ToString(Zapoln["Дата выпуска"]);
                dateVvoda.Text = Convert.ToString(Zapoln["Дата ввода в эксплуатацию"]);
                diap.Text = Convert.ToString(Zapoln["Диапазон измерений"]);
                pogreshn.Text = Convert.ToString(Zapoln["Погрешность"]);
                numberSv.Text = Convert.ToString(Zapoln["Номер свидетельства о поверке"]);
                datePov.Text = Convert.ToString(Zapoln["Дата поверки"]);
                srok.Text = Convert.ToString(Zapoln["Срок действия поверки"]);
                organPov.Text = Convert.ToString(Zapoln["Организация осуществляющая поверку"]);
                prim.Text = Convert.ToString(Zapoln["Примечание"]);
            }
            Zapoln.Close();
            con.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmdUpdate = con.CreateCommand();
                cmdUpdate.CommandText = "if ([Дата выпуска] <=GETDATE() and [Дата ввода в эксплуатацию] <= GETDATE() and [Дата поверки]<=GETDATE() and [Дата поверки]<[Срок действия поверки])" +
                    "Update [Средства измерения]" +
                    "Set [Заводской номер]=@number, Тип=@type, [Дата выпуска]=@dateVup, " +
                    "[Дата ввода в эксплуатацию]=@dateVvoda, [Диапазон измерений]=@diap, Погрешность=@pogr, " +
                    "[Номер свидетельства о поверке]=@numberSv, [Дата поверки]=@datePov, " +
                    "[Срок действия поверки]=@srok, [Организация осуществляющая поверку]=@organiz, Примечание=@prim " +
                    "Where Название=@name ";
                cmdUpdate.Parameters.Add("@name", SqlDbType.NVarChar, 100, "Название").Value = name.Text;
                cmdUpdate.Parameters.Add("@number", SqlDbType.NVarChar, 50, "Заводской номер").Value = textNumber.Text;
                cmdUpdate.Parameters.Add("@type", SqlDbType.NVarChar, 100, "Тип").Value = type.Text;
                cmdUpdate.Parameters.Add("@dateVup", SqlDbType.Date, 50, "Дата выпуска").Value = dateVup.Text;
                cmdUpdate.Parameters.Add("@dateVvoda", SqlDbType.Date, 100, "Дата ввода в эксплуатацию").Value = dateVvoda.Text;
                cmdUpdate.Parameters.Add("@diap", SqlDbType.NVarChar, 100, "Диапазон измерений").Value = diap.Text;
                cmdUpdate.Parameters.Add("@pogr", SqlDbType.NVarChar, 100, "Погрешность").Value = pogreshn.Text;
                cmdUpdate.Parameters.Add("@numberSv", SqlDbType.NVarChar, 100, "Номер свидетельства о поверке").Value = numberSv.Text;
                cmdUpdate.Parameters.Add("@datePov", SqlDbType.Date, 50, "Дата поверки").Value = datePov.Text;
                cmdUpdate.Parameters.Add("@srok", SqlDbType.Date, 100, "Срок действия поверки").Value = srok.Text;
                cmdUpdate.Parameters.Add("@organiz", SqlDbType.NVarChar, 100, "Организация, осуществляющая поверку").Value = organPov.Text;
                cmdUpdate.Parameters.Add("@prim", SqlDbType.NVarChar, 500, "Примечание").Value = prim.Text;

                cmdUpdate.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Информация изменена", "Успех");
                Close();
            }
            catch
            {
                MessageBox.Show("Проверьте корректность данных", "Ошибка");
            }
        }
    }
}
