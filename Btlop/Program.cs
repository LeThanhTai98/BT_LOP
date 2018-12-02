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
            nhap.FileName = "demo1.txt";
            nhap.ReadData();
            if (nhap.Containers != 0)
                if (nhap.Trung == 0)
                {                                       
                        int column;
                        column = nhap.Column;
                        a.A1 = nhap.Stacks;
                        Console.WriteLine("dau vao ");
                        a.showvessel();
                    int x;
                    if (nhap.Heightyard > nhap.Column) x = nhap.Column;
                    else x = nhap.Heightyard;
  
                        while(a.totalvessel() != 0)
                        {   
                            List<container> tam = a.grab1(x);
                        if (tam.Count != 0)
                        {
                            b.catching(tam);
                            b.sapxep();
                        }
                        }
                        long end = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
                        nhap.saveFile(b, a, c, "ketqua.txt", (end - bg) * 0.001);                                     
                }
                else Console.WriteLine(" trung container ko xu li");
            Console.ReadKey();
        }
    }
}
