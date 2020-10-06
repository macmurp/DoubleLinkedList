using System;
using System.Collections.Generic;
using System.Text;

namespace DLL
{
    class LinkedList
    {
        private Node head;
        private Node tail;

        public Node Add(string data)
        {
            if (head == null)
            {
                //add head if none exists
                head = new Node(data);
                tail = head;
                return head;
            }
            else
            {
                Node current = head;
                while (current != null)
                {
                    Node next = current.Next;

                    if (next.Next == null)
                    {
                        //add to end
                        //add to tail.Next will always add on the end
                        tail.Next = new Node(data);
                        tail = tail.Next;
                        return tail;
                    }
                    
                    if (current.Data.CompareTo(data) > 0)
                    {
                        //avoids bug if needing to add before head in sorting
                        Node temp = new Node(data);
                        temp.Next = head;
                        head = temp;
                        return temp;
                    }

                    if (current.Data.CompareTo(data) < 0 && next.Data.CompareTo(data) >=0)
                    {
                        //sorts list by entered info
                        //if current data is before (less than) the entered data, and
                        //next's data is after or the same (greater than or equal to) the entered data, then
                        //insert entered data in between
                        current.Next = new Node(data);
                        current.Next.Next = next;
                        return current.Next;
                    }
                }
            }
            return null;
        }

        public bool Remove(string data)
        {
            // if head is null, exit
            // search for the node to remove
            // if found, remove and return true; else false
            return false;
        }

        public Node Print()
        {
            return null;
        }

        public Node Search(string data)
        {
            // search for node by data;
            // return reference to first node found; else null node
            return null;

        }


    }
}
