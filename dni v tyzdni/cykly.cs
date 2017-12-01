using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dni_v_tyzdni
{
    class cykly
    {
        public static void cykluswhile()
        {
            int i =0;
            while ( i < 4 )
            {
                Console.WriteLine("ahoj");
                i++;
            }
        }
        public static void Dowhile()
        {
            int i = 0;
            do
            {
                i++;
                Console.WriteLine(i);
                
            }
            while (i <= 4);
        }
        public static void cyklusfor()
        {
            for (int i = 0,j = 10; i <= j; i++,j--)// i++ znamena i = i+1
            {
                Console.WriteLine("dvojice : {0},{1}",i,j);
            }
            
        }
        public static void cyklusparameter(int j)
        {
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("vypis");
                if (i == 7) break;
            }
        }
        public static void cyklusforcontinue()
        {
            for(int i = 0; i <= 10; i++)
            {
                int zbytok = i % 2;
                if (zbytok != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        public static void hodnotvsreference()
        {
            int hodnota1 = 6;
            int hodnota2;
            hodnota2 = hodnota1;
            hodnota2++;
            Console.WriteLine(hodnota1);
            Console.WriteLine(hodnota2);

            auto auto1 = new auto();
            auto1.farba = "cervena";
            auto auto2 = auto1;
            auto2.farba = "cierna";

            Console.WriteLine(auto1.farba);
            Console.WriteLine(auto2.farba);

        }
        public static void prefarbiauto(auto auto)
        {
            auto.farba = "biela";
        }
        public static void zvysojednotku(ref int a)
        {
            a++;
        }
        public static bool otoc(bool vstup, out int b)
        {
            b = 10;
            return !vstup;
        }

    }
}
