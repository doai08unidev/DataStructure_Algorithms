using System;

namespace SortAlogrithms
{
    class SortAlgorithmProgram
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
        public void PrintArray(int[] Array)
        {
            for(int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + ";");
            }
        }
        static void Main(string[] args)
        {
            SortAlgorithmProgram sortProgram = new SortAlgorithmProgram();
            int[] Array = { 5, 3, 9, 1, 6 };
            //InsertionSort
            Console.WriteLine("===InsertinSort===");
            sortProgram.InsertionSort(Array);
            sortProgram.PrintArray(Array);
        } 
    }
}
