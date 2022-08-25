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
    public partial class FormUpdateTenant : Form
    {
        MySqlConnection connection;
        MySqlCommand command;

        List<Tenant> tenants;

        public FormUpdateTenant()
        {
            InitializeComponent();
        }

        private void buttonUpdateTenant_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"update `tenant` set `firstname`='{ textBoxName.Text}',`secondname`='{ textBoxSecondName.Text}',`patronymic`='{ textBoxPatronymic.Text}' where id={Global.Tenant.Id}";
            MySqlDataReader reader = command.ExecuteReader();

            reader.Close();

            MessageBox.Show("Данные обновленны");

            this.Hide();
            new FormTenant().Show();
        }

        private void buttonCancelTenant_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormTenant().Show();
        }

        private void FormUpdateTenant_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"Select * from `tenant` where `id`={Global.Tenant.Id}";
            MySqlDataReader reader = command.ExecuteReader();

            tenants = new List<Tenant>();
            textBoxName.Text = Global.Tenant.FirstName;
            textBoxSecondName.Text = Global.Tenant.SecondName;
            textBoxPatronymic.Text = Global.Tenant.Patronymic;

            reader.Close();
        }
    }
}
