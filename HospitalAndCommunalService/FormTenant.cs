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
    public partial class FormTenant : Form
    {
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        MySqlConnection connection;
        public FormTenant()
        {
            InitializeComponent();
        }

        private void FillDataGridView()
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            mySqlCommand.CommandText = "Select * from `tenant`";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            dataGridViewTenant.Rows.Clear();


            while (mySqlDataReader.Read())
            {
                int id = mySqlDataReader.GetInt32("id");
                string firstName = mySqlDataReader.GetString("firstname");
                string secondName = mySqlDataReader.GetString("secondname");
                string patronymic = mySqlDataReader.GetString("patronymic");

                dataGridViewTenant.Rows.Add(id, firstName, secondName, patronymic);
            }
            mySqlDataReader.Close();
        }
        private void FormTenant_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при загрузке адресов");
            }
        }

        private void buttonAddNewTenant_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAddTenant().Show();
        }

        private void buttonEditTenant_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            try
            {
                int idSelectedId = int.Parse(dataGridViewTenant.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Select* from `tenant` where `id`={idSelectedId}";
                mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.HasRows == false)
                {
                    MessageBox.Show("Пожайлуста выберите адрес");
                    return;
                }
                else
                {
                    mySqlDataReader.Read();
                    Global.Tenant = new Tenant()
                    {
                        Id = mySqlDataReader.GetInt32("Id"),
                        FirstName = mySqlDataReader.GetString("firstname"),
                        SecondName = mySqlDataReader.GetString("secondname"),
                        Patronymic = mySqlDataReader.GetString("patronymic"),
                    };
                    mySqlDataReader.Close();

                    this.Hide();
                    new FormUpdateTenant().Show();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void buttonDeleteTenant_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewTenant.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите жителя для удаления");
                    return;
                }
                int idTenant = int.Parse(dataGridViewTenant.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Delete from `tenant` where `id`={idTenant}";
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена");
                FillDataGridView();
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
