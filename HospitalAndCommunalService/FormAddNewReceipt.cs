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
    public partial class FormAddNewReceipt : Form
    {
        public FormAddNewReceipt()
        {
            InitializeComponent();
        }
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;

        List<Service> services;
        List<Tenant> tenants;
        List<Adress> adresses;
        List<Company> companies;

        private void LoadServices()
        {
            mySqlCommand.CommandText = "select* from `communal_service`";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");
                string unit = reader.GetString("unit");
                int price = reader.GetInt32("price_for_unit");

                services.Add(new Service()
                {
                    Id = id,
                    Name = name,
                    Unit = unit,
                    Price = price
                });

            }
            reader.Close();
        }
        private void LoadTenant()
        {
            mySqlCommand.CommandText = "select* from `tenant`";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string firstname = reader.GetString("firstname");
                string secondname = reader.GetString("secondname");
                string patronymic = reader.GetString("patronymic");

                tenants.Add(new Tenant()
                {
                    Id = id,
                    FirstName = firstname,
                    SecondName = secondname,
                    Patronymic = patronymic
                });

            }
            reader.Close();
        }
        private void LoadAdress()
        {
            mySqlCommand.CommandText = "select* from `adress`";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string street = reader.GetString("street");
                string home = reader.GetString("home");
                string flat = reader.GetString("flat");
                int countPeople = reader.GetInt32("count_people");
                int square = reader.GetInt32("square");

                adresses.Add(new Adress()
                {
                    id = id,
                    street = street,
                    home = home,
                    flat = flat,
                    countPeople = countPeople,
                    square = square
                });

            }
            reader.Close();
        }
        private void LoadCompanies()
        {
            mySqlCommand.CommandText = "select* from `company`";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");

                companies.Add(new Company()
                {
                    Id = id,
                    Name = name
                }); ;

            }
            reader.Close();
        }

        private void FormAddNewReceipt_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = mySqlConnection;

            services = new List<Service>();
            tenants = new List<Tenant>();
            adresses = new List<Adress>();
            companies = new List<Company>();
            try
            {
                LoadServices();
                comboBoxService.DataSource = services;
                comboBoxService.DisplayMember = "Name";
            }
            catch (Exception)
            {

                throw;
            }

            try
            {
                LoadTenant();
                comboBoxTenant.DataSource = tenants;
                comboBoxTenant.DisplayMember = "secondname";
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                LoadAdress();
                comboBoxAdress.DataSource = adresses;
                comboBoxAdress.DisplayMember = "street";
            }
            catch (Exception)
            {

                throw;
            }
            try
            {
                LoadCompanies();
                comboBoxCompany.DataSource = companies;
                comboBoxCompany.DisplayMember = "name";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;

                List<Service> services;
                List<Tenant> tenants;
                List<Adress> adresses;
                List<Company> companies;
                int idService = ((Service)comboBoxService.SelectedItem).Id;
                int idAdress = ((Adress)comboBoxAdress.SelectedItem).id;
                int idTenant = ((Tenant)comboBoxTenant.SelectedItem).Id;
                int idSCompany = ((Company)comboBoxCompany.SelectedItem).Id;

                if (textBox3.Text == null)
                {
                    MessageBox.Show("Пожайлуста заполните все поля");
                    return;
                }

                //int idGenre = ((Genres)(comboBoxGenre.SelectedItem)).Id;

                mySqlCommand.CommandText = $"insert into `receipt` (`id`,`id_service`,`count_unit`,`id_tenant`,`id_adress`,`id_company`) values (0,'{idService}','{textBox3.Text}','{idTenant}','{idAdress}',{idSCompany})";
                mySqlCommand.ExecuteNonQuery();


                this.Hide();
                new FormReceipt().Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
