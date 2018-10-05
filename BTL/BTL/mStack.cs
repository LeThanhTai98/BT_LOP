using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
	class mStack
	{
		Element qHead;
		public mStack()
		{
			qHead = null;
		}
		public void push(Element el)
		{
			if(qHead == null)
			{
				qHead = el;
			}
			else
			{
				el.Next = qHead;
				qHead = el;
			}
		}
		public int pop()
		{
			if(qHead == null)
			{
				Console.WriteLine("Stack is Empty");
				return 0;
			}
			int x = qHead.Data;
			qHead = qHead.Next;

			return x;
		}
		public void output()
		{
			Element a = qHead;
			while (a != null)
			{
				Console.Write(a.Data + " ");
				a = a.Next;
			}
			Console.WriteLine();
		}
	}
}
