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
    public partial class FormUpdateReceipt : Form
    {
        public FormUpdateReceipt()
        {
            InitializeComponent();
        }
        MySqlConnection connection;
        MySqlCommand command;

        List<Receipt> receipts;
        List<Service> services;
        List<Tenant> tenants;
        List<Adress> adresses;
        List<Company> companies;

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"update `receipt` set `id_service`='{ comboBoxService.SelectedItem}',`count_unit`='{ textBoxCountUnit.Text}',`id_tenant`='{ comboBoxTenant.SelectedItem}', `id_adress`='{comboBoxAdress.SelectedItem}', `id_company`='{comboBoxCompany.SelectedItem}' where id={Global.Receipt.Id}";
            MySqlDataReader reader = command.ExecuteReader();

            reader.Close();

            MessageBox.Show("Данные обновленны");

            this.Hide();
            new FormTenant().Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormReceipt().Show();
        }
        private void LoadReceipt()
        {
            command.CommandText = $"SELECT * from receipt as r JOIN adress as a on r.id_adress = a.id join tenant as t on r.id_tenant = t.id join communal_service AS cs on r.id_service = cs.id JOIN company AS com on r.id_company = com.id where r.id={Global.Receipt.Id}";
            //command.CommandText = $"Select * from `receipt` where `id`={Global.Receipt.Id}";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int id_service = reader.GetInt32(1);
                int count_unit = reader.GetInt32(2);
                int id_tenant = reader.GetInt32(3);
                int id_adress = reader.GetInt32(4);
                //string home = reader.GetString(8);
                //string flat = reader.GetString(9);
                //string fullAdress = id_adress + " дом " + home + ", квартира " + flat;
                int id_company = reader.GetInt32(5);

                receipts.Add(new Receipt()
                {
                    Id=id,Id_service=id_service,Id_adress=id_adress, CountUnit=count_unit, Id_company=id_company, Id_tenant=id_tenant

                });
            }
            reader.Close();
        }

        private void LoadServicesWithSelectedReceipt()
        {
            command.CommandText = $"select* from receipt as r JOIN communal_service as cs on r.id_service=cs.id where r.id={Global.Receipt.Id}";

            MySqlDataReader reader = command.ExecuteReader();

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
        private void LoadServices()
        {
            command.CommandText = $"select* from communal_service where id!={Global.Receipt.Id_service}";

            MySqlDataReader reader = command.ExecuteReader();

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
        private void LoadTenantWithSelectedReceipt()
        {
            command.CommandText = $"select* from receipt as r JOIN tenant as t on r.id_tenant=t.id where r.id={Global.Receipt.Id}";

            MySqlDataReader reader = command.ExecuteReader();

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
        private void LoadTenant()
        {
            command.CommandText = $"select* from tenant where id!={Global.Receipt.Id_tenant}";

            MySqlDataReader reader = command.ExecuteReader();

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

        private void LoadAdressWithSelectedReceipt()
        {
            command.CommandText = $"select* from receipt as r JOIN adress as a on r.id_tenant=a.id where r.id={Global.Receipt.Id}";

            MySqlDataReader reader = command.ExecuteReader();

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
        private void LoadAdress()
        {
            command.CommandText = $"select* from `adress` where id!={Global.Receipt.Id_adress}";

            MySqlDataReader reader = command.ExecuteReader();

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

        private void LoadCompaniesWithSelectedReceipt()
        {
            command.CommandText = $"select* from receipt as r JOIN company as c on r.id_tenant=c.id where r.id={Global.Receipt.Id}";

            MySqlDataReader reader = command.ExecuteReader();

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
        private void LoadCompnies()
        {
            command.CommandText = $"select* from `company` where id!={Global.Receipt.Id_company}";

            MySqlDataReader reader = command.ExecuteReader();

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

        //private void LoadTenant()
        //{
        //    command.CommandText = "select* from `tenant`";

        //    MySqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        int id = reader.GetInt32("id");
        //        string firstname = reader.GetString("firstname");
        //        string secondname = reader.GetString("secondname");
        //        string patronymic = reader.GetString("patronymic");

        //        tenants.Add(new Tenant()
        //        {
        //            Id = id,
        //            FirstName = firstname,
        //            SecondName = secondname,
        //            Patronymic = patronymic
        //        });

        //    }
        //    reader.Close();
        //}
        //private void LoadAdress()
        //{
        //    command.CommandText = "select* from `adress`";

        //    MySqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        int id = reader.GetInt32("id");
        //        string street = reader.GetString("street");
        //        string home = reader.GetString("home");
        //        string flat = reader.GetString("flat");
        //        int countPeople = reader.GetInt32("count_people");
        //        int square = reader.GetInt32("square");

        //        adresses.Add(new Adress()
        //        {
        //            id = id,
        //            street = street,
        //            home = home,
        //            flat = flat,
        //            countPeople = countPeople,
        //            square = square
        //        });

        //    }
        //    reader.Close();
        //}
        //private void LoadCompanies()
        //{
        //    command.CommandText = "select* from `company`";

        //    MySqlDataReader reader = command.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        int id = reader.GetInt32("id");
        //        string name = reader.GetString("name");

        //        companies.Add(new Company()
        //        {
        //            Id = id,
        //            Name = name
        //        }); ;

        //    }
        //    reader.Close();
        //}

        private void FormUpdateReceipt_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            //command.CommandText = $"SELECT * from receipt as r JOIN adress as a on r.id_adress = a.id join tenant as t on r.id_tenant = t.id join communal_service AS cs on r.id_service = cs.id JOIN company AS com on r.id_company = com.id where r.id={Global.Receipt.Id}";
            //command.CommandText = $"Select * from `receipt` where `id`={Global.Receipt.Id}";
            //MySqlDataReader reader = command.ExecuteReader();

            receipts = new List<Receipt>();
            services = new List<Service>();
            tenants = new List<Tenant>();
            adresses = new List<Adress>();
            companies = new List<Company>();
            try
            {
                LoadServicesWithSelectedReceipt();
                LoadServices();
                //LoadReceipt();
                comboBoxService.DataSource = services;
                //comboBoxService.DisplayMember = Global.Service.Name;
                //comboBoxService.DataSource = services;
                comboBoxService.DisplayMember = "name";
            }
            catch (Exception)
            {

                throw;
            }
            

            try
            {
                LoadTenantWithSelectedReceipt();
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
                LoadAdressWithSelectedReceipt();
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
                LoadCompaniesWithSelectedReceipt();
                LoadCompnies();
                comboBoxCompany.DataSource = companies;
                comboBoxCompany.DisplayMember = "name";
            }
            catch (Exception)
            {

                throw;
            }

            
            //textBoxName.Text = Global.Tenant.FirstName;
            //textBoxSecondName.Text = Global.Tenant.SecondName;
            //textBoxPatronymic.Text = Global.Tenant.Patronymic;

            //reader.Close();

        }
    }
}
