using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad_VlaNa
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Выход", "Выйти?", MessageBoxButtons.YesNo);

            if(res == DialogResult.Yes)
            {

                Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prepod prepod = new prepod();
            Hide();
            prepod.Show();
        }
    }
}
