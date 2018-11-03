using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
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
			return a; // truy cập bằng vòng lặp
		}
		public int count_temp()
		{
			return a.Count;
		}
	}
}
