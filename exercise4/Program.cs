using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4
{
    class node
    {
        public int info;
        public node next;
        public node(int i, node n)
        {
            info = i;
            next = n;
        }
    }

    class stack
    {
        node top;
        public stack()
        {
            top = null;
        }

    }
}