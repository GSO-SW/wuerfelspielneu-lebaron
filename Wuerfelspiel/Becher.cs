using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wuerfelspiel
{
    public class Becher
    {
        private Wuerfel[] wuerfel = new Wuerfel[5];
        private int restVersuche = 3;

        public Becher(int anzahlWuerfel)
        {
          
        }

        public Wuerfel[] Wuerfel
        {
            get { return wuerfel; }
        }

        public void WuerfelSicherungUmschalten(int wuerfelNummer)
        {
            wuerfel[wuerfelNummer].SicherungUmschalten();
        }

        public void Wuerfeln()
        {
            for (int i = 0; i <= restVersuche; i++)
            {
                if (restVersuche == 0)
                {
                    throw new ArgumentOutOfRangeException("Keine Versuche mehr Ubrig");
                }
            }
        }
    }
}
