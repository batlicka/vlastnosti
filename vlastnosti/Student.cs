using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlastnosti
{
    class Student
    {
        public string Jmeno { get;  set; }
        public bool Muz { get; set; }
        public bool Plnolety { get;  set; }
        private int vek;
        public int Vek
        {
            get
            {
                return vek;
            }
            set
            {
                vek = value;
                // kontrola plnoletosti
                Plnolety = true;
                if (vek < 18)
                    Plnolety = false;
            }
        }

        public Student(string jmeno, bool pohlavi, int vek)
        {
            EditujStudenta(jmeno, pohlavi, vek);
        }

        public void EditujStudenta(string jmeno, bool pohlavi, int vek)
        {
            Jmeno = jmeno;
            Muz = pohlavi;
            Vek = vek;
        }

        public override string ToString()
        {
            string jsemPlnolety = "jsem";
            if (!Plnolety)
                jsemPlnolety = "nejsem";
            string pohlavi = "muž";
            if (!Muz)
                pohlavi = "žena";
            return String.Format("Jsem {0}, {1}. Je mi {2} let a {3} plnoletý.", Jmeno, pohlavi, Vek, jsemPlnolety);
        }
    }
}
