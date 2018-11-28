using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btlop
{
    class temp
    {
        int tempnum = 0;
        List<double> mangtemp = new List<double>();

        public List<double> Mangtemp { get => mangtemp; set => mangtemp = value; }
        public string Strtemp { get => strtemp; set => strtemp = value; }
        public int Tempnum { get => tempnum; set => tempnum = value; }
        public string Strtemp1 { get => strtemp1; set => strtemp1 = value; }

        string strtemp1 = "";
        string strtemp = "";
        public void printtemp(List<double> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                strtemp += (a[i] + "\t");
                
                tempnum++;
                strtemp1 += ("Time " + Tempnum + ":" + "ship" + "\t" + a[i] + "\t" + "->" + "\t" + "tempyard" + "\r\n");
            }
        }
        
    }
}
