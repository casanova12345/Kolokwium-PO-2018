using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Serwis : ISerwis
    {
        private List<Elektronika> doNaprawy;
        private List<Komputer> komputery;


        public Serwis()
        {

        }
        
        public void DodajTelewizor(string marka,int numerSeryjny,string usterka)
        {
            doNaprawy.Add(new Telewizor(marka, numerSeryjny, usterka));

        }
        public void DodajKomputer(string marka,int numerSeryjny,string usterka)
        {
            komputery.Add(new Komputer(marka, numerSeryjny, usterka));
        }
        public override string ToString()
        {
             string opis = "";
            opis += "Telewizor: " + Environment.NewLine;
            opis += "Komputer: " + Environment.NewLine;

            foreach(var element in doNaprawy)
            {
                opis += element.ToString() + Environment.NewLine;
            }
            return opis;
           

        }
        public void Polacz()
        {
            doNaprawy.AddRange(komputery);
        }
        public void Podziel()
        {
           doNaprawy.RemoveRange(2,2);
        }
        public void Napraw()
        {
             doNaprawy.RemoveAt(0);

        }
        public void  Napraw(int napraw)
        {

        }

    }
}
