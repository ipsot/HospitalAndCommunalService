using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace HospitalAndCommunalService
{
    public partial class AdressForm : Form
    {
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        MySqlConnection connection;
        public AdressForm()
        {
            InitializeComponent();
        }

        private void FillDataGridViewAdress()
        {
            string connectionString= "Server = localhost; Port = 3306; User = root; Password = 1234; Database = housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            mySqlCommand.CommandText = "Select * from `adress`";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            dataGridViewAdress.Rows.Clear();


            while (mySqlDataReader.Read())
            {
                int id = mySqlDataReader.GetInt32("id");
                string street = mySqlDataReader.GetString("street");
                string home = mySqlDataReader.GetString("home");
                string flat = mySqlDataReader.GetString("flat");
                int countPeople = mySqlDataReader.GetInt32("count_people");
                int square = mySqlDataReader.GetInt32("square");

                dataGridViewAdress.Rows.Add(id, street, home, flat, countPeople, square);
            }
            mySqlDataReader.Close();
        }

        private void Adress_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGridViewAdress();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при загрузке адресов");
            }
        }

        private void buttonAddNewAdress_Click(object sender, EventArgs e)
        {
            //this.Hide();
            new FormAddNewAdress().Show();
            this.Hide();
        }

        private void buttonDeleteAdress_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAdress.SelectedRows.Count==0)
                {
                    MessageBox.Show("Выберите адрес для удаления");
                    return;
                }
                int idAdress = int.Parse(dataGridViewAdress.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Delete from `adress` where `id`={idAdress}";
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена");
                FillDataGridViewAdress();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при удалении");
                return;
            }
            //try
            //{
            //    FillDataGridViewAdress();
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ошибка загрузки записей");
            //}
            
        }

        private void buttonEditAdress_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;
            try
            {
                int idSelectedId = int.Parse(dataGridViewAdress.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Select* from `adress` where `id`={idSelectedId}";
                mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.HasRows==false)
                {
                    MessageBox.Show("Пожайлуста выберите адрес");
                    return;
                }
                else
                {
                    mySqlDataReader.Read();
                    Global.Adress = new Adress()
                    {
                        id=mySqlDataReader.GetInt32("Id"),
                        street=mySqlDataReader.GetString("Street"),
                        home=mySqlDataReader.GetString("home"),
                        flat=mySqlDataReader.GetString("flat"),
                        countPeople=mySqlDataReader.GetInt32("count_people"),
                        square=mySqlDataReader.GetInt32("square")

                    };
                    mySqlDataReader.Close();

                    this.Hide();
                    new UpdateAdress().Show();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMainMenu().Show();
        }
    }
}
