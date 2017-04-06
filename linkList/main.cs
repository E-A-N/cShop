using System;

namespace ConsoleApplication{

    public class Node {
        public Node next;
        public Object data;
    }

    public class LinkedList {
        private Node head;

        public void printAllNodes(){
            Node current = head;
            while (current != null) {
                Console.WriteLine(current.data);
            }
        }

        public void insertNode(Object data){
            Node toAdd = new Node();

            toAdd.data = data;
            toAdd.next = head;

            head = toAdd;
        }

        public void AddLast(Object data){
            if (head == null){
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else{
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = head;
                while (current.next != null){
                    current = current.next;
                }
                current.next = toAdd;
            }
        }
    }
    class Program {
        static void Main(string[] args){
            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.insertNode("Hello");   //last node
            myList1.insertNode("Magical"); //mid node
            myList1.insertNode("World");   //front node
            myList1.printAllNodes();

            /*
            Console.WriteLine();

            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();

            myList2.AddFirst("Gary");
            myList2.AddFirst("Tensue");
            myList2.AddFirst("Ean");
            myList2.printAllNodes();

            Console.ReadLine();
            */
        }
    }
}
