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
            int n = 3,dem=0;
            a.create_vessel(n);
            storage b = new storage();
            Random rad = new Random();

            for (int i=0; i < n; i++)
                for(int j=0;j<n;j++)
            {
                    a.in_vessel(i,  rad.Next(101));
            }
            Console.WriteLine("dau vao ");
            a.showvessel();
            for (int i = 0; i < n; i++)
            {
                List<int> tam = a.grab();
                b.catching(tam);
                b.sapxep();
            }
            Console.WriteLine("sap xep nhu sau");
            b.showstorage();
            Console.ReadKey();
        }
    }
}
