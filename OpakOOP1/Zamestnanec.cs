using System;
using System.Linq;
using System.Windows.Forms;

namespace OpakOOP1
{
    internal class Zamestnanec
    {
        private string titul;
        private string jmeno;
        private string pozice;
        private int mplat;
        private DateTime dndp;
        private int bonus;
        private int hodiny;
        private int relaxaccka;

        public Zamestnanec(string titul, string jmeno, int mplat, DateTime dndp)
        {
            this.Titul = titul;
            this.Jmeno = jmeno;
            this.mplat = mplat;
            this.dndp = dndp;
            this.pozice = "Zamestnanec";
            this.bonus = 0;
            this.hodiny = 0;
        }

        private string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                jmeno = value;
                string[] a = jmeno.Split(' ');
                string jmenoo = a[0];
                string prijmeni = a[1];
                string b = jmenoo.First().ToString();
                jmenoo.Replace(jmenoo.First(), Convert.ToChar(b.ToUpper()));
                prijmeni.ToUpper();
                jmeno = jmenoo + " " + prijmeni;
            }
        }

        private string Titul
        {
            get
            {
                return titul;
            }
            set
            {
                titul = value;
                titul.Trim();
                string a = titul.First().ToString();
                titul.Replace(titul.First(), Convert.ToChar(a.ToUpper()));
                titul = titul + ".";
            }
        }

        public int rocnipPlat(int plat)
        {
            mplat = plat;
            return 12 * mplat;
        }

        public int pocetMesicu()
        {
            TimeSpan dnes = DateTime.Now - dndp;
            return (dnes.Days / 30);
        }

        public int celkem()
        {
            int castka = pocetMesicu() * mplat;
            return castka;
        }

        public void zvysOsobni(int castka)
        {
            bonus += castka;
            if (bonus > 10000)
            {
                MessageBox.Show("Zaměstnanec je vedoucím!");
                pozice = "Vedoucí";
            }
        }

        public void odpracHod(int hodina)
        {

            if (hodiny >= 100)
            {
                MessageBox.Show("Musíš relaxovat!");
            }
            else
            {
                hodiny = hodiny + hodina;
            }

        }

        public void relaxace(int relaxaceH)
        {
            relaxaccka = relaxaccka + relaxaceH;
            if (relaxaccka >= 72)
            {
                relaxaccka = 0;
                hodiny = 0;
            }
        }

        public override string ToString()
        {
            return titul + " " + jmeno + " " + "Plat:" + mplat + "kč Celkem: " + celkem() + "kč Bonus: " + bonus + "kč Roční plat: " + rocnipPlat(mplat) + "kč hodiny: " + hodiny + " Je: " + pozice; ;
        }
    }
}