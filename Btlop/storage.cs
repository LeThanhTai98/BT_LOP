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
        List<Stack<double>> A = new List<Stack<double>>();
        int num = 0;
        int ltemp = 1;
        string str1 = "";
        int tempnum = 0;
        List<double> mangtam = new List<double>();
        List<int> tam = new List<int>();

        public string Str1 { get => str1; set => str1 = value; }
        public int Num { get => num; set => num = value; }
        public int Tempnum { get => tempnum; set => tempnum = value; }

        public void catching(List<double> tam)
        {
            mangtam = tam;
        }
        public void sapxep()
        {
            
            int dem = 0;
            dem = mangtam.Count<double>() ;
            for (int i = 0; i < dem; i++)
                for (int j = 0; j < dem; j++)
                    if (mangtam[i] > mangtam[j])
                    {
                        double tam2 = mangtam[i];
                        mangtam[i] = mangtam[j];
                        mangtam[j] = tam2;
                    }
            Stack<double> temp = new Stack<double>();
            for (int i = 0; i < dem; i++)
            {
                Num++;
                Str1 += "Time " + Num + ":\t" + mangtam[i] + "\t" + "->" + "\t" + ltemp + "\r\n";
                temp.Push(mangtam[i]);
               
                
            }
            A.Add(temp);
            ltemp++;
        }
        public void sapxep2(temp c)
        {

            int dem = 0;
            dem = mangtam.Count + c.Mangtemp.Count;
            for(int i = 0; i < c.Mangtemp.Count; i++)
            {
                mangtam.Add(c.Mangtemp[i]);
            }
            for (int i = 0; i < dem; i++)
                for (int j = 0; j < dem; j++)
                    if (mangtam[i] > mangtam[j])
                    {
                        double tam2 = mangtam[i];
                        mangtam[i] = mangtam[j];
                        mangtam[j] = tam2;
                    }
            Stack<double> temp = new Stack<double>();
            num += c.Tempnum;
            str1 += c.Strtemp1;
            tempnum += c.Tempnum;
            for (int i = 0; i < dem; i++)
            {
                Num++;
                int dem2 = 0;
                for(int j = 0; j < c.Mangtemp.Count; j++)
                {
                    if (mangtam[i] == c.Mangtemp[j]) dem2++;
                }
                if (dem2 == 0)  Str1 += "Time " + Num + ":" +"ship"+"\t"+"\t"+ mangtam[i] + "\t" + "->" + "\t" + ltemp + "\r\n";
                else Str1 += "Time " + Num + ":" + "tempyard" + "\t"+ mangtam[i] + "\t" + "->" + "\t" + ltemp + "\r\n";
                temp.Push(mangtam[i]);

            }
            A.Add(temp);
            c.Tempnum = 0;
            c.Strtemp1 = "";
            ltemp++;
        }
        public string showstorage()
        {
            String str = "";
            int tong = 0;
            foreach (Stack<double> a in A)
            {
                if (a.Count<double>() > tong) tong = a.Count<double>();
            }
            for (int i = 1; i <= A.Count; i++)
            {
                str += "\t" + "c" + i;
               

            }
            Console.WriteLine();
            for (int i = 1; i <= tong; i++)
            {
                str += "\r\n" + "r" + i + "\t";
                int dem = 0;
                 foreach (Stack<double> a in A)
                {
                    if (a.Count<double>() != 0)
                    {
                        str += (a.Pop() + "\t");
                        dem++;
                    }
                    
                }
                while (dem < A.Count)
                {
                    str += ("x" + "\t");
                    dem++;
                }
                
                    
            }
            return str;
        }
        
    }
}
