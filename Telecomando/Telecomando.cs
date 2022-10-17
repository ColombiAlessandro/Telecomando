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
        private TV televisore;
        public Telecomando(string produttoreImp, string modelloImp, string modalitaFunzImp)
        {
            produttore = produttoreImp;
            modello = modelloImp;
            modalitaFunz = modalitaFunzImp;
            
        }
        public Telecomando(string produttoreImp, string modelloImp, string modalitaFunzImp, TV iltelevisore)
        {
            produttore = produttoreImp;
            modello = modelloImp;
            modalitaFunz = modalitaFunzImp;
            SetTV(iltelevisore);
        }

        public Telecomando()
        {

        }
        public void SetTV(TV iltelevisore)
        {
            televisore= iltelevisore;
        }
        public void SetVolume(int ilvolume)
        {
            if (televisore != null)
                televisore.SetVolume(ilvolume);
        }

        public void AbbassaVolume()
        {
            if (televisore != null) 
                televisore.SetVolume(televisore.GetVolume() - 1);
        }
        public void AlzaVolume()
        {
            if (televisore != null)
                televisore.SetVolume(televisore.GetVolume() + 1);
        }
        public void SetCanale(int nuovoCanale)
        {
            if (televisore != null)
                televisore.SetCanale(nuovoCanale);
        } 
        public void Accendi()
        {
            if (televisore != null)
                televisore.SetStato(true);
        }
        public void Spegni()
        {
            if (televisore != null)
                televisore.SetStato(false);
        }
       
    }
}
