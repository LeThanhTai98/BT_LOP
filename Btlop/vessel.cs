using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btlop
{
    class vessel
    {   
        Stack<int>[] A = new Stack<int> [99] ;
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
        
    }
}
