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
    public partial class CommunalService : Form
    {
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        MySqlConnection connection;

        public CommunalService()
        {
            InitializeComponent();
        }
        private void FillDataGridViewCommunalService()
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            mySqlCommand.CommandText = "Select * from `communal_service`";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            dataGridViewCommunalService.Rows.Clear();


            while (mySqlDataReader.Read())
            {
                int id = mySqlDataReader.GetInt32("id");
                string name = mySqlDataReader.GetString("name");
                string unit = mySqlDataReader.GetString("unit");
                string priceForUnit = mySqlDataReader.GetString("price_for_unit");

                dataGridViewCommunalService.Rows.Add(id, name, unit, priceForUnit);
            }
            mySqlDataReader.Close();
        }

        private void buttonAddNewService_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAddNewService().Show();
        }

        private void CommunalService_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            FillDataGridViewCommunalService();

        }

        private void buttonEditService_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;
            try
            {
                int idSelectedId = int.Parse(dataGridViewCommunalService.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Select* from `communal_service` where `id`={idSelectedId}";
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                if (reader.HasRows == false)
                {
                    MessageBox.Show("Пожайлуста выберите услугу");
                    return;
                }
                else
                {
                    reader.Read();
                    Global.Service = new Service()
                    {
                        Id = reader.GetInt32("Id"),
                        Name = reader.GetString("Name"),
                        Unit = reader.GetString("Unit"),
                        Price = reader.GetInt32("price_for_unit"),

                    };
                    reader.Close();

                    this.Hide();
                    new FormUpdateService().Show();
                }
            }
            catch
            {
                MessageBox.Show("Выберите читателя");
                return;
            }
        }

        private void buttonDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCommunalService.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите услугу для удаления");
                    return;
                }
                int idService = int.Parse(dataGridViewCommunalService.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Delete from `communal_service` where `id`={idService}";
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена");
                FillDataGridViewCommunalService();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при удалении");
                return;
            }
            //try
            //{
            //    FillDataGridViewCommunalService();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ошибка загрузки записей");
            //}
        }
    }
}
