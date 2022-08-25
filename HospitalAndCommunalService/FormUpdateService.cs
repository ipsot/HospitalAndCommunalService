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
    public partial class FormUpdateService : Form
    {

        MySqlConnection connection;
        MySqlCommand command;

        List<Service> services;
        public FormUpdateService()
        {
            InitializeComponent();
        }

        private void buttonUpdateService_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"update `communal_service` set `Name`='{ textBoxName.Text}',`Unit`='{ textBoxUnit.Text}',`price_for_unit`='{ textBoxPriceForUnit.Text}' where id={Global.Service.Id}";
            MySqlDataReader reader = command.ExecuteReader();

            reader.Close();

            MessageBox.Show("Данные обновленны");

            this.Hide();
            new CommunalService().Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CommunalService().Show();
        }

        private void FormUpdateService_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"Select * from `communal_service` where `id`={Global.Service.Id}";
            MySqlDataReader reader = command.ExecuteReader();

            services = new List<Service>();
            textBoxName.Text = Global.Service.Name;
            textBoxUnit.Text = Global.Service.Unit;
            textBoxPriceForUnit.Text = Convert.ToString(Global.Service.Price);

            reader.Close();
        }
    }
}
