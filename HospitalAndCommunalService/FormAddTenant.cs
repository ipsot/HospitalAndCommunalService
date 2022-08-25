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
    public partial class FormAddTenant : Form
    {
        public FormAddTenant()
        {
            InitializeComponent();
        }
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;
        private void buttonAddTenant_Click(object sender, EventArgs e)
        {
            //try
            //{
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;



                if (textBoxName.Text == null || textBoxSecondName.Text == null || textBoxPatronymic.Text == null)
                {
                    MessageBox.Show("Пожайлуста заполните все поля");
                    return;
                }

                //int idGenre = ((Genres)(comboBoxGenre.SelectedItem)).Id;

                mySqlCommand.CommandText = $"insert into `tenant` (`id`,`firstname`,`secondname`,`patronymic`) values (0,'{textBoxName.Text}','{textBoxSecondName.Text}','{textBoxPatronymic.Text}')";
                mySqlCommand.ExecuteNonQuery();


                this.Hide();
                new FormTenant().Show();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Ошибка при добавлении");
            //}
        }

        private void buttonCancelTenant_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormTenant().Show();
        }
    }
}
