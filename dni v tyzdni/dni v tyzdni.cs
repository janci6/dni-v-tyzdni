using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dni_v_tyzdni
{
    class dni_v_tyzdni
    {
        public static void vypisdenvtyzdni(string cislodna)
        {
            int dentyzdna = int.Parse(cislodna);

            if(zkontrolujvstup(dentyzdna))
            {
                switch (dentyzdna)
                {
                    case 7:
                    case 0: Console.WriteLine("nedela"); break;
                    case 1: Console.WriteLine("pondelok"); break;
                    case 2: Console.WriteLine("utorok"); break;
                    case 3: Console.WriteLine("streda"); break;
                    case 4: Console.WriteLine("stvrtok"); break;
                    case 5: Console.WriteLine("piatok"); break;
                    case 6: Console.WriteLine("sobota"); break;

                    default: Console.WriteLine("neznamy den"); break;
                }
            }
            else
            {
                Console.WriteLine("spatny vstup");
            }

            

            
            
        }
        
        public static void vypisdenvtyzdni(string cislodna,bool nedelajeprva)
        {
            int dentyzdna = int.Parse(cislodna);
            if (zkontrolujvstup(dentyzdna))
            {
                if (nedelajeprva)
                {
                    dentyzdna--;
                }
                vypisdenvtyzdni(dentyzdna.ToString());
            
                Console.WriteLine("spatny vstup");
            }

        }
        public static bool zkontrolujvstup(int cislodna)
        {
            return (cislodna >= 1 && cislodna <= 7);  
                                
        }
    }
}
