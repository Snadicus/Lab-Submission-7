using System;

namespace TestDLLSort
{
    public static class Sorter
    {
        public static void TestSort(int[] a, int length)
        {
            if (a == null)
                throw new ArgumentNullException(nameof(a));

            if (length < 0 || length > a.Length)
                throw new ArgumentOutOfRangeException(nameof(length));

            Array.Sort(a, 0, length);
        }
    }
}