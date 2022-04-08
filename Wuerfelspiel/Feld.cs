using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuerfelspiel
{
    public class Feld
    {
        private int augenzahl;
        private int wert;
        private Wuerfel[] wuerfel = new Wuerfel[5];

        public Feld(int AugenZahl)
        {
            this.augenzahl = AugenZahl;
        }

        public int AugenZahl
        {
            get { return augenzahl; }
        }

        public int Wert
        {
            get { return wert; }
        }

        public Wuerfel[] Wuerfel
        {
            get { return wuerfel; }
        }       
    }
}