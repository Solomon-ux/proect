using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Zad_VlaNa
{
    public partial class prepod : Form
    {

        List<string[]> data = new List<string[]>();
        SqlConnection con = new SqlConnection(@"Data Source=SERV-SQL-09\SQLEXPRESS;Initial Catalog=user9;User ID=user9;Password=wsruser9");

        public prepod()
        {
            InitializeComponent();
            try
            {
                SqlCommand com = new SqlCommand("select Фамилия, Имя, Отчество, cl.класс, gr.оценка, th.[Оценка_за месяц], дата from Ученик st Join[за месяц оценка] th on(st.[Оценка_за месяц] = th.id) Join класс cl on(st.класс = cl.id) Join оцен gr on(st.оценка = gr.id)", con);
                con.Open();
                SqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    data.Add(new string[7]);
                    data[data.Count - 1][0] = read[0].ToString();
                    data[data.Count - 1][1] = read[1].ToString();
                    data[data.Count - 1][2] = read[2].ToString();
                    data[data.Count - 1][3] = read[3].ToString();
                    data[data.Count - 1][4] = read[4].ToString();
                    data[data.Count - 1][5] = read[5].ToString();
                    data[data.Count - 1][6] = read[6].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка в подключении бд. \n\n\n\n\nПодробнее:\n" + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            Grid1.Rows.Clear();
            foreach (string[] item in data)
            {
                Grid1.Rows.Add(item);

            }
    }

       
    }
}
