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
    public partial class FormAddNewService : Form
    {
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;
        public FormAddNewService()
        {
            InitializeComponent();
        }

        private void buttonAddNewService_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;



                if (textBoxName.Text == null || textBoxPriceForUnit.Text == null || textBoxUnit.Text == null)
                {
                    MessageBox.Show("Пожайлуста заполните все поля");
                    return;
                }

                //int idGenre = ((Genres)(comboBoxGenre.SelectedItem)).Id;

                mySqlCommand.CommandText = $"insert into `communal_service` (`id`,`name`,`unit`,`price_for_unit`) values (0,'{textBoxName.Text}','{textBoxUnit.Text}','{textBoxPriceForUnit.Text}')";
                mySqlCommand.ExecuteNonQuery();


                this.Hide();
                new CommunalService().Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CommunalService().Show();
        }
    }
}
