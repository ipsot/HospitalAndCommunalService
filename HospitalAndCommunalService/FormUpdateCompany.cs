using MySql.Data.MySqlClient;
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
    public partial class FormUpdateCompany : Form
    {
        MySqlConnection connection;
        MySqlCommand command;

        List<Company> companies;
        public FormUpdateCompany()
        {
            InitializeComponent();
        }

        private void buttonUpdateCompany_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"update `company` set `Name`='{ textBoxCompanyName.Text}' where id={Global.Company.Id}";
            MySqlDataReader reader = command.ExecuteReader();

            reader.Close();

            MessageBox.Show("Данные обновленны");

            this.Hide();
            new CompanyForm().Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CompanyForm();
        }

        private void FormUpdateCompany_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"Select * from `company` where `id`={Global.Company.Id}";
            MySqlDataReader reader = command.ExecuteReader();

            companies = new List<Company>();
            textBoxCompanyName.Text = Global.Company.Name;

            reader.Close();
        }
    }
}
