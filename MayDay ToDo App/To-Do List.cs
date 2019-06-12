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
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("Server = localhost; User Id = root; Password = ''; Database = ufukdb");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public DataSet ds = new DataSet();
        List<Gebeurtenis> GebeurtenissenLijst = new List<Gebeurtenis>();
        string PCN = "";
        string currentid = "0";
        Gebeurtenis geselecteerdeGebeurtenis;
        Student Gebruiker;

        public Form1(Student gestuurdeStudent)
        {
            InitializeComponent();
            Gebruiker = gestuurdeStudent;
            PCN = gestuurdeStudent.PCN;
            LoadStudent(gestuurdeStudent);
            MessageBox.Show($"Welkom, {Gebruiker.Voornaam} {Gebruiker.Achternaam}.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestGetData();
        }

        private void TestGetData()
        {
            lbGebeurtenissen.Items.Clear();
            GebeurtenissenLijst.Clear();
            string query = $"SELECT * FROM `taken`WHERE `SPCN`='{PCN}'";
            MySqlCommand comm = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Gebeurtenis g = new Gebeurtenis();
                g.id = reader.GetValue(0).ToString();
                g.gebeurtenis = reader.GetValue(1).ToString();
                g.datum = reader.GetValue(2).ToString();
                g.einddatum = reader.GetValue(3).ToString();
                g.locatie = reader.GetValue(4).ToString();
                g.PCN = reader.GetValue(5).ToString();
                g.status = reader.GetValue(6).ToString();
                GebeurtenissenLijst.Add(g);
            }
            reader.Close();
            conn.Close();
           
            foreach (Gebeurtenis gebeurtenisindelijst in GebeurtenissenLijst)
            {
                lbGebeurtenissen.Items.Add(gebeurtenisindelijst.gebeurtenis);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            adapter = new MySqlDataAdapter("Insert into taken(gebeurtenis, datum, locatie, einddatum, SPCN) VALUES ('" + textBox1.Text + "','" + dateTimePicker1.Value + "','" + textBox2.Text + "','"+dtEindDatum.Value+ "','" + PCN + "')", conn);
            adapter.Fill(ds, "taken(gebeurtenis, datum, locatie, einddatum, SPCN) ");
            textBox1.Clear();
            TestGetData();
        }
        private void LoadStudent(Student x)
        {
            lblAchternaam.Text = $"Achternaam: {x.Achternaam}";
            lblID.Text = $"ID: {x.ID}";
            lblVoornaam.Text = $"Voornaam: {x.Voornaam}";
            lblPCN.Text = $"PCN: {x.PCN}"; 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            string status = "";

            if (rbNietBegonnen.Checked)
            {
                status = "1";
            }
           else if (rbInProgressie.Checked)
            {
                status = "2";
            }
           else if (rbKlaar.Checked)
            {
                status = "3";
            } 

            adapter = new MySqlDataAdapter("UPDATE `taken` SET `gebeurtenis` = '" + textBox1.Text + "', `datum`= '" + dateTimePicker1.Value + "',`einddatum`= '" + dtEindDatum.Value + "', `locatie`= '" + textBox2.Text + "', `status`='"+status+"' WHERE `id` = '" + currentid + "'", conn);
            adapter.Fill(ds, "taken(gebeurtenis, datum, locatie)");
            lblgDatum.Text = $"Datum: {dateTimePicker1.Value.ToString()}";
            
            textBox1.Clear();
            TestGetData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, $"Weet je zeker dat je {geselecteerdeGebeurtenis.gebeurtenis} wilt wissen?","Wissen",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            { 
                adapter = new MySqlDataAdapter("DELETE FROM `taken` WHERE id = " + currentid, conn);
                adapter.Fill(ds, "taken");
                TestGetData();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GetSelectedGebeurtenisInfo()
        {
            
            if (lbGebeurtenissen.SelectedIndex != -1) // als de index niet -1 is, dus als er IETS is geselecteerd
            {
                geselecteerdeGebeurtenis = GebeurtenissenLijst.Find(x => (x.gebeurtenis == lbGebeurtenissen.SelectedItem.ToString()));
                //lambda expressie voor, we vinden de gebeurtenis in de gebeurtenissenlijst die de zelfde naam heeft als de gebeurtenis die we hebben
                //geselecteerd in de lisbox :) -Siy
                currentid = geselecteerdeGebeurtenis.id;
                textBox1.Text = geselecteerdeGebeurtenis.gebeurtenis;

                lblGid.Text = $"ID: {geselecteerdeGebeurtenis.id}";
                lblgDatum.Text = $"Datum: {geselecteerdeGebeurtenis.datum}";
                lblGEindDatum.Text = $"EindDatum: {geselecteerdeGebeurtenis.einddatum}";
                lblGgebeurtenis.Text = $"Gebeurtenis: {geselecteerdeGebeurtenis.gebeurtenis}";
                lblgLocatie.Text = $"Locatie: {geselecteerdeGebeurtenis.locatie}";

                if (geselecteerdeGebeurtenis.status == "1")
                {
                    rbNietBegonnen.Checked = true;
                }
                else if (geselecteerdeGebeurtenis.status == "2")
                {
                    rbInProgressie.Checked = true;
                }
                else if (geselecteerdeGebeurtenis.status == "3")
                {
                    rbKlaar.Checked = true;
                }
                else
                {
                    rbNietBegonnen.Checked = false;
                    rbKlaar.Checked = false;
                    rbInProgressie.Checked = false;
                }
            }
        }
        private void lbGebeurtenissen_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSelectedGebeurtenisInfo();
        }

        private void cbFilterNietKlaar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFilterNietKlaar.Checked == true)
            {
                lbGebeurtenissen.Items.Clear();
                foreach (Gebeurtenis item in GebeurtenissenLijst)
                {
                    if (item.status != "3")
                    {
                        lbGebeurtenissen.Items.Add(item.gebeurtenis);
                    }
                }
            }
            else if(cbFilterNietKlaar.Checked == false)
            {
                lbGebeurtenissen.Items.Clear();
                foreach (Gebeurtenis item in GebeurtenissenLijst)
                { 
                        lbGebeurtenissen.Items.Add(item.gebeurtenis); 
                }
            }
        }
    }
}