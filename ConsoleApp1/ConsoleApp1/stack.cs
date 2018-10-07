using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class stack
    {
        element head;
        element tail;
        public stack()
        {
            head = null;
            tail = null;

        }

        public void push(element e)
        {
            if (head == null)
                tail = e;
            e.Next = head;
            head = e;
        }
        public element pop()
        {
            element a;
            a = head;
            head = head.Next;
            return a;

        }
        public element printall()
        {
            element travel = head;
            while (travel != null)
            {

                Console.WriteLine(travel.Data);
                travel = travel.Next;
            }
            return null;
        }
    }
}
