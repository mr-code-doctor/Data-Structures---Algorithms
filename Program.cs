using System;

namespace Data_Structures___Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DS_Array arr = new DS_Array(Util.GenerateRandonNumberArray(20));

            arr.Search(5);
        }
    }
}
