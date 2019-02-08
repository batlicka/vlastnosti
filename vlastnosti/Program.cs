using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vlastnosti
{
    public class Bod
    {
        private short m_x;
        private short m_y;
        public Bod() { m_x = m_y = 0; }
        public Bod (short nx, short ny) { m_x = nx; m_y = ny; }
        public short x
        {
            get { return m_x; }
            set
            {
                if (value < 0)
                    m_x = 0;
                else
                    m_x = value;
            }
        }
        public short y
        {
            get { return m_y; }
            set
            {
                if (value < 0)
                    m_y = 0;
                else
                    m_y = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //příklad z knihy
            Bod b = new Bod();
            b.x = 1;
            b.y = 2;
            Console.WriteLine("x={0}, y={1}", b.x, b.y);

            //příklad z internetu
            Student s = new Student("Pavel Hora", true, 20);
            s.Vek = 15;
            s.Jmeno = "Vasek Vagunda";            
            // s.Muz = false; // tento řádek nyní způsobí chybu a musí být odebrán
            Console.WriteLine(s);

        }
    }
}
