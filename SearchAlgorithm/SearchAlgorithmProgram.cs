using System;

namespace SearchAlgorithm
{
    public class SearchAlgorithmProgram
    {
        public int LinearSearch(int[] Array, int x)
        {
            int n = Array.Length;
            for(int i=0; i<n; i++)
            {
                if(Array[i] == x)
                {
                    return i;
                }
            }
            return -1;
            
        }
        public int BinarySearchRecursion(int[] Array, int x, int left, int right)
        {
            int mid = (left + right) / 2;
            if (left <= right)
            {
                if (x == Array[mid])
                {
                    return mid;
                }
                if (x > Array[mid])
                {
                    return BinarySearchRecursion(Array, x, mid + 1, right);
                }
                if (x < Array[mid])
                {
                    return BinarySearchRecursion(Array, x, left, mid - 1);
                }
            }
            return -1;
        }
        public int BinarySearchIterator(int[] Array, int x, int left, int right)
        {
            
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (x==Array[mid])
                {
                    return mid;
                }
                else if (x>Array[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
                
            };
            return -1;

        }
        public static void Main(string[] args)
        {
            SearchAlgorithmProgram searchProgram = new SearchAlgorithmProgram();
            int[] Array = { 1, 3, 5, 6, 7, 9 }; //array
            int x = 7; //number need to find

            //Linear Search
            Console.WriteLine("===LinearSearch===");
            int linearSearchResult = searchProgram.LinearSearch(Array,x);
            if (linearSearchResult == -1)
            {
                Console.WriteLine("khong tim thay");
            }
            else
            {
                Console.WriteLine("Da tim thay {0} o vi tri {1}",x,(linearSearchResult +1));
            }

            //BinarySearch (Recursion)
            Console.WriteLine("===BinarySearch(Recursion)===");
            int binarySearchRecursion = searchProgram.BinarySearchRecursion(Array, x, 0, Array.Length - 1);
            if(binarySearchRecursion == -1)
            {
                Console.WriteLine("Khong tim thay");
            }
            else
            {
                Console.WriteLine("Da tim thay {0} o vi tri {1}",x, (binarySearchRecursion + 1));
            }

            //BinarySearch (Iterator)
            Console.WriteLine("===BinarySearch(Iterator)===");
            int binarySearchIterator = searchProgram.BinarySearchIterator(Array, x, 0, Array.Length - 1);
            if (binarySearchIterator == -1)
            {
                Console.WriteLine("Khong tim thay");
            }
            else
            {
                Console.WriteLine("Da tim thay {0} o vi tri {1}",x,(binarySearchIterator + 1));
            }
            Console.Read();
        }

    }
}

