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
        List<container> mangtemp = new List<container>();

       
        public string Strtemp { get => strtemp; set => strtemp = value; }
        public int Tempnum { get => tempnum; set => tempnum = value; }
        public string Strtemp1 { get => strtemp1; set => strtemp1 = value; }
        internal List<container> Mangtemp { get => mangtemp; set => mangtemp = value; }

        string strtemp1 = "";
        string strtemp = "";
        public void printtemp(List<container> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                strtemp += (a[i].Sohieu + "\t");
                
                tempnum++;
                strtemp1 += ("Time " + Tempnum + ":" + "ship" + "\t" + a[i].Sohieu + "\t" + "->" + "\t" + "tempyard" + "\r\n");
            }
        }
        
    }
}
