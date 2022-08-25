using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAndCommunalService
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CommunalService().Show();
        }

        private void buttonShowAdress_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdressForm().Show();
        }

        private void buttonShowCompany_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CompanyForm().Show();
        }

        private void buttonShowReceipt_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormReceipt().Show();
        }

        private void buttonShowTenant_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormTenant().Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormPayment().Show();
        }
    }
}
