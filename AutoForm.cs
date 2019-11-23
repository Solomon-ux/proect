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
    public partial class AutoForm : Form
    {
        public AutoForm()
        {
            InitializeComponent();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection(@"Data Source=SERV-SQL-09\SQLEXPRESS;Initial Catalog=user9;User ID=user9;Password=wsruser9");
            SqlConnection.Open();

            SqlCommand SqlCommand = new SqlCommand("select * from Пользователи where id_логин ='" + TextBox1.Text + "' and Пароль = '" + TextBox2.Text + "' ", SqlConnection);
            SqlDataReader SqlDataReader = SqlCommand.ExecuteReader();

            if (SqlDataReader.HasRows)
            {
                MessageBox.Show("Авторизация прошла успешно");
                UserForm userForm = new UserForm();
                Hide();
                userForm.Show();
            }
            else
            {
                MessageBox.Show("Пользователь не найден. Проверьте правильность введеных данных в поле Логин и пароль!");
            }
































            // try
            //{
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\source\repos\Zad_VlaNa\GamesInt.mdf;Integrated Security=True");
            //con.Open();
            // SqlCommand check = new SqlCommand("select * from [Table] where Логин = '" + textBox1.Text + "' and Пароль = '" + textBox2.Text + "'", con);

            //   SqlDataReader reader = check.ExecuteReader();

            //if (reader.HasRows)
            //{
            //UserForm userForm = new UserForm();
            //userForm.Show();
            //  this.Hide();
            //}
            // else
            //{
            // MessageBox.Show("Ошибка");

            // }
            //   con.Close();
            // }
            //catch
            //{
            //    MessageBox.Show("Ошибка!");
            //  }
            //}
        }
    }
    }
