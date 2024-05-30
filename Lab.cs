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
using Excel = Microsoft.Office.Interop.Excel;

namespace Lab
{
    public partial class Lab : Form
    {
        public Lab(/*int person*/)
        {
            InitializeComponent();
            //this.person = person;
            //Просроченные химикаты
            SqlCommand cmdSelectProsrChim = con.CreateCommand();
            cmdSelectProsrChim.CommandText = "SELECT * FROM [просроченные химикаты]";
            daProsrChim.SelectCommand = cmdSelectProsrChim;
            daProsrChim.Fill(dsProsrChim, "Просроченные химикаты");
            daProsrChim.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daProsrChim.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            dgProsrChim.DataSource = dsProsrChim.Tables[0];
            //оборудование для поверки
            SqlCommand cmdSelectPover = con.CreateCommand();
            cmdSelectPover.CommandText = "SELECT * FROM [просроченные средства измерения]";
            daPover.SelectCommand = cmdSelectPover;
            daPover.Fill(dsPover, "Требуется поверка");
            daPover.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daPover.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            dgPover.DataSource = dsPover.Tables[0];
            //журнал
            SqlCommand cmdSelectGurnal = con.CreateCommand();
            cmdSelectGurnal.CommandText = "SELECT Журнал.ID, Персонал.ФИО, [Вид исследований].[Объект испытаний], [Вид исследований].[Определяемая характеристика]  FROM (Журнал join Персонал on Персонал.ID=Журнал.Персонал) join [Вид исследований] on [Вид исследований].ID = Журнал.Исследование";
            daGurnal.SelectCommand = cmdSelectGurnal;
            daGurnal.Fill(dsGurnal, "Журнал");
            daGurnal.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daGurnal.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            dgGurnal.DataSource = dsGurnal.Tables[0];
            //годовая оценка
            SqlCommand cmdSelectZaGod = con.CreateCommand();
            cmdSelectZaGod.CommandText = "PlanRashoda";
            daZaGod.SelectCommand = cmdSelectZaGod;
            daZaGod.Fill(dsZaGod, "Оценка");
            daZaGod.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daZaGod.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            dgZaGod.DataSource = dsZaGod.Tables[0];
            //план поверок
            SqlCommand cmdSelectPlanPoverok = con.CreateCommand();
            cmdSelectPlanPoverok.CommandText = "PlanPoverok";
            daPlanPoverok.SelectCommand = cmdSelectPlanPoverok;
            daPlanPoverok.Fill(dsPlanPoverok, "План поверок");
            daPlanPoverok.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daPlanPoverok.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            dgPlanPoverok.DataSource = dsPlanPoverok.Tables[0];
            //план заказа
            SqlCommand cmdSelectPlanZakaza = con.CreateCommand();
            cmdSelectPlanZakaza.CommandText = "PlanHimikat";
            daPlanZakaza.SelectCommand = cmdSelectPlanZakaza;
            daPlanZakaza.Fill(dsPlanZakaza, "План поверок");
            daPlanZakaza.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daPlanZakaza.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
            dgPlanZakaza.DataSource = dsPlanZakaza.Tables[0];
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-L97FM9K\\MSSQLSERVER19;" +
                                                     "Initial Catalog=Lab;" + "User ID=sa;" +
                                                     "Password=03102003;");
        SqlDataAdapter daProsrChim = new SqlDataAdapter();
        DataSet dsProsrChim = new DataSet();
        SqlDataAdapter daPover = new SqlDataAdapter();
        DataSet dsPover = new DataSet();
        SqlDataAdapter daGurnal = new SqlDataAdapter();
        DataSet dsGurnal = new DataSet();
        SqlDataAdapter daZaGod = new SqlDataAdapter();
        DataSet dsZaGod = new DataSet();
        SqlDataAdapter daPlanPoverok = new SqlDataAdapter();
        DataSet dsPlanPoverok = new DataSet();
        SqlDataAdapter daPlanZakaza = new SqlDataAdapter();
        DataSet dsPlanZakaza = new DataSet();
        int ID;
        public static int person;
        
