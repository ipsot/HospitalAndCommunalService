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
    public partial class FormAddNewAdress : Form
    {
        public FormAddNewAdress()
        {
            InitializeComponent();
        }

        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;
        private void FormAddNewAdress_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddNewAdress_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;



                if (textBoxCountPeopleInAddAdress.Text == null || textBoxFlatInAddAdress.Text == null || textBoxHomeInAddAdress.Text == null || textBoxSquareInAddAdress.Text == null || textBoxStreetInAddAdress.Text==null)
                {
                    MessageBox.Show("Пожайлуста заполните все поля");
                    return;
                }

                string sumAdress = textBoxStreetInAddAdress.Text +" "+ textBoxFlatInAddAdress.Text + " "+ textBoxHomeInAddAdress.Text;

                //int idGenre = ((Genres)(comboBoxGenre.SelectedItem)).Id;

                mySqlCommand.CommandText = $"insert into `adress` (`id`,`street`,`home`,`flat`,`count_people`,`square`) values (0,'{textBoxStreetInAddAdress.Text}','{textBoxHomeInAddAdress.Text}','{textBoxFlatInAddAdress.Text}','{textBoxCountPeopleInAddAdress.Text}',{textBoxSquareInAddAdress.Text})";
                mySqlCommand.ExecuteNonQuery();


                this.Hide();
                new AdressForm().Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void buttonCancelNewAdress_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdressForm().Show();
        }
    }
}
