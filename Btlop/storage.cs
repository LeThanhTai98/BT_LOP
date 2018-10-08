using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btlop
{
    class storage

    {
        Stack<int> A = new Stack<int>();
        int[] mangtam = new int [99];
         List<int> tam = new List<int>();
        public void catching (List<int> tam)
        {
            mangtam = tam.ToArray();
        }
        public void sapxep()
        {
            int dem = 0;
            while (mangtam[dem] != 0)
            {
                dem++;
            }
            for(int i=0;i<dem;i++)
                for (int j = 0; j < dem; j++)
                    if (mangtam[i] > mangtam[j])
                    {
                        int tam2 = mangtam[i];
                        mangtam[i] = mangtam[j];
                        mangtam[j] = tam2;
                    }

            for (int i = 0; i < dem; i++)
                A.Push(mangtam[i]);
        }
    }
}
