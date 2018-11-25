using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btlop
{
    class temp
    {
        List<int> a = new List<int>();
        public void in_temp(int i)
        {
            a.Add(i);
        }
        public List<int> out_temp()
        {
            return a;
        }
    }
}
