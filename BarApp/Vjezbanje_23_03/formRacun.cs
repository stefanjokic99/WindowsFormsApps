using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezbanje_23_03
{
    public partial class FormRacun : Form
    {
        public FormRacun(string ime, Image slika)
        {
            InitializeComponent();
            //Startna pozicija center Parent
            //Anchor veze za neku od ivica parent panela... 
            // za izdaj racun smo raskacili sa svih anchora i podesili da se on proteze u 3 kolone a dock nismo dirali
            this.lblImeKonobara.Text = ime;
            this.pcbSlikaKonobara.Image = slika;
            this.Text = "Račun - " + ime;
            Artikl[] stavke = { new Artikl("Coca Cola", 2.0f),
                                new Artikl("Fanta", 1.5f),
                                new Artikl("Pivo", 2.5f) };

            foreach (Artikl artikl in stavke)
            {
                listPonude.Items.Add(artikl);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            // moze takodje i if(listRacun.SelectedIndex >= 0)
            try
            {
                listRacun.Items.Add(listPonude.SelectedItem);
            }
            catch 
            {
                //nista da bi nastavio dalje raditi
            }
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                listRacun.Items.Remove(listRacun.SelectedItem);
            }
            catch
            {
                //nista da bi nastavio dalje raditi
            }
        }
        private void listPonude_MouseDoubleClick(object sender, MouseEventArgs e) 
        {
            try
            {
                listRacun.Items.Add(listPonude.SelectedItem);
            }
            catch
            {
                //nista da bi nastavio dalje raditi
            }
        }
        private void listRacun_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                listRacun.Items.Remove(listRacun.SelectedItem);
            }
            catch
            {
                //nista da bi nastavio dalje raditi
            }
        }
        private void btnIzdajRacun_Click(object sender, EventArgs e)
        {
            string racun = "Račun:\n--------------------------------------------\n";
            float cijena = 0.0f;

            foreach (Artikl artikl in listRacun.Items)
            {
                racun += artikl.ToString() + "\n";
                cijena += artikl.Cijena;
            }

            racun += "--------------------------------------------\n";
            racun += String.Format("{0,-13}\t{1,12}", "UKUPNO: ", cijena.ToString("0.#0") + "KM");
            this.DialogResult = MessageBox.Show(racun, "Račun", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
