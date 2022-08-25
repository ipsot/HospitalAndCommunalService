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
    public partial class FormAddNewCompany : Form
    {
        public FormAddNewCompany()
        {
            InitializeComponent();
        }
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;

        private void FormAddNewCompany_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;



                if (textBoxCompanyName.Text == null )
                {
                    MessageBox.Show("Пожайлуста заполните все поля");
                    return;
                }

                //int idGenre = ((Genres)(comboBoxGenre.SelectedItem)).Id;

                mySqlCommand.CommandText = $"insert into `company` (`id`,`name`) values (0,'{textBoxCompanyName.Text}')";
                mySqlCommand.ExecuteNonQuery();


                this.Hide();
                new CompanyForm().Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CompanyForm().Show();
        }
    }
}
