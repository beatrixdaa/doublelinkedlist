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
        public Node text;/*points to the succeeding node*/
        public Node prev;/*points to the preceeding node*/
    }
      class DoubleLinkedList
    {
        Node START;
        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode() /*Adds anew node*/
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student :");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm; /*checks if the list is empty*/
            if (START==null || rollNo <= START.rollNumber)
            {
                if ((START!= null)&&(rollNo== START.rollNumber))
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
            for(current = previous = START;current!= null && rollNo >= current.rollNumber;previous=current,current=current.next)
            {
                if (rollNo==current.rollNumber)
                {

                }
            }


        }
    }
}