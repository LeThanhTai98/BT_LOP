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
			//mQueue Q = new mQueue();
			//Element A = new Element(1);
			///Element B = new Element(2);
			
			//Q.pop();
			//Element C = new Element(4);
			//Q.push(A);
			//Q.push(B);
			//Q.push(C);
			//int x = Q.pop();
			/*int x = Q.pop();
			Q.output();
			Console.WriteLine(x);*/


			mStack S = new mStack();
			Element A = new Element(1);
			Element B = new Element(2);
			S.push(A);
			S.push(B);
			//int x = S.pop();
			S.output();
			S.pop();
			S.output();
			Console.ReadKey();
		}
	}
}
