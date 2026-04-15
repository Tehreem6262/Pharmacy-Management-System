using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageMarkPharmacy
{
    public partial class CustomerForm : Form
    {
        public static List<string> cart = new List<string>();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PainRelieversForm painRelieversForm = new PainRelieversForm();
            painRelieversForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoughSyrupsForm coughSyrupsForm = new CoughSyrupsForm();
            coughSyrupsForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SupplementsForm supplementsForm = new SupplementsForm();
            supplementsForm.Show();
        }

        private void btnAntibiotics_Click(object sender, EventArgs e)
        {
                AntibioticsForm antibioticsForm = new AntibioticsForm();
                antibioticsForm.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BillingForm billingForm = new BillingForm();
            billingForm.Show();

        }

        private void btnVitamins_Click(object sender, EventArgs e)
        {
            VitaminsForm vitaminsForm = new VitaminsForm();
            vitaminsForm.Show();
        }

        private void btnOthers_Click(object sender, EventArgs e)
        {
            OthersForm othersForm = new OthersForm();
            othersForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        
        }
    }
}
