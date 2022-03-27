using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack
    {
        Node top;
        public Stack()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node eleman = new Node(data);
            if(top == null)
            {
                top = eleman;
            }
            else
            {
                eleman.next = top;
                top = eleman;
            }
        }

        public void Pop()
        {
            top = top.next;
        }

        string mesaj;
        public string elemanlariYazdir()
        {
            mesaj = "";
            Node temp = top;
            while (temp != null) //son elemanı yazdırmaz.
            {
                mesaj += " -> " + temp.data.ToString();
                temp = temp.next;
            }
            return mesaj;
        }
    }
}
