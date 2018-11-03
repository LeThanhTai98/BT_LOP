using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btlop
{
    class vessel
    {
        List<Stack<int>> A = new List<Stack<int>>();
        int demstack = 0;
        //public void create_vessel (int soluong)
        //{
        //    for(int i=0;i<=soluong;i++)
        //        A[i] = new Stack<int>();

        //}
        public int totalvessel(int n)
        {
            int tong = 0;
            foreach (Stack<int> i in A)
            {
                tong = tong + i.Count<int>();
            }
            tong = tong / n;
            
            return tong ;
        }
        public void in_vessel()
        {

            Random rad = new Random();
            for (int k = 0; k < 5; k++)
            {
                Stack<int> i = new Stack<int>();

                for (int j = 0; j < 5; j++)
                {
                    if (k == 2 && j == 3) ;
                    else i.Push(rad.Next(101));

                }
                A.Add(i);
            }
        }


        public List<int> grab(int n)
        {
            int k = A.Count<Stack<int>>();
            
            List<int> tam = new List<int>();
            int dem = 0, dem2 = 0, dem3 = 0;
            while (dem < n)
            {
                
                    foreach (Stack<int> i in A)
                {
                    if (i.Count<int>() == 0 && dem2 == demstack) demstack++;
                    if (i.Count<int>() != 0 && dem2 == demstack)
                    {
                        tam.Add(i.Pop());
                        dem++; demstack++;
                        if (demstack >= k) demstack = 0;
                    }
                    if (dem == n) break;
                    dem2++;
                    if (demstack == 0) dem2 = 0;
                    
                }
                if (dem2 > n) break;
                if (dem3 > n) break;
                dem3++;
            }

            return tam;
        }
        public void showvessel()
        {
            foreach (Stack<int> i in A)
            {
                Console.WriteLine("1 :" + " ");
                foreach (int j in i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
