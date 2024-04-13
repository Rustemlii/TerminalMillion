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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBoxEskinaz_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIreli2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            int a = Convert.ToInt32(textBoxEskinaz.Text);
            if (a > 0)
            {
                f4.label3BalansaElaveOlunan.Text = a.ToString() + " " + "Azn";
            }

            f4.Show();
        }

        private void buttonGeri2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void buttonMelumat_Click(object sender, EventArgs e)
        {
            Melumat m = new Melumat();
            Form5 form = new Form5();
            form.labelMelumat.Text = m.Information;
            form.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form2 form = new Form2();

            if (form.labelMilliodemeMenteqesi1.Text == "National Payment")
            {
                buttonIreli3.Text = "Ahead";
                buttonGeri3.Text = "Back";
                labelBalans.Text = "Enter money";
                buttonEvvele.Text = "Main panel";
                buttonMelumat.Text = "Information";
                labelMilliodemeMenteqesi2.Text = "National Payment";
            }




        }
    }
}
