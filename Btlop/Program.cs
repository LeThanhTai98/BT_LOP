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
            for (int i=0; i < n; i++)
                for(int j=0;j<n;j++)
            {
                    a.in_vessel(i,dem++ );
            }
            List<int> tam = a.grab();
            foreach ( int i in tam)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
