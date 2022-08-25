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
    public partial class FormReceipt : Form
    {
        public FormReceipt()
        {
            InitializeComponent();
        }
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        MySqlConnection connection;
        private void FillDataGridViewReceipt()
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            mySqlCommand.CommandText = "SELECT *from receipt as r JOIN adress as a on r.id_adress=a.id join tenant as t on r.id_tenant=t.id join communal_service AS cs on r.id_service=cs.id JOIN company AS com on r.id_company= com.id";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            dataGridViewReceipt.Rows.Clear();


            while (mySqlDataReader.Read())
            {
                int id = mySqlDataReader.GetInt32(0);
                string id_service = mySqlDataReader.GetString(17);
                int count_unit = mySqlDataReader.GetInt32(2);
                string id_tenant = mySqlDataReader.GetString(14);
                string id_adress = mySqlDataReader.GetString(7);
                string home = mySqlDataReader.GetString(8);
                string flat = mySqlDataReader.GetString(9);
                string fullAdress = id_adress + " дом " + home + ", квартира " + flat;
                string id_company = mySqlDataReader.GetString(21);

                dataGridViewReceipt.Rows.Add(id, id_service, count_unit, id_tenant, fullAdress, id_company);
            }
            mySqlDataReader.Close();
        }
        private void buttonAddNewReceipt_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAddNewReceipt().Show();
        }

        private void buttonEditReceipt_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;
            try
            {
                int idSelectedId = int.Parse(dataGridViewReceipt.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Select* from `receipt` where `id`={idSelectedId}";
                mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.HasRows == false)
                {
                    MessageBox.Show("Пожайлуста выберите кватанцию");
                    return;
                }
                else
                {
                    mySqlDataReader.Read();
                    Global.Receipt = new Receipt()
                    {
                        Id = mySqlDataReader.GetInt32("Id"),
                        Id_service = mySqlDataReader.GetInt32("id_service"),
                        CountUnit = mySqlDataReader.GetInt32("count_unit"),
                        Id_tenant = mySqlDataReader.GetInt32("id_tenant"),
                        Id_adress = mySqlDataReader.GetInt32("id_adress"),
                        Id_company = mySqlDataReader.GetInt32("id_company")

                    };
                    mySqlDataReader.Close();

                    this.Hide();
                    new FormUpdateReceipt().Show();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonDeleteReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewReceipt.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите квитанцию для удаления");
                    return;
                }
                int idAdress = int.Parse(dataGridViewReceipt.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Delete from `receipt` where `id`={idAdress}";
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена");
                FillDataGridViewReceipt();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при удалении");
                return;
            }
        }

        private void FormReceipt_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGridViewReceipt();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при загрузке квитанций");
            }
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMainMenu().Show();
        }
    }
}
