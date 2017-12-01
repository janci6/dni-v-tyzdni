using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dni_v_tyzdni
{
    class pole
    {
        public int[] vnutornepole = new int[4] { 10, 33, 5, 9 };
        public void vypispole()
        {

            for (int i = 0; i < vnutornepole.Length; i++)
            {
                Console.WriteLine(vnutornepole[i]);
            }
        }
        public void naplnpole()
        {
            Random r = new Random();
            for (int i = 0; i < vnutornepole.Length; i++)
            {
                vnutornepole[i] = r.Next(100);
            }
        }
    }
}
