﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dni_v_tyzdni
{
    class Program
    {
        static void Main(string[] args)
        {
            //dni_v_tyzdni.vypisdenvtyzdni("1");
            // dni_v_tyzdni.vypisdenvtyzdni("1",true);

            //cykly.cykluswhile();

            //cykly.Dowhile();

            //cykly.cyklusfor();

            //cykly.cyklusparameter(6);

            //cykly.cyklusforcontinue();



            // int  apovodne = 10;
            //  cykly.zvysojednotku(ref apovodne);
            //Console.WriteLine(apovodne);

            pole p = new pole();

            
            p.naplnpole();
            p.vypispole();
            Console.ReadLine();
        }
    }
}
