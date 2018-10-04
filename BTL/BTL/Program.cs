using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
	class Program
	{
		static void Main(string[] args)
		{
			mQueue Q = new mQueue();
			Element A = new Element(1);
			//Element B = new Element(2);
			//Element C = new Element(4);
			Q.push(A);
			//Q.push(B);
			//Q.push(C);

			var x = Q.pop();
			Q.output();
			Console.WriteLine(x);
			Console.ReadKey();
		}
	}
}
