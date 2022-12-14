using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telecomando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Telecomando telecomando;
        TV televisore;
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] iconnettori = { "HDMI", "VGA", "SATA" };
            televisore = new TV("Samsung", "CP300", iconnettori);
            telecomando = new Telecomando("Samsung", "IC500", "Infrarossi", televisore);
            aggiornaCanale();
            aggiornaStato();
            aggiornaVolume();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            telecomando.Accendi();
            aggiornaStato();
            aggiornaCanale();
            aggiornaVolume();
        }

        private void off_Click(object sender, EventArgs e)
        {
            telecomando.Spegni();
            aggiornaStato();
            telecomando.SetCanale(1);
            telecomando.SetVolume(0);
            volumeBox.Text = string.Empty;
            canaleBox.Text = string.Empty;
        }

        private void canale1_Click(object sender, EventArgs e)
        {
            if (televisore.GetStato())
            {
                telecomando.SetCanale(1);
                aggiornaCanale();
            }
        }

        private void canale2_Click(object sender, EventArgs e)
        {
            if (televisore.GetStato())
            {
                telecomando.SetCanale(2);
                aggiornaCanale();
            }
        }

        private void canale3_Click(object sender, EventArgs e)
        {
            if (televisore.GetStato())
            {
                telecomando.SetCanale(3);
                aggiornaCanale();
            }
        }

        private void canale4_Click(object sender, EventArgs e)
        {
            if (televisore.GetStato())
            {
                telecomando.SetCanale(4);
                aggiornaCanale();
            }
        }

        private void canale5_Click(object sender, EventArgs e)
        {
            if (televisore.GetStato())
            {
                telecomando.SetCanale(5);
                aggiornaCanale();
            }
        }

        private void canale6_Click(object sender, EventArgs e)
        {
            if (televisore.GetStato())
            {
                telecomando.SetCanale(6);
                aggiornaCanale();
            }
        }

        private void canale7_Click(object sender, EventArgs e)
        {
            if (televisore.GetStato())
            {
                telecomando.SetCanale(7);
                aggiornaCanale();
            }
        }

        private void canale8_Click(object sender, EventArgs e)
        {
            if (televisore.GetStato())
            {
                telecomando.SetCanale(8);
                aggiornaCanale();
            }
        }

        private void canale9_Click(object sender, EventArgs e)
        {
            if (televisore.GetStato())
            {
                telecomando.SetCanale(9);
                aggiornaCanale();
            }
        }

        private void alzaVolume_Click(object sender, EventArgs e)
        {
            if (televisore.GetStato())
            {
                if (televisore.GetVolume() < 99)
                {
                    telecomando.AlzaVolume();
                    aggiornaVolume();
                }
            }
        }

        private void abbassaVolume_Click(object sender, EventArgs e)
        {
            if (televisore.GetStato())
            {
                if (televisore.GetVolume() != 0)
                {
                    telecomando.AbbassaVolume();
                    aggiornaVolume();
                }
            }
        }
        private void aggiornaCanale()
        {
            canaleBox.Text = televisore.GetCanale().ToString();
        }
        private void aggiornaVolume()
        {
            volumeBox.Text = televisore.GetVolume().ToString();
        }
        private void aggiornaStato()
        {
            statoBox.Text = televisore.GetStato().ToString();
        }
    }
}
