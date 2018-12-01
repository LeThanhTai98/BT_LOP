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
        List<Stack<container>> A = new List<Stack<container>>();
        int num = 0;
        int ltemp = 1;
        string str1 = "";
        int tempnum = 0;
        List<container> mangtam = new List<container>();
        List<int> tam = new List<int>();

        public string Str1 { get => str1; set => str1 = value; }
        public int Num { get => num; set => num = value; }
        public int Tempnum { get => tempnum; set => tempnum = value; }

        public void catching(List<container> tam)
        {
            mangtam = new List<container>();
            mangtam = tam;
        }
        public void sapxep()
        {          
            int dem = 0;
            dem = mangtam.Count ;
            for (int i = 0; i < dem; i++)
                for (int j = 0; j < dem; j++)
                    if (mangtam[i].Sohieu > mangtam[j].Sohieu)
                    {
                        container tam2 = mangtam[i];
                        mangtam[i] = mangtam[j];
                        mangtam[j] = tam2;
                    }
            Stack<container> temp = new Stack<container>();
            for (int i = 0; i < dem; i++)
            {
                Num++;
                Str1 += "Time " + Num + ":\t" + mangtam[i].Sohieu + "\t" + "->" + "\t" + ltemp + "\r\n";
                temp.Push(mangtam[i]);               
            }
            A.Add(temp);
            ltemp++;
        }
        //public void sapxep2(temp c)
        //{

        //    int dem = 0;
        //    dem = mangtam.Count + c.Mangtemp.Count;
        //    for(int i = 0; i < c.Mangtemp.Count; i++)
        //    {
        //        mangtam.Add(c.Mangtemp[i]);
        //    }
        //    for (int i = 0; i < dem; i++)
        //        for (int j = 0; j < dem; j++)
        //            if (mangtam[i].Sohieu > mangtam[j].Sohieu)
        //            {
        //                container tam2 = mangtam[i];
        //                mangtam[i] = mangtam[j];
        //                mangtam[j] = tam2;
        //            }
        //    Stack<container> temp = new Stack<container>();
        //    num += c.Tempnum;
        //    str1 += c.Strtemp1;
        //    tempnum += c.Tempnum;
        //    for (int i = 0; i < dem; i++)
        //    {
        //        Num++;
        //        int dem2 = 0;
        //        for(int j = 0; j < c.Mangtemp.Count; j++)
        //        {
        //            if (mangtam[i] == c.Mangtemp[j]) dem2++;
        //        }
        //        if (dem2 == 0)  Str1 += "Time " + Num + ":" +"ship"+"\t"+"\t"+ mangtam[i].Sohieu + "\t" + "->" + "\t" + ltemp + "\r\n";
        //        else Str1 += "Time " + Num + ":" + "tempyard" + "\t"+ mangtam[i].Sohieu + "\t" + "->" + "\t" + ltemp + "\r\n";
        //        temp.Push(mangtam[i]);

        //    }
        //    A.Add(temp);
        //    c.Tempnum = 0;
        //    c.Strtemp1 = "";
        //    ltemp++;
        //}
        public string showstorage(nhapfile nh)
        {
            String str = "";
            int tong = 0;
            foreach (Stack<container> a in A)
            {
                if (a.Count<container>() > tong) tong = a.Count<container>();
            }
            for (int i = 1; i <= A.Count; i++)
            {
                str += "\t" + "c" + i;
               

            }
            Console.WriteLine();
            for (int i = 1; i <= nh.Heightyard; i++)
            {
                str += "\r\n" + "r" + i + "\t";
                int dem = 0;
                 foreach (Stack<container> a in A)
                {
                    if (a.Count<container>() != 0)
                    {
                        str += (a.Pop().Sohieu + "\t");
                        dem++;
                    }
                    else str += ("x" + "\t");

                }
                
                
                    
            }
            return str;
        }
        
    }
}
