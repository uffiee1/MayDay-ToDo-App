using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace MayDay_ToDo_App
{
    public partial class InlogScherm : Form
    {
        MySqlConnection conn = new MySqlConnection("Server = localhost; User Id = root; Password = ''; Database = ufukdb");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        Student IngelogdeStudent;
        public InlogScherm()
        {
            InitializeComponent();
        }
        private void TryLogin(string username, string password)
        { 
            string query = $"SELECT * FROM `student`WHERE `PCN`='{username}' AND `wachtwoord`='{password}'";
            MySqlCommand comm = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Student s = new Student();
                s.ID = reader.GetValue(0).ToString();
                s.PCN = reader.GetValue(1).ToString();
                s.Wachtwoord = reader.GetValue(2).ToString();
                s.Voornaam = reader.GetValue(3).ToString();
                s.Achternaam = reader.GetValue(4).ToString();
                IngelogdeStudent = s;
            }
            if (IngelogdeStudent != null)
            {
                Form1 f = new Form1(IngelogdeStudent);
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Onjuiste gegevens!");
            }
            reader.Close();
            conn.Close();
 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TryLogin(tbPCN.Text, tbWachtwoord.Text);
        }
    }
}
