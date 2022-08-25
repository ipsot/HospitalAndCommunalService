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
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
        }
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        MySqlConnection connection;
        private void FillDataGridViewPayment()
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            mySqlCommand.CommandText = "Select * from `payment`";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            dataGridViewPayment.Rows.Clear();


            while (mySqlDataReader.Read())
            {
                int id = mySqlDataReader.GetInt32("id");
                int total = mySqlDataReader.GetInt32("total");
                int id_receipt = mySqlDataReader.GetInt32("id_receipt");

                dataGridViewPayment.Rows.Add(id, total, id_receipt);
            }
            mySqlDataReader.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAddNewPayment().Show();
        }

        private void buttonEditPayment_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;
            try
            {
                int idSelectedId = int.Parse(dataGridViewPayment.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Select* from `payment` where `id`={idSelectedId}";
                mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.HasRows == false)
                {
                    MessageBox.Show("Пожайлуста выберите оплату");
                    return;
                }
                else
                {
                    mySqlDataReader.Read();
                    Global.Payment = new Payment()
                    {
                        Id = mySqlDataReader.GetInt32("Id"),
                        Total = mySqlDataReader.GetInt32("total"),
                        Id_receipt = mySqlDataReader.GetInt32("id_receipt")

                    };
                    mySqlDataReader.Close();

                    this.Hide();
                    new FormUpdatePayment().Show();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGridViewPayment();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при загрузке данных");
                return;
            }
        }

        private void buttonDeletePayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPayment.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите адрес для удаления");
                    return;
                }
                int idAdress = int.Parse(dataGridViewPayment.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Delete from `payment` where `id`={idAdress}";
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена");
                FillDataGridViewPayment();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при удалении");
                return;
            }
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMainMenu().Show();
        }
    }
}
