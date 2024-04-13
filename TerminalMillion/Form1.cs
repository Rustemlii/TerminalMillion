using System.Drawing.Drawing2D;

namespace TerminalMillion
{
    public partial class Form1 : Form
    {
        Melumat m = new Melumat();

        public Form1()
        {
            InitializeComponent();

        }



        private void panelBakcell_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEvvele_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void buttonBakcell_Click(object sender, EventArgs e)
        {




            Form2 form = new Form2();
            form.buttonGeri2.Text = buttonGeri.Text;
            form.Show();


        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {
            labelBankXidmetleri.Text = "Bank services";
            labelElektronKise.Text = "Electro wallet";
            labelEylence.Text = "Fun";
            labelKartlar.Text = "Cards";
            labelMilliodemeMenteqesi.Text = "National Payment";
            labelTelefon.Text = "Phone Pay";
            buttonEvvele.Text = "Main panel";
            buttonGeri.Text = "Back";
            buttonIreli.Text = "Ahead";
            buttonMelumat.Text = "Information";
            labelKommunal.Text = "Communal service";

           

        }

        private void buttonMelumat_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            if (buttonGeri.Text == "Back")
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
             "In 2012,  MMC conformed to the ISO 9001:2008 standard in order to \nprovide services that meet the needs of consumers" +
             "Created and developed the Quality Management System.";

            }
            else
            {
              
                form.labelMelumat.Text = m.Information;
            }

        
            form.Show();


        }

        private void label1Nom_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.label1Nom.Text = m.Nomre;

        }

        private void buttonNar_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.buttonGeri2.Text = buttonGeri.Text;
            form.Show();
        }

        private void buttonAzercell_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.buttonGeri2.Text = buttonGeri.Text;
            form.Show();
        }

        private void buttonBankxidmetleri_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();

        }

        private void buttonKommunal_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();
            form.Show();
        }
    }
}