using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
	class Element
	{
		int data;
		Element next;

		// Constructor
		public Element(int mData)
		{
			this.data = mData;
		}
		
		public int Data
		{
			get { return data; }
			set { data = value; }
		}
		internal Element Next
		{
			get { return next; }
			set { next = value; }
		}
	}
}
