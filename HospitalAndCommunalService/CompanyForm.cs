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
    public partial class CompanyForm : Form
    {
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        MySqlConnection connection;
        public CompanyForm()
        {
            InitializeComponent();
        }
        private void FillDataGridViewCompany()
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            mySqlCommand.CommandText = "Select * from `company`";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            dataGridViewCompany.Rows.Clear();


            while (mySqlDataReader.Read())
            {
                int id = mySqlDataReader.GetInt32("id");
                string name = mySqlDataReader.GetString("name");

                dataGridViewCompany.Rows.Add(id, name);
            }
            mySqlDataReader.Close();
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGridViewCompany();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при загрузке компаний");
            }
        }

        private void buttonAddCompany_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAddNewCompany().Show();
        }

        private void buttonEditCompany_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;
            //try
            //{
            int idSelectedId = int.Parse(dataGridViewCompany.SelectedRows[0].Cells[0].Value.ToString());

            mySqlCommand.CommandText = $"Select* from `company` where `id`={idSelectedId}";
            mySqlDataReader = mySqlCommand.ExecuteReader();
            if (mySqlDataReader.HasRows == false)
            {
                MessageBox.Show("Пожайлуста выберите компанию");
                return;
            }
            else
            {
                mySqlDataReader.Read();
                Global.Company = new Company()
                {
                    Id = mySqlDataReader.GetInt32("Id"),
                    Name = mySqlDataReader.GetString("name")
                };
                mySqlDataReader.Close();

                this.Hide();
                new FormUpdateCompany().Show();
            }
        }

        private void buttonDeleteCompany_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCompany.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите адрес для удаления");
                    return;
                }
                int idCompany = int.Parse(dataGridViewCompany.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Delete from `company` where `id`={idCompany}";
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена");
                FillDataGridViewCompany();
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
