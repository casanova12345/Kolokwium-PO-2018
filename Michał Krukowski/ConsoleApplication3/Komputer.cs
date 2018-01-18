using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Komputer : Elektronika
    {
        public Komputer(string marka,int numerSeryjny,string usterka)
            :base(marka,numerSeryjny,usterka)
        {

        }
        public override string ToString()
        {
            return "Komputer" + marka + numerSeryjny + usterka;
        }
    }
}
