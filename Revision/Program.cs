using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code change");
            Console.WriteLine("New feature update");
        }

        class Clovek
        {
            public int vek;
            private string jmeno;
            private string prijmeni;

            public string Jmeno { get { return jmeno; } }
            public string Prijmeni { set { prijmeni = value; } }
        }
    }
}
