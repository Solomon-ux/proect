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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Aut_Click(object sender, EventArgs e)
        {
            AutoForm autoForm = new AutoForm();
            autoForm.Show();
            this.Hide();
        }

        private void Regi_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
