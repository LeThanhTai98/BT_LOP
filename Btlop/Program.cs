using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btlop
{
    class Program
    {
        static void Main(string[] args)
        {
            //// truong hop 1 
            vessel a = new vessel();
            int n = 5, dem = 0;

            storage b = new storage();
            Random rad = new Random();
            a.in_vessel();

            Console.WriteLine("dau vao ");
            a.showvessel();
            int so_hang_ben_storage = 3;
            n = a.totalvessel(so_hang_ben_storage);
            for (int i = 0; i <= n; i++)
            {
                List<int> tam = a.grab(so_hang_ben_storage);
                b.catching(tam);
                
                b.sapxep();
              
            }
            Console.WriteLine("sap xep nhu sau");
            b.showstorage();
            Console.ReadKey();
        }
    }
}
