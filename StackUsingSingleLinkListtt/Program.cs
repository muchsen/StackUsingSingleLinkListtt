using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingSingleLinkList
{
    class node
    {
        public int info;
        public node text;
        public node(int i, node n)
        {
            info = i;
            nrxt = n;
        }
    }
}