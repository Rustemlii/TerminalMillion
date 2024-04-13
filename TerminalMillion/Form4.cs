using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerminalMillion
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3BalansaElaveOlunan_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void buttonEvvele_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void buttonMelumat_Click(object sender, EventArgs e)
        {
            Melumat m = new Melumat();
            Form5 form = new Form5();
            form.labelMelumat.Text = m.Information;
            form.Show();
        }
    }
}
