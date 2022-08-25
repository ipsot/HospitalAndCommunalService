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
    public partial class UpdateAdress : Form
    {
        MySqlConnection connection;
        MySqlCommand command;

        List<Adress> adresses;
        public UpdateAdress()
        {
            InitializeComponent();
        }

        private void UpdateAdress_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"Select * from `adress` where `id`={Global.Adress.id}";
            MySqlDataReader reader = command.ExecuteReader();

            adresses = new List<Adress>();
            textBoxStreet.Text = Global.Adress.street;
            textBoxHome.Text = Global.Adress.home;
            textBoxFlat.Text = Global.Adress.flat;
            textBoxCountPeople.Text = Convert.ToString(Global.Adress.countPeople);
            textBoxSquare.Text = Convert.ToString(Global.Adress.square);

            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=housing_and_communal_services";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            command = new MySqlCommand();
            command.Connection = connection;

            command.CommandText = $"update `adress` set `street`='{ textBoxStreet.Text}',`home`='{ textBoxHome.Text}',`flat`='{ textBoxFlat.Text}',`count_people`='{textBoxCountPeople.Text}',`square`='{ textBoxSquare.Text}' where id={Global.Adress.id}";
            MySqlDataReader reader = command.ExecuteReader();

            reader.Close();

            MessageBox.Show("Данные обновленны");

            this.Hide();
            new AdressForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdressForm().Show();
        }
    }
}
