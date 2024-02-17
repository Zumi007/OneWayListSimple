using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWayListSimple
{
    class OneChainList
    {
        public int data;
        public OneChainList next = null;

        public OneChainList(int value)
        {
            data = value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            OneChainList Head = null;

            OneChainList node1 = new OneChainList(10);
            Head = node1;

            OneChainList node2 = new OneChainList(20);
            node1.next = node2;

            OneChainList node3 = new OneChainList(30);
            node2.next = node3;



            OneChainList item = Head;

            while (item != null)
            {
                Console.WriteLine(item.data);
                item = item.next;
            }

            Console.ReadKey();
        }
    }
}
