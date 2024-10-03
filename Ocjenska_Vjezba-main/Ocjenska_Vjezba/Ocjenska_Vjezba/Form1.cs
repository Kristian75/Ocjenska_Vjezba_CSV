using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocjenska_Vjezba
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila = new List<Vozilo>();
        private int motociklCount = 0;
        private int automobilCount = 0;
        private int kamionCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Vozilo novoVozilo = new Vozilo
                {
                    Model = txtModel.Text,
                    GodinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text),
                    BrojKotaca = int.Parse(txtBrojKotaca.Text)
                };

                vozila.Add(novoVozilo);
                MessageBox.Show("Vozilo uneseno!");
                ClearInputs();
            }
        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            foreach (var vozilo in vozila)
            {
                if (vozilo.BrojKotaca == 2)
                {
                    vozilo.Kategorija = "Motocikl";
                    motociklCount++;
                }
                else if (vozilo.BrojKotaca == 4)
                {
                    vozilo.Kategorija = "Automobil";
                    automobilCount++;
                }
                else if (vozilo.BrojKotaca > 4)
                {
                    vozilo.Kategorija = "Kamion";
                    kamionCount++;
                }
            }
            MessageBox.Show("Podaci obrađeni!");
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            txtIspis.Clear();
            foreach (var vozilo in vozila)
            {
                txtIspis.AppendText($"Model: {vozilo.Model}\nGodina proizvodnje: {vozilo.GodinaProizvodnje}\nBroj kotača: {vozilo.BrojKotaca}\nKategorija: {vozilo.Kategorija}\n\n");
            }
            txtIspis.AppendText($"Ukupan broj vozila po kategorijama:\nMotocikl: {motociklCount}\nAutomobil: {automobilCount}\nKamion: {kamionCount}");

            string filePath = @"C:\Users\VašeKorisničkoIme\Documents\vozila.csv"; // Promijenite ovu liniju

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Model,GodinaProizvodnje,BrojKotaca,Kategorija");
                foreach (var vozilo in vozila)
                {
                    writer.WriteLine($"{vozilo.Model},{vozilo.GodinaProizvodnje},{vozilo.BrojKotaca},{vozilo.Kategorija}");
                }
            }

            MessageBox.Show($"Podaci su spremljeni u {filePath}");
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtModel.Text) || string.IsNullOrWhiteSpace(txtGodinaProizvodnje.Text) || string.IsNullOrWhiteSpace(txtBrojKotaca.Text))
            {
                MessageBox.Show("Sva polja moraju biti ispunjena!");
                return false;
            }

            if (!int.TryParse(txtGodinaProizvodnje.Text, out _) || !int.TryParse(txtBrojKotaca.Text, out _))
            {
                MessageBox.Show("Godina proizvodnje i broj kotača moraju biti brojevi!");
                return false;
            }

            int brojKotaca = int.Parse(txtBrojKotaca.Text);
            if (brojKotaca % 2 != 0)
            {
                MessageBox.Show("Broj kotača mora biti paran!");
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtModel.Clear();
            txtGodinaProizvodnje.Clear();
            txtBrojKotaca.Clear();
        }
    }
}