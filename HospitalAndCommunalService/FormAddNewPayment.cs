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
    public partial class FormAddNewPayment : Form
    {
        public FormAddNewPayment()
        {
            InitializeComponent();
        }
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;

        List<Receipt> receipts1;
        List<Payment> payments;
        List<Service> services;



        private void LoadPayment()
        {
            mySqlCommand.CommandText = "select* from `receipt`";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                int id_service = reader.GetInt32("id_service");
                int count_unit = reader.GetInt32("count_unit");
                int id_tenant = reader.GetInt32("id_tenant");
                int id_adress = reader.GetInt32("id_adress");
                int id_company = reader.GetInt32("id_company");

                receipts1.Add(new Receipt()
                {
                    Id = id,
                    Id_service = id_service,
                    Id_adress = id_adress,
                    CountUnit = count_unit,
                    Id_company = id_company,
                    Id_tenant = id_tenant

                });

            }
            reader.Close();
        }
        private void buttonAddNewPayment_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;

                List<Receipt> receipts;

                int idReceipt = ((Receipt)comboBoxIdReceipt.SelectedItem).Id;

                if (textBoxItogo.Text == null)
                {
                    MessageBox.Show("Пожайлуста заполните все поля");
                    return;
                }

                //int sum = price * count;
                //textBoxItogo.Text = $"{sum}";
                //int idGenre = ((Genres)(comboBoxGenre.SelectedItem)).Id;


                mySqlCommand.CommandText = $"insert into `payment` (`id`,`total`,`id_receipt`) values (0,'{textBoxItogo.Text}','{idReceipt}')";
                mySqlCommand.ExecuteNonQuery();


                this.Hide();
                new FormPayment().Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void buttonCancelPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormPayment().Show();
        }

        private void FormAddNewPayment_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = mySqlConnection;

            services = new List<Service>();
            payments = new List<Payment>();
            receipts1 = new List<Receipt>();
            try
            {
                LoadPayment();
                comboBoxIdReceipt.DataSource = receipts1;
                comboBoxIdReceipt.DisplayMember = "id";
            }
            catch (Exception)
            {
                throw;
            }
            textBoxItogo.Text = "0";
            //mySqlCommand.CommandText = $"select* from payment as p JOIN receipt as r on p.id_receipt=r.id JOIN communal_service as cs on r.id_service=cs.id where p.id_receipt={Global.Payment.Id_receipt}";
            //MySqlDataReader reader = mySqlCommand.ExecuteReader();

            //mySqlCommand.CommandText = $"select* from payment as p JOIN receipt as r on p.id_receipt=r.id JOIN communal_service as cs on r.id_service=cs.id where p.id_receipt={Global.Payment.Id_receipt}";
            //MySqlDataReader reader = mySqlCommand.ExecuteReader();

            //int price = reader.GetInt32(12);
            //int count = reader.GetInt32(5);
            //int itogo = price * count;
            //textBoxItogo.Text = itogo.ToString();
        }

        private void comboBoxIdReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        public void Test()
        {
            
            payments = new List<Payment>();
            receipts1 = new List<Receipt>();
            int idReceipt = ((Receipt)comboBoxIdReceipt.SelectedItem).Id;
            mySqlCommand.CommandText = $"select* from payment as p JOIN receipt as r on p.id_receipt=r.id JOIN communal_service as cs on r.id_service=cs.id where p.id_receipt={idReceipt}";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            while (reader.Read())
            {
                int price = reader.GetInt32(12);
                int count = reader.GetInt32(5);
                int itogo = price * count;
                textBoxItogo.Text = $"{itogo}";
            }

            reader.Close();
            return;

        }

        private void comboBoxIdReceipt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                Test();
                
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
