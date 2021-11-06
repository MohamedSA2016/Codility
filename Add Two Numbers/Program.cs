using System;
using System.Collections.Generic;

namespace Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            // creating first list
            list.head1 = new ListNode(7);
            list.head1.next = new ListNode(5);
            list.head1.next.next = new ListNode(9);
            list.head1.next.next.next = new ListNode(4);
            list.head1.next.next.next.next = new ListNode(6);
            Console.Write("First List is ");
            list.printList(list.head1);

            // creating second list
            list.head2 = new ListNode(8);
            list.head2.next = new ListNode(4);
            Console.Write("Second List is ");
            list.printList(list.head2);

            // add the two lists and see the result
            ListNode rs = list.addTwoLists(list.head1, list.head2);
            Console.Write("Resultant List is ");
            list.printList(rs);
            Console.WriteLine("Hello World!");
        }
    }
}
