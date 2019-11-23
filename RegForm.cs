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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source=SERV-SQL-09\SQLEXPRESS;Initial Catalog=user9;User ID=user9;Password=wsruser9");
            SqlConnection.Open(); // создание подлючения
            SqlCommand SqlCommand = new SqlCommand("select * from Ученик where Логин = '" + tx4.Text + "' ", SqlConnection);
            SqlDataReader SqlDataReader = SqlCommand.ExecuteReader();

            if (SqlDataReader.HasRows)


            {
                SqlDataReader.Close();
                MessageBox.Show("Логин занят");

            }

            else
            {
                SqlDataReader.Close();
                SqlCommand sqlCommand1 = new SqlCommand("insert into Пользователи(Фамилия, имя, Отчество, id_логин, пароль, почта) values ('" + tx1.Text + "','" + tx2.Text + "','" + tx3.Text + "','" + tx4.Text + "','" + tx5.Text + "','" + tx7.Text + "') ", SqlConnection);
                SqlCommand sqlCommand = new SqlCommand("insert into Ученик(Фамилия, Имя, Отчество, Логин, Пароль, почта) values ('" + tx1.Text + "','" + tx2.Text + "','" + tx3.Text + "','" + tx4.Text + "','" + tx5.Text + "','" + tx7.Text + "') ", SqlConnection);
                sqlCommand.ExecuteNonQuery();
            }





           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx1.Text = "";
            tx2.Text = "";
            tx3.Text = "";
            tx4.Text = "";
            tx5.Text = "";
            tx6.Text = "";
            tx7.Text = "";
        }
    }
}
