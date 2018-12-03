using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btlop
{
    class vessel
    {
        List<Stack<container>> A = new List<Stack<container>>();
        int demstack = 0;
        string str = "";
        
        
        public string Str { get => str; set => str = value; }
        internal List<Stack<container>> A1 { get => A; set => A = value; }

        public void create_vessel(int soluong)
        {
            for (int i = 0; i <= soluong; i++)
                A1[i] = new Stack<container>();

        }
       
        public int totalvessel()
        {
            int tong = 0;
            foreach (Stack<container> i in A1)
            {
                tong = tong + i.Count<container>();
            }
           

            return tong;
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

        public List<container> grab1(int n)
        {
            int thu = 0;
            int k = A1.Count<Stack<container>>(); 
            List<container> tam = new List<container>();
            int dem = 0, dem2 = 0, dem3 = 0;
            while (dem < n)
            {
                
                    foreach (Stack<container> i in A1)
                { 
                    if (i.Count<container>() == 0 && dem2 == demstack) demstack++;
                    if (i.Count<container>() != 0 && dem2 == demstack)
                    {
                        tam.Add(i.Pop());
                        dem++; demstack++;
                        if (demstack >= k)
                        {
                          
                            break;
                        }
                    }
                    if (dem == n) break;
                    dem2++;
                    if (demstack == 0) dem2 = 0;                   
                }
                if (demstack >= k)
                {
                    demstack = 0;
                    break;
                }
                if (dem2 > n) break;
                if (dem3 > n) break;
                dem3++;
            }

            return tam;
        }
        public List<container> grab2(int n , nhapfile nh)
        {
            int[] mangdem = new int[A1.Count];
            int hangthu = 0;
            int k = A1.Count;
            List<container> tam = new List<container>();
            int dem = 0, dem2 = 0, dem3 = 0;
            while (dem < n)
            {
               for (int l=0; l<A.Count;l++)
                {
                    if (A1[l].Count<container>() == 0 && l == demstack) demstack++;
                    else if (A1[l].Count<container>() != 0 && l == demstack && mangdem[l] == 0)
                    {
                        tam.Add(A1[l].Pop());
                        dem++; demstack++;
                        if (demstack >= k)
                        {
                            demstack = 0;
                            hangthu++;
                        }
                        if (hangthu > 2) break;
                        mangdem[l] = 1;
                    }
                    else if (A1[l].Count<container>() != 0 && l == demstack)
                    {
                        demstack++;
                        if (demstack >= k)
                        {
                            demstack = 0;
                            hangthu++;
                        }
                        if (hangthu > 2) break;
                    }
                    if (dem == n) break;
                    
                    
                }
                if (demstack >= k)
                {
                    demstack = 0;
                    hangthu++;
                }
                if (hangthu > 2) {
                    
                    break; }
               
                //if (dem2 > n) {
                //    Console.WriteLine("ngung 2");
                //    break; }
                if (dem > n) ;
                
                
            }
            foreach (int i in mangdem)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            //Console.WriteLine(hangthu);
            //Console.WriteLine("dem la " + dem);
            //Console.WriteLine("dem 2 la " + dem2);
            return tam;
        }
        //public List<container> grabbehonM(int m,int n)
        //{
        //    int k = A1.Count<Stack<container>>();
        //    List<container> tam = new List<container>();
        //    int dem = 0, dem2 = 0, dem3 = 0, demstack1 = 0;
        //    while (dem < n)
        //    {

        //        foreach (Stack<container> i in A1)
        //        {
        //            if (i.Count<container>() == 0 ) demstack1++;
        //            if (i.Count<container>() != 0  && i.Peek().Sohieu < m)
        //            {
        //                tam.Add(i.Pop());
        //                dem++; demstack1++;
        //                if (demstack1 >= k) break;
        //            }
        //            if (dem == n) break;
        //            dem2++;
        //            if (demstack1 == 0) dem2 = 0;
        //        }
        //        if (demstack1 >= k)
        //        {
        //            demstack1 = 0;
        //            break;
        //        }
        //        if (dem2 > n) break;
        //        if (dem3 > n) break;
        //        dem3++;
        //    }

        //    return tam;
        //}
        public void showvessel()
        {
            int k = 0;
            foreach (Stack<container> i in A1)
            {
                k++;
                Str += ("\r\n" +"c" + k + "\t");
                
                foreach (container j in i)
                {

                    Str += (j.Sohieu + "\t");
                }

                
            }


        }

    }
}
