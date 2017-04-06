using System;

namespace ConsoleApplication{

    public class Node {
        public Node next;
        public Object data;
    }

    public class LinkedList {
        private Node head;

        public void traverseNodes(){
            Node current = head;
            while (current != null) {
                Console.WriteLine(current.data);
                current = current.next;
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

            myList1.insertNode("Phencean X");   //last node
            myList1.insertNode("Broton Z"); //mid node
            myList1.insertNode("Slashean Z");   //front node
            myList1.traverseNodes();    //iterate through all nodes

            
            Console.WriteLine();

            Console.WriteLine("Add Last:");
            LinkedList myList2 = new LinkedList();

            myList2.AddFirst("Gary");
            myList2.AddFirst("Tensue");
            myList2.AddFirst("Ean");
            myList2.traverseNodes();

            Console.ReadLine();
            
        }
    }
}
