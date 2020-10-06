using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
    class Node
    {
        public Node Previous;
        public Node Next;
        public string Data;
        public Node (string data)
        {
            Next = null;
            Previous = null;
            Data = data; 
        }
    }
}
