using System;

namespace SortAlogrithms
{
    public class SortAlgorithmProgram
    {
        public void InsertionSort(int[] Array)
        {
            for(int i = 1; i< Array.Length;++i)
            {
                int key = Array[i];
                int j = i - 1;
                while(j>=0 && Array[j]>key)
                {
                    Array[j + 1] = Array[j];
                    j = j - 1;
                }
                Array[j + 1] = key;
            }
        }
        public void SelectionSort(int[] Array)
        {
            int i,j,min_index;
            for(i = 0; i < Array.Length-1; i++)
            {
                min_index = i;
                for (j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[min_index])
                    {
                        min_index = j;
                        Swap(Array[i],Array[min_index]);
                    }
                    
                }
            }
        }
        public void Partition(int[] Array, int low, int high)
        {
            int pivot = Array[high];
            int L = low - 1;
            for (int j=low;j<Array.Length - 1; j++)
            {
                if (Array[j] < pivot)
                {
                    L++;
                    Swap(Array[j], Array[L]);
                }
            }
        }
        public void Swap(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public void PrintArray(int[] Array)
        {
            for(int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + ";");
            }
        }
        public static void Main(string[] args)
        {
            SortAlgorithmProgram sortProgram = new SortAlgorithmProgram();
            int[] Array = { 5, 3, 9, 1, 6 };
            //InsertionSort
            Console.WriteLine("===InsertinSort===");
            sortProgram.InsertionSort(Array);
            sortProgram.PrintArray(Array);
            //SelectionSort
            Console.WriteLine("===SelectionSort===");
            sortProgram.SelectionSort(Array);
            sortProgram.PrintArray(Array);
        } 
    }
}
