using System;

namespace Data_Structures___Algorithms
{
    public static class Util
    {
        private readonly static Random _random = new Random();
        public static int[] GenerateRandonNumberArray(int count = 10)
        {
            var arr = new int[count];
            for (int i = 0; i < count - 1; i++)
            {
                arr.SetValue(GetRandomNumner(0, 100), i);
            }

            return arr;
        }

        private static int GetRandomNumner(int rangeFrom, int rangeTo)
        {
            return _random.Next(rangeFrom, rangeTo);
        }
    }
}