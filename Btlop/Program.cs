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
        
         
            nhapfile nhap = new nhapfile();
            nhap.FileName = "demo2.txt";
            nhap.ReadData();
            if (nhap.Containers != 0)
            {
                int column;
                column = nhap.Column;
                List<Stack<int>> stackss = new List<Stack<int>>();
                a.A1 = nhap.Stacks;
                Console.WriteLine("dau vao ");
                a.showvessel();
                int so_hang_ben_storage = nhap.Heightyard;
                n = a.totalvessel(so_hang_ben_storage);
                for (int i = 0; i <= n; i++)
                {
                    List<double> tam = a.grab1(so_hang_ben_storage);
                    b.catching(tam);

                    b.sapxep();

                }
                Console.WriteLine("sap xep nhu sau");

                long end = (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;

                nhap.saveFile(b, "ketqua.txt", (end - bg) * 0.001);
                
            }
            Console.ReadKey();
        }
    }
}
