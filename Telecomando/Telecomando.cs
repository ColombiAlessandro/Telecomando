using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecomando
{
    public class Telecomando
    {
        private string produttore;
        private string modello;
        private string modalitaFunz;
        private int volume;
        private int canale;
        private bool onOff;
        public Telecomando(string produttoreImp, string modelloImp, string modalitaFunzImp)
        {
            produttore = produttoreImp;
            modello = modelloImp;
            modalitaFunz = modalitaFunzImp;
            volume = 0;
        }
        public Telecomando(string produttoreImp, string modelloImp, string modalitaFunzImp, int volumeImp, int canaleImp, bool statoImp)
        {
            produttore = produttoreImp;
            modello = modelloImp;
            modalitaFunz = modalitaFunzImp;
            volume = volumeImp;
            canale = canaleImp;
            onOff = statoImp;
        }
        public Telecomando()
        {

        }
        public void SetVolume(int ilvolume)
        {
            volume = ilvolume;
        }

        public void AbbassaVolume()
        {
            volume--;
        }
        public void AlzaVolume()
        {
            volume++;
        }
        public void SetCanale(int nuovoCanale)
        {
            canale = nuovoCanale;
        } 
        public void Accendi()
        {
            onOff = true;
        }
        public void Spegni()
        {
            onOff = false;
        }
        public int GetCanale()
        {
            return canale;
        }
        public int GetVolume()
        {
            return volume;
        }
        public bool GetStato()
        {
            return onOff;
        }
    }
}
