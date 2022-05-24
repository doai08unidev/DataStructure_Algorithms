using System;

namespace SearchAlgorithm
{
    class SearchAlgorithmProgram
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
        static void Main(string[] args)
        {
            SearchAlgorithmProgram searchProgram = new SearchAlgorithmProgram();
            int[] Array = { 1, 3, 5, 6, 7, 9 };
            int x = 7;
            Console.WriteLine("Tim thay"searchProgram.LinearSearch(Array,x);
        }

    }
}

