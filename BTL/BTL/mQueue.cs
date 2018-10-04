using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
	class mQueue
	{
		Element qHead;
		Element qTail;

		public mQueue()
		{
			qHead = qTail = null;
		}
		public void push(Element el)
		{
			if(qHead == null)
			{
				qHead = qTail = el;
			}
			else
			{
				qTail.Next = el;
				qTail = el;
			}
		}
		public int pop()
		{
			int x = qHead.Data;
			qHead = qHead.Next;
			if(qHead == null)
			{
				qTail = null;
			}
			return x;
		}
		public void output()
		{
			Element a = qHead;
			while(a != null)
			{
				Console.Write(a.Data + " ");
				a = a.Next;
			}
		}
	}
}
