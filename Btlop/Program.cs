using System;
using System.Collections;
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
            nhap.FileName = "demo4.txt";
            nhap.ReadData();
            if (nhap.Containers != 0)
                if (nhap.Trung == 0)
                {                                       
                        
                        a.A1 = nhap.Stacks;
                        Console.WriteLine("dau vao ");
                        a.showvessel();
                    int x;
                    if (nhap.Heightyard > nhap.Column) x = nhap.Column;
                    else x = nhap.Heightyard;
  
                        while(a.totalvessel() != 0)
                        {   
                            List<container> tam = a.grab1(x);
                            List<container> tam1 = new List<container>() { new container() };

                            tam.Sort((z, y) => y.Sohieu.CompareTo(z.Sohieu));
                        //while (tam.Count < nhap.Heightyard && tam1.Count != 0)
                        //{
                            
                        //    tam1 = a.grabbehonM(tam[tam.Count - 1].Sohieu, nhap.Heightyard - 1 - tam.Count);
                        //    foreach(container cont in tam1)
                        //    {
                        //        Console.WriteLine(cont.Sohieu);
                        //        tam.Add(cont);
                        //    }
                        //}                     
                        //tam.Sort((z, y) => y.Sohieu.CompareTo(z.Sohieu));
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