        private static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs args)
        {
            if (args.Status == UpdateStatus.ErrorsOccurred)
            {
                MessageBox.Show(args.Errors.Message, "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                args.Status = UpdateStatus.SkipCurrentRow;
            }
        }

        private void ShowForIssled_Click(object sender, EventArgs e)
        {
            if (objec.Text!= "Объект исследования" && harakt.Text!= "Характеристика")
            {
                    SqlDataAdapter daForIssled = new SqlDataAdapter();
                    DataSet dsForIssled = new DataSet();
                    dgForIssled.DataSource = null;
                    //Необходимое для исследования
                    con.Open();
                    SqlCommand cmdSelectForIssled = con.CreateCommand();
                    cmdSelectForIssled.CommandText = "Nado @ID";
                    SqlCommand cmdID = con.CreateCommand();
                    cmdID.CommandText = "Select ID from [Вид исследований] where [Объект испытаний]=@obj and [Определяемая характеристика]=@har";
                    cmdID.Parameters.Add("@obj", SqlDbType.NVarChar, 50, "Объект").Value = objec.Text;
                    cmdID.Parameters.Add("@har", SqlDbType.NVarChar, 100, "Характеристика").Value = harakt.Text;
                    if (cmdID.ExecuteScalar() != null)
                    {
                        ID = Int32.Parse(cmdID.ExecuteScalar().ToString());
                        cmdSelectForIssled.Parameters.Add("@ID", SqlDbType.Int, 30, "ID").Value = ID;
                        daForIssled.SelectCommand = cmdSelectForIssled;
                        daForIssled.Fill(dsForIssled, "Требуется для исследования");
                        daForIssled.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                        daForIssled.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);
                        dgForIssled.DataSource = dsForIssled.Tables[0];
                        harakt.Text = "Характеристика";
                        objec.Text = "Объект исследования";
                    }
                    if (dgForIssled.RowCount == 0)
                    {
                        MessageBox.Show("Нет информации в базе или для исследования ничего не требуется", "Ошибка");
                    }
                    con.Close();
            }
            else
            {
                MessageBox.Show("Введены некорректные данные", "Ошибка");
            }
            con.Close();
        }

        private void NeedForIssled_Enter(object sender, EventArgs e)
        {
            objec.Items.Clear();
            harakt.Items.Clear();
            harakt.Text= "Характеристика";
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

        private void newPostavka_Click(object sender, EventArgs e)
        {
            Postavka formPostavka = new Postavka();
            formPostavka.Show();
        }

        private void NewIssled_Click(object sender, EventArgs e)
        {
            Zhurnal formZhurnal = new Zhurnal(person);
            formZhurnal.Show();
        }

        private void newGSO_Click(object sender, EventArgs e)
        {
            GSO formGSO = new GSO();
            formGSO.Show();
        }

        private void newReaktiv_Click(object sender, EventArgs e)
        {
            Reaktiv formReaktiv = new Reaktiv();
            formReaktiv.Show();
        }

        private void newPrekursor_Click(object sender, EventArgs e)
        {
            Prekursor formPrekursor = new Prekursor();
            formPrekursor.Show();
        }

        private void updSrIzmer_Click(object sender, EventArgs e)
        {
            updSrIzmer formUpdSrIzmer = new updSrIzmer();
            formUpdSrIzmer.Show();
        }

        
        private void otchetIssledovaniya_Click(object sender, EventArgs e)
        {
            otchet_Data("SELECT Журнал.ID, Персонал.ФИО, [Вид исследований].[Объект испытаний], [Вид исследований].[Определяемая характеристика], Журнал.Дата, Журнал.Примечание  FROM (Журнал join Персонал on Персонал.ID=Журнал.Персонал) join [Вид исследований] on [Вид исследований].ID = Журнал.Исследование where DATEADD(year, 1, Дата) >= GetDate()");
        }
        private DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand comm = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(comm);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        private void otchet_Data(string querty)
        {
            Excel.Application xlApp = new Excel.Application();
            try
            {
                //добавляем книгу
                xlApp.Workbooks.Add(Type.Missing);
                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;
                //выбираем лист на котором будем работать (Лист 1)
                Excel.Worksheet xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                //Название листа
                xlSheet.Name = "Данные";
                //Выгрузка данных
                DataTable dt = GetData(querty);
                int collInd = 0;
                int rowInd = 0;
                string data = "";
                //называем колонки
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[1, i + 1] = data;
                    //выделяем первую строку
                    Excel.Range xlSheetRange1 = xlSheet.get_Range("A1:Z1", Type.Missing);
                    //делаем полужирный текст и перенос слов
                    xlSheetRange1.WrapText = true;
                    xlSheetRange1.Font.Bold = true;
                }
                //заполняем строки
                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }
                //выбираем всю область данных
                Excel.Range xlSheetRange = xlSheet.UsedRange;
                //выравниваем строки и колонки по их содержимому
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
                //Показываем ексель
                xlApp.Visible = true;
                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;
                //Отсоединяемся от Excel
                releaseObject(xlSheetRange);
                releaseObject(xlSheet);
                releaseObject(xlApp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void otchetHimikat_Click(object sender, EventArgs e)
        {
            otchet_Data("PlanRashoda");
        }

    }
}
