using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telecomando
{
    public class TV
    {
        private string produttore;
        private string modello;
        private string[] connettori;
        private bool stato;
        private int volume;
        private int canale;

        //costruttore

        public TV()
        {
            produttore = "";
            modello = "";
        }

        public TV(int ilcanale)
        {
            canale = ilcanale;
        }

        public TV(string ilmodello)
        {
            modello = ilmodello;
        }

        public TV(string ilproduttore, string ilmodello, string[] iconnettori)
        {
            produttore = ilproduttore;
            modello = ilmodello;
            connettori = iconnettori;
            stato = false;
            canale = 1;
            volume = 0;
        }

        public bool GetStato()
        {
            return stato;
        }
        public string[] GetConnettori()
        {
            return connettori;
        }
        public int GetVolume()
        {
            return volume;
        }
        public int GetCanale()
        {
            return canale;
        }
        public void SetVolume(int ilvolume)
        {
            volume = ilvolume;
        }
        public void SetCanale(int ilcanale)
        {
            canale = ilcanale;
        }
        public void SetStato(bool lostato)
        {
            stato = lostato;
        }
    }
}
