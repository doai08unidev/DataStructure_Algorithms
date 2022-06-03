using System;
namespace DataStructure{
    public class SinglyLinkedList{
    Node? head; //? operator - check nullable reference type c# 8.0
    //Initialize a Node
    public class Node{
        public int data;
        public Node? next;
        public Node(int d){
            data = d;
            next = null;
        }
    }
    //Traversal emlements of LinkedList
    public void Traversal(){
        Node n = head;
        while(n!=null){
            System.Console.Write(n.data + ";");
            n = n.next;
        }
    }
    //Add new Node to the fist of LinkedList
    public void AddFirstNode(int newData){
        Node newNode = new Node(newData);
        newNode.next = head;
        head = newNode;
    }
    //Add new Node to the end of LinkedList
    public void AddEndNode(int newData){
        Node newNode = new Node(newData);
		Node n = head;
        if(head==null){
            head = new Node(newData);
        }
		while(n!=null){
			if(n.next == null){
				n.next = newNode;
                return;
			}
        	n = n.next;
		}
    }
    public static void Main(string[] args){
        SinglyLinkedList ll = new SinglyLinkedList();
        // ll.head = new Node(1);
        // Node second = new Node(2);
        // ll.head.next = second;
        // Node third = new Node(3);
        // second.next = third;
        // ll.AddFirstNode(5);
        
        // ll.AddEndNode(77);
		// ll.AddEndNode(88);
		ll.AddEndNode(99);
        ll.AddEndNode(995);
        ll.Traversal();
        

    }
}
}
