﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    interface ISerwis
    {
        void DodajTelewizor(string marka, int numerSeryjny, string usterka);
        void DodajKomputer(string marka, int numerSeryjny, string usterka);

        void Polacz();
        void Podziel();
        void Napraw();
        void Napraw(int napraw);
    }
}
