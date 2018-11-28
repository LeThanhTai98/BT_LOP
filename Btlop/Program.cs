using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btlop
{   
    class Program
    {
        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        static void Main(string[] args)
        {
            

            long bg = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
            vessel a = new vessel();
            int n;          
            storage b = new storage();
            temp c = new temp();       
            nhapfile nhap = new nhapfile();
            nhap.FileName = "demo2.txt";
            nhap.ReadData();
            if (nhap.Containers != 0)
                if (nhap.Trung == 0)
                {
                    if (nhap.Heightyard <= nhap.Column-1)
                    {
                        //// truong hop 1 2 
                        int column;
                        column = nhap.Column;
                        a.A1 = nhap.Stacks;
                        Console.WriteLine("dau vao ");
                        a.showvessel();                       
                        n = nhap.Containers / nhap.Heightyard;
                        for (int i = 0; i <= n; i++)
                        {
                            List<container> tam = a.grab1(nhap.Heightyard);
                            b.catching(tam);
                            b.sapxep();
                        }
                        long end = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
                        nhap.saveFile(b, a, c, "ketqua.txt", (end - bg) * 0.001);
                    }
                    else
                    {
                        /// truong hop 3
                        Console.WriteLine("truong hop 2");
                        int temp = nhap.Heightyard - nhap.Column + 1;                      
                        a.A1 = nhap.Stacks;
                        Console.WriteLine("dau vao ");
                        a.showvessel();
                        n = nhap.Containers / nhap.Heightyard;
                        for (int i = 0; i <= n; i++)
                        {
                            List<container> tam = a.grab1(temp);
                            List<container> tam2 = a.grab1(nhap.Column-1);
                            c.printtemp(tam);
                            c.Mangtemp = tam;
                            b.catching(tam2);                           
                            b.sapxep2(c);
                        }
                        long end = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
                        nhap.saveFile(b, a, c, "ketqua.txt", (end - bg) * 0.001);
                    }
                }
                else Console.WriteLine(" trung container ko xu li");
            Console.ReadKey();
        }
    }
}
