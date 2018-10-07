using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class element
    {
        int data;

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
        element next;

        internal element Next
        {
            get { return next; }
            set { next = value; }
        }
        public element (int d)
        {
            this.data = d;
            this.Next = null;
        }
    }
}
