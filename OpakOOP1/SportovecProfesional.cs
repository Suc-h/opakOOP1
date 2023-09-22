using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpakOOP1
{
    internal class SportovecProfesional : SportovecAmater
    {
        DateTime datumvznikuclen;
        double baz_met;
        int stupenvykonosti;
        bool jednou = false;

        public SportovecProfesional(string jmeno, int obvodPasu, int vyska, DateTime datumvznikuclen, double bazmet) : base(jmeno, obvodPasu, vyska)
        {
            this.datumvznikuclen = datumvznikuclen;
            this.baz_met = bazmet;


        }

        public int StupenVykonosti
        {
            get { return stupenvykonosti; }

            set
            {
                if (value < 1 && value > 7)
                {
                    stupenvykonosti = 0;
                }
                else
                {
                    stupenvykonosti = value;
                }
            }

        }
        private bool MaNarokNaSlevu()
        {
            TimeSpan rozdil = DateTime.Now - datumvznikuclen;
            if (rozdil.TotalDays / 365 > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int Trenuj(int hodiny)
        {
            pocethodinT = pocethodinT + hodiny;
            if (pocethodinT >= 100 && !jednou)
            {
                baz_met += baz_met * 0.1;
                jednou = true;
            }
            return base.Trenuj(hodiny);
        }

        public override string ToString()
        {
            return base.ToString() + "datum vzniku členství: " + datumvznikuclen + "  bazální metabolismus: " + baz_met + " s nárokem na slevu? " + MaNarokNaSlevu();

        }
    }
}
