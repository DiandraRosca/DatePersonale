using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatePersonale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.Match(txtNume.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Va rog completati cu un Nume corespunzator");
                txtNume.Clear();
                return;
            }
        }

        private void txtPrenume_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(txtPrenume.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Va rog completati cu un Nume corespunzator");
                txtPrenume.Clear();
                return;
            }
        }

        private void txtVarsta_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtVarsta.Text, @"^[0-9]*$") || (txtVarsta.Text.Length > 2))
            {

                MessageBox.Show("Scrieti o varsta valida");
                txtVarsta.Text = txtVarsta.Text.Remove(txtVarsta.Text.Length - 1);

            }
        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(txtSerie.Text, "^[A-Z]*$").Success || (txtSerie.Text.Length > 2))
            {
                MessageBox.Show("Va rog completati cu o serie corespunzatoare");
                txtSerie.Clear();
                return;
            }


        }

        private void txtNumar_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNumar.Text, @"^[0-9]*$") || (txtNumar.Text.Length > 6))
            {

                MessageBox.Show("Scrieti o serie valida");
                txtNumar.Text = txtNumar.Text.Remove(txtNumar.Text.Length - 1);

            }
        }

        private void btntrimite_Click(object sender, EventArgs e)
        {
            if ((txtNume.Text == "") || (txtPrenume.Text == "") || (txtVarsta.Text == "") || (txtAdresa.Text == "") || (txtDepartament.Text == "")  || (txtNumar.Text == "") || (txtSerie.Text == "") || (txtLocDeMunca.Text == ""))
            {
                MessageBox.Show("Nu ati completat toate campurile");
                // Environment.Exit(0);
            }

            string adaugare = "Nume: " + txtNume.Text;
            listBox2.Items.Add(adaugare);
            string prenume = "Prenume: " + txtPrenume.Text;
            listBox2.Items.Add(prenume);
            string varsta = "Varsta: " + txtVarsta.Text;
            listBox2.Items.Add(varsta);
            string numeLoc = "Nume loc de munca: " + txtLocDeMunca.Text;
            listBox2.Items.Add(numeLoc);
            string DepLoc = "Deparatamentul locului de munca: " + txtDepartament.Text;
            listBox2.Items.Add(DepLoc);
            string Adresa = "Adresa: " + txtAdresa.Text;
            listBox2.Items.Add(Adresa);
            string Serie = "Serie: " + txtSerie.Text + " Nr serie: " + txtNumar.Text;
            listBox2.Items.Add(Serie);


        }
    }
}
