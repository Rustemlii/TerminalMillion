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
    public partial class Form2 : Form
    {
        Melumat m = new Melumat();
        public Form2()
        {
            InitializeComponent();


        }

        private void buttonGeri2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void buttonEvvele_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void buttonNomre1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTelefonNomresi.Text))
            {

            }
            else
            {
                Button btn = (Button)sender;
                textBoxTelefonNomresi.Text += btn.Text;
            }

        }

        private void buttonNomre2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTelefonNomresi.Text))
            {

            }
            Button btn = (Button)sender;
            textBoxTelefonNomresi.Text += btn.Text;
        }

        private void buttonNomre3_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            textBoxTelefonNomresi.Text += btn.Text;

        }

        private void buttonNomre4_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            textBoxTelefonNomresi.Text += btn.Text;
        }

        private void buttonNomre5_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            textBoxTelefonNomresi.Text += btn.Text;
        }

        private void buttonNomre6_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            textBoxTelefonNomresi.Text += btn.Text;
        }

        private void buttonNomre7_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            textBoxTelefonNomresi.Text += btn.Text;
        }

        private void buttonNomre8_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            textBoxTelefonNomresi.Text += btn.Text;
        }

        private void buttonNomre9_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            textBoxTelefonNomresi.Text += btn.Text;
        }

        private void buttonNomre0_Click(object sender, EventArgs e)
        {


            Button btn = (Button)sender;
            textBoxTelefonNomresi.Text += btn.Text;


        }

        private void buttonNomreSilme_Click(object sender, EventArgs e)
        {
            textBoxTelefonNomresi.Clear();

        }

        private void buttonNomreX_Click(object sender, EventArgs e)
        {
            textBoxTelefonNomresi.Text = textBoxTelefonNomresi.Text.Remove(textBoxTelefonNomresi.Text.Length - 1);
        }

        private void buttonIreli2_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();

            //form3.labelMilliodemeMenteqesi2.Text =labelMilliodemeMenteqesi1.Text;          
            long a = (long)Convert.ToUInt64(textBoxTelefonNomresi.Text);// duzeltmek lazmdiii
            if (a < 9)
            {

                MessageBox.Show("Telefon nomresini tam yigin", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Form3 form = new Form3();
                form.Show();
            }

        }

        private void textBoxTelefonNomresi_TextChanged(object sender, EventArgs e)
        {


            int a = textBoxTelefonNomresi.TextLength;

            if (a > 9)
            {
                textBoxTelefonNomresi.Text = textBoxTelefonNomresi.Text.Remove(textBoxTelefonNomresi.TextLength - 1);
                // MessageBox.Show("Xahish edirik yazi limitini kecmeyin ", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);           
            }
        }

        private void textBoxTelefonNomresi_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void buttonMelumat_Click(object sender, EventArgs e)
        {
            Melumat m = new Melumat();
            Form5 form = new Form5();
            if (buttonGeri2.Text == "Back")
            {
                form.labelMelumat.Text = "Komtec Ltd. (MilliÖN trademark), founded in 2008, is the leader in the market of electronic payment systems in Azerbaijan.\n" +
             "Currently, there are more than 150 companies and more than 500 types of services in the MilliÖN network." +
             "The number of MilliÖN payment terminals is more than 2500 and \nin many regions of Azerbaijan, in shopping and business centers, banks, state bodies and " +
             "located in branches, pedestrian crossings, metro stations, supermarkets,\n airports, bus stops." +
             "The company offers its subscribers to pay for the following services in a convenient and reliable way in the shortest possible time: \n" +
             "Utility payments - Mobile operators - State payments - Bank services - Internet providers - Cable television" +
             " - Landline network - Insurance Services - \nBetting Games - Entertainment - Wallets - Antivirus - Education - Charity" +
             " - BakuBus - Announcements and Coupons - Agent network - Network marketing -\n Store network (e-commerce) -\n Money transfers - Other services." +
             "\nMilliÖN brand is a quality mark that guarantees a high level of all offered services. " +
             "In 2012,  MMC conformed to the ISO 9001:2008 standard in order to\n provide services that meet the needs of consumers" +
             "Created and developed the Quality Management System.";
            }
            else
            {
                form.labelMelumat.Text = m.Information;
            }
            form.Show();
        }

        private void label1Nommm_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (buttonGeri2.Text == "Back")
            {

                labelMilliodemeMenteqesi1.Text = "National Payment";
                buttonEvvele.Text = "Main panel";
                buttonGeri2.Text = "Back";
                buttonIreli2.Text = "Ahead";
                buttonMelumat.Text = "Information";
                labelTelNomresi.Text = "Add your phone number";

            }
        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {

        }
    }
}
