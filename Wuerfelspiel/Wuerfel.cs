using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int anzahlSeiten = 6;
        private int letztesErgebniss;
        private bool gesichert = false;
        Random rnd;

        public Wuerfel(int AnzahlSeiten)
        {
            this.anzahlSeiten = AnzahlSeiten;
        }

        public Wuerfel()
        {

        }

        public int Wurfeln()
        {
            letztesErgebniss = rnd.Next(0, AnzahlSeiten + 1); ;
            return rnd.Next(0, AnzahlSeiten + 1);
        }

        public void SicherungUmschalten()
        {
            if (gesichert == false)
            {
                gesichert = true;
            }
            if (gesichert == true)
            {
                gesichert = false;
            }
            else
            {
                gesichert = false;
            }
        }

        public int AnzahlSeiten
        {
            get
            {
                return anzahlSeiten;
            }
        }

        public int LetztesErgebniss
        {
            get
            {
                return rnd.Next(0, AnzahlSeiten + 1);
            }
        }

        public bool Gesichert
        {
            get
            {
                return gesichert;
            }

            set
            {
                Gesichert = gesichert;
            }
        }
    }
}