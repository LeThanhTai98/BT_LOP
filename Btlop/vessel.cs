using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btlop
{
    class vessel
    {   
        Stack<int> [] A = new Stack<int> [99] ;
        public void create_vessel (int soluong)
        {
            for(int i=0;i<=soluong;i++)
                A[i] = new Stack<int>();

        }
        public void in_vessel(int vitri, int giatri)
        {
             
            A[vitri].Push(giatri);

        }
        public List<int> grab()
        {
            int i = 0;
            List<int> tam = new List<int>();
            while (A[i].Count != 0) 
            {               
                tam.Insert(i, A[i].Pop());
                i++;
            }
            return tam ;
        }
        public void showvessel()
        { int dem = 0;
            while (A[dem] != null) {
                int[] tam = new int[99];
                tam = A[dem].ToArray();
                int j = 0;
                foreach ( int i in tam)
                { Console.Write(tam[j] + " ");
                    j++;
                };
                Console.WriteLine();
                dem++;
                    } 
        }
        
    }
}
