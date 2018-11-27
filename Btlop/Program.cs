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
            //// truong hop 1 

            long bg = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
            vessel a = new vessel();
            int n;
            
            storage b = new storage();
            temp c = new temp();
         
            nhapfile nhap = new nhapfile();
            nhap.FileName = "demo2.txt";
            nhap.ReadData();
            if (nhap.Containers != 0)
                if (nhap.Heightyard <= nhap.Column)
                {
                  int column;
                  column = nhap.Column;
                  a.A1 = nhap.Stacks;
                  Console.WriteLine("dau vao ");
                  a.showvessel();               
                  int so_hang_ben_storage = nhap.Heightyard;
                  n = nhap.Containers / so_hang_ben_storage;
                  for (int i = 0; i <= n; i++)
                  {
                      List<double> tam = a.grab1(so_hang_ben_storage);
                      b.catching(tam);
                      b.sapxep();
                  }
                  Console.WriteLine("sap xep nhu sau");
                  long end = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
                  nhap.saveFile(b,a,c, "ketqua.txt", (end - bg) * 0.001);             
                }
                else
                {
                    int temp = nhap.Heightyard - nhap.Column + 1;
                    int column;
                    column = nhap.Column;
                    a.A1 = nhap.Stacks;
                    Console.WriteLine("dau vao ");
                    a.showvessel();
                   
                    int so_hang_ben_storage = nhap.Heightyard;
                    n = nhap.Containers / so_hang_ben_storage;
                    for (int i = 0; i <= n; i++)
                    {
                        List<double> tam = a.grab1(temp);
                        List<double> tam2 = a.grab1(nhap.Column);
                        c.printtemp(tam);
                        c.Mangtemp = tam;
                        b.catching(tam2);
                        b.sapxep2(c);
                    }
                    long end = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
                    nhap.saveFile(b, a,c, "ketqua.txt", (end - bg) * 0.001);
                }
            Console.ReadKey();
        }
    }
}
