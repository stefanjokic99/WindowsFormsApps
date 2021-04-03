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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            this.btnClear.Enabled = false;
            this.KeyPreview = true;
            //tbPin.PasswordChar = '*';
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void click(object sender, EventArgs e)
        {
            if (tbPin.Text.Length < 8)
            {
                Button dugme = (Button)sender;
                
                tbPin.AppendText(dugme.Text);
            }

            // Vraca se fokus na TB jer ako unosimo misem fokus nam ostaje na button u 
            tbPin.Focus();
            tbPin.DeselectAll();
        }
        private void tbPin_TextChanged(object sender, EventArgs e)
        {
            btnClear.Enabled = tbPin.Text.Length > 0;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPin.Clear();
        }
        /*
         * Metoda koja ograničava tastere sa tastature 
         * nece ocitati neke druge
         */
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                foreach (Control kontrola in tableLayoutPanel1.Controls)
                {
                    if (kontrola is Button)
                    {
                        Button taster = kontrola as Button;

                        if (taster.Text == e.KeyChar.ToString())
                        {
                            taster.PerformClick();
                        }
                    }
                }
            }
            e.Handled = true;
        }

        /*
         * za tastere na tastaturi koji nemaju keyCode  
         */
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                if (tbPin.Text.Length > 0)
                {
                    tbPin.Text = tbPin.Text.Remove(tbPin.Text.Length - 1);
                }
            }
            else
            {
                foreach (Control kontrola in tableLayoutPanel1.Controls)
                {
                    Button taster = kontrola as Button;

                    if (e.KeyCode == Keys.Delete)
                    {
                        if (taster.Text == "Clear")
                        {
                            taster.PerformClick();
                        }
                    }
                    if (e.KeyCode == Keys.Enter)
                    {
                        if (taster.Text == "Enter")
                        {
                            taster.PerformClick();
                        }
                    }
                }
            }
            e.Handled = true;
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbPin.Text == "1234")
            {
                // Da nam ne bi ostao pin kada se vratimo u ovu formu 
                // neka vrsta zastite pin a
                tbPin.Clear();
                this.Hide();
                FormRacun formaRacun = new FormRacun("Petar Petrović", Properties.Resources.konobar);
                formaRacun.ShowDialog();
                this.Show();
            }
            else if (tbPin.Text == "4321")
            {
                tbPin.Clear();
                this.Hide();
                FormRacun formaRacun = new FormRacun("Ivana Ivanović", Properties.Resources.konobarica);
                formaRacun.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Pogrešan PIN kod!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbPin.Focus();
            tbPin.DeselectAll();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
