using System;
public class LinkedList{
	Node head;
    public class Node{
        public int data;
        public Node next;
        public Node(int d){
            data = d;
            next = null;
        }

    }
    public void TraversalLinkedList(){
        Node n = head;
        while(n!=null){
            System.Console.Write(n.data + ";");
            n = n.next;
        }
    }
    public static void Main(string[] args){
        LinkedList linkedlist = new LinkedList();
        linkedlist.head = new Node(1);
        Node second = new Node(2);
        Node third = new Node(3);
        linkedlist.head.next = second;
        second.next = third;
        linkedlist.TraversalLinkedList();
    }

}