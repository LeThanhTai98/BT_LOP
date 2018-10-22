using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btlop
{
    class storage

    {
        //Stack<int> [] A= new Stack<int>[99];
        List<Stack<int>> A = new List<Stack<int>>();
        int[] mangtam = new int [99];
         List<int> tam = new List<int>();
        public void catching (List<int> tam)
        {
            mangtam = tam.ToArray();
        }
        public void sapxep()
        {
            int dem = 0;
            dem = mangtam.Count<int>();
            for(int i=0;i<dem;i++)
                for (int j = 0; j < dem; j++)
                    if (mangtam[i] > mangtam[j])
                    {
                        int tam2 = mangtam[i];
                        mangtam[i] = mangtam[j];
                        mangtam[j] = tam2;
                    }
            Stack<int> temp = new Stack<int>();
            for (int i = 0; i < dem; i++)
                temp.Push(mangtam[i]);
            A.Add(temp);
        }
        public void showstorage()
        {
            foreach (Stack <int> a in A)
            {
                while ( a.Count != 0)
                {
                    Console.WriteLine(a.Pop());
                }
            }
        }
    }
}
