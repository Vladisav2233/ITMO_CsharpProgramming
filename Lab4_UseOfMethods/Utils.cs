namespace Utils
{
    using System;

    class Utils
    {
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public static void Swap(ref int a, ref int b) //swap numbers
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
