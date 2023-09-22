using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace OpakOOP1
{
    internal class SportovecAmater
    {
        protected string jmeno;
        protected int pocethodinT = 0;
        protected int obvodPasu;
        protected int vyska;

        public SportovecAmater(string jmeno, int obvodPasu, int vyska)
        {
            this.jmeno = jmeno;
            this.obvodPasu = obvodPasu;
            this.vyska = vyska;
        }

        private int ObvodPasu
        {

            get
            {
                return obvodPasu;
            }
            set
            {

                obvodPasu = value;
            }

        }
        private int Vyska
        {

            get
            {
                return vyska;
            }
            set
            {
                if(value < 100) {
                    value = value * 100;
                }
                else
                {


                }
                if(value<0)
                {
                   vyska = 1;
                }
                else
                {
                    vyska = value;
                }
            }


        }


       private double WHtR()
        {
            return (obvodPasu / vyska);
        }
        public virtual int Trenuj(int hodiny)
        {
           return pocethodinT = +hodiny;

        }

        private bool JeObezni()
        {
            if(WHtR()> 0.5778)
            {
                return true;

            }
            else { return false; }
        }
        public override string ToString()
        {
            return "Sportovec: " + jmeno + " s odtrenovanými hodinami: " + pocethodinT + " s výškou a obvodem pasu: " + vyska + "cm " + obvodPasu +"cm s WHtR: "+WHtR()+" S obezitou? " + JeObezni()+"! ";
        }
        //možnost if je obezni změnit true na ano / ne atd.
    }
}
