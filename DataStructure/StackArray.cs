using System;
namespace DataStructure{
    class StackArray{
        private int[] ele;
        private int top;
        private int max;
        public StackArray(int size){
            ele = new int[size];
            top = -1;
            max = size;
        }
        public void Push(int item){
            if(top == max - 1){
                System.Console.WriteLine("Stack overflow");
                return;
              
            }else{
                ele[++top] = item;            
            }
        }
        public void printStack(){
            if(top==-1){
                System.Console.WriteLine("Stack is Empty");
            }else{
                for(int i =0;i<=top;i++){
                    System.Console.WriteLine("{0} pushed into stack", ele[i]);
                }
            }
        }
        public static void Main(string[] args){
            StackArray stack = new StackArray(5);
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);
            stack.Push(60);
            stack.Push(70);
            stack.printStack();
            Console.WriteLine(stack.top);

        }
    }
}
