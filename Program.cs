using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doublelinkedlist
{
    class Node
    {
        /*Node class represents the node of doubly linked list.
         * Its consists of the information part and links to
         * it succedding and preceeding nodes
         * in terms of next and previous node.*/

        public int rollNumber;
        public string name;
        public Node next; /*points to the succeeding node*/
        public Node prev; /*points to the preceeding node*/
    }
      class DoubleLinkedList
    {
        Node START;
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode() /*Adds a new node*/
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student :");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll number of the student:");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm; /*checks if the list is empty*/
            if (START == null || rollNo <= START.rollNumber)
            {
                if ((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine("\nDuplicatr roll number not allowed");
                    return;
                }
                newnode.next = START;
                if (START != null) START.prev = newnode;
                newnode.prev = null; START = newnode;
                return;

            }
            Node previous, current;
            for (current = previous = START; current != null && rollNo >= current.rollNumber; previous = current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll number not allowed");
                    return;
                }

            }
            /*On the execution of the above for loop,prev and *current will point to those nodes between which the new node is to be inserted.*/
            if (current == null)
            {
                newnode.next = null;
                previous.next = newnode;
            }
            /*if the  nodes is to be inserted at the end of the list.*/
            if (current == null)
            {
                newnode.next = null;
                previous.next = newnode;
                return;

            }
            current.prev = newnode;
            previous.next = newnode;
        }
        /*Checks whether the specified node is present*/
        public bool Seacth(int rollNo, ref Node previous, ref Node current)
        {
            for (previous = current = START; current != null && rollNo != current.rollNumber; previous = current, current = current.next)
            { }
            /*the above for loop traverse the list.if the specified node *is found then the function return true,otherwise false.*/
            return (current != null);
        }
        public bool delNode(int rollNo) /*Deletes the specified node*/
        {
            Node previous, current;
            previous = current = null;
            if (Seacth(rollNo, ref previous, ref current) == false)
                return false;
            if(current==START) /*if the first node is to be delected*/
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true;
            }
            if (current.next==null) /*if the last node is to be delected*/
            {
                previous.next = null;
                return true;
            }
            /*if the node to be delected is in between the list then the following lines of the codes is executed*/
            previous.next = current.next;
            current.next.prev = previous;
            return true;

        }
    }
}