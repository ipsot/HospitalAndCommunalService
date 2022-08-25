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
    public partial class FormUpdatePayment : Form
    {
        public FormUpdatePayment()
        {
            InitializeComponent();
        }
        MySqlConnection connection;
        MySqlCommand command;

        List<Payment> payments;

        private void LoadPaymentWithSelectedPayment()
        {
            command.CommandText = $"select* from payment as p JOIN receipt as r on p.id_receipt=r.id where p.id={Global.Payment.Id}";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                int total = reader.GetInt32("total");
                int receipt = reader.GetInt32("id_receipt");

                payments.Add(new Payment()
                {
                    Id = id,
                    Total = total,
                    Id_receipt = receipt
                });

            }
            reader.Close();

        }
        private void LoadPayment()
        {
            command.CommandText = $"select* from payment where id!={Global.Payment.Id}";

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                int total = reader.GetInt32("total");
                int receipt = reader.GetInt32("id_receipt");

                payments.Add(new Payment()
                {
                    Id = id,
                    Total = total,
                    Id_receipt = receipt
                });

            }
            reader.Close();

        }

        private void buttonUpdatePayment_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"update `payment` set `total`='{ textBoxItogo}',`id_receipt`='{ comboBoxIdReceipt.SelectedItem}' where id={Global.Payment.Id}";
            MySqlDataReader reader = command.ExecuteReader();

            reader.Close();

            MessageBox.Show("Данные обновленны");

            this.Hide();
            new FormPayment().Show();
        }


        private void buttonCancelPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormPayment().Show();
        }

        private void FormUpdatePayment_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;


            payments = new List<Payment>();
            try
            {
                LoadPaymentWithSelectedPayment();
                LoadPayment();
                //LoadReceipt();
                comboBoxIdReceipt.DataSource = payments;
                //comboBoxService.DisplayMember = Global.Service.Name;
                //comboBoxService.DataSource = services;
                comboBoxIdReceipt.DisplayMember = "id_receipt";
            }
            catch (Exception)
            {

                throw;
            }

            textBoxItogo.Text = Global.Payment.Total.ToString();
        }
    }
}
