using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btlop
{
    class vessel
    {
        List<Stack<double>> A = new List<Stack<double>>();
        int demstack = 0;
        

        public List<Stack<double>> A1 { get => A; set => A = value; }

        public void create_vessel(int soluong)
        {
            for (int i = 0; i <= soluong; i++)
                A1[i] = new Stack<double>();

        }
        public int totalvessel(int n)
        {
            int tong = 0;
            foreach (Stack<double> i in A1)
            {
                tong = tong + i.Count<double>();
            }
            tong = tong / n;
            
            return tong ;
        }
        //public void in_vessel()
        //{

        //    Random rad = new Random();
        //    for (int k = 0; k < 5; k++)
        //    {
        //        Stack<int> i = new Stack<int>();

        //        for (int j = 0; j < 5; j++)
        //        {
        //            if (k == 2 && j == 3) ;
        //            else i.Push(rad.Next(101));

        //        }
        //        A.Add(i);
        //    }
        //}


        public List<double> grab1(int n)
        {
            int k = A1.Count<Stack<double>>();
            
            List<double> tam = new List<double>();
            int dem = 0, dem2 = 0, dem3 = 0;
            while (dem < n)
            {
                
                    foreach (Stack<double> i in A1)
                {
                    if (i.Count<double>() == 0 && dem2 == demstack) demstack++;
                    if (i.Count<double>() != 0 && dem2 == demstack)
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
        public List<double> grab2(int n)
        {
            int k = A1.Count<Stack<double>>();

            List<double> tam = new List<double>();
            int dem = 0, dem2 = 0, dem3 = 0;
            while (dem < n)
            {

                foreach (Stack<double> i in A1)
                {
                    if (i.Count<double>() == 0 && dem2 == demstack) demstack++;
                    if (i.Count<double>() != 0 && dem2 == demstack)
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
            //foreach (Stack<double> i in A1)
            //{
            //    Console.WriteLine("1 :" + " ");
            //    foreach (double j in i)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}
            //for(int i = 0; i < A1.Count; i++)
            //{

            //}

        }
    }
}
