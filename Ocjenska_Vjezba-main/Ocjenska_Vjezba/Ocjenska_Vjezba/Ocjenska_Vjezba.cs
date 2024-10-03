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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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

                txtModel.Clear();
                txtGodinaProizvodnje.Clear();
                txtBrojKotaca.Clear();
                txtModel.Focus();

                DialogResult upit = MessageBox.Show("Želite li unjeti još podataka?", "Upit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (upit)
                {
                    case DialogResult.Yes:
                        {
                            vozila.Add(novoVozilo);
                            break;
                        }

                    case DialogResult.No:
                        {
                            txtModel.Enabled = false;
                            txtGodinaProizvodnje.Enabled = false;
                            txtBrojKotaca.Enabled = false;
                            vozila.Add(novoVozilo);
                            break;
                        }
                }
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
                txtIspis.AppendText($"Model: {vozilo.Model}{Environment.NewLine}Godina proizvodnje: {vozilo.GodinaProizvodnje}{Environment.NewLine}Broj kotača: {vozilo.BrojKotaca}{Environment.NewLine}Kategorija: {vozilo.Kategorija}{Environment.NewLine}{Environment.NewLine}");
            }
            txtIspis.AppendText($"Ukupan broj vozila po kategorijama:{Environment.NewLine}Motocikl: {motociklCount}{Environment.NewLine}Automobil: {automobilCount}{Environment.NewLine}Kamion: {kamionCount}");
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

        private void btnSpremi_Click_1(object sender, EventArgs e)
        {
            string putanjaDatoteke = "C:\\Users\\Ucenik\\Documents\\VozilaCSV";

            try
            {
                using (StreamWriter sw = new StreamWriter(putanjaDatoteke))
                {
                    sw.WriteLine("Model  GodinaProizvodnje  BrojKotaca  Kategorija");

                    foreach (Vozilo vozilo in vozila)
                    {
                        sw.WriteLine($"{vozilo.Model},{vozilo.GodinaProizvodnje},{vozilo.BrojKotaca},{vozilo.Kategorija}");
                    }
                }

                MessageBox.Show("Podatci su uspiješno spremljeni u CSV datoteku!", "Uspijeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške prilikom spremanja podataka: " + ex.Message,
                    "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

