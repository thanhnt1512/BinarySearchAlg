using System;

namespace ConsoleApp1
{
    class Program
    {
        static int[] arr = { 1, 3, 5, 7, 9, 11 };
        static int target = 10;
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(1,(1+arr.Length)/2, arr.Length));
        }
        static bool BinarySearch(int l,int m,int r)
        {
            if (target < arr[0] || target > arr[arr.Length - 1])
              return false;
            if (l==m)
            {
                if (target == arr[l-1] || target == arr[r-1])
                    return true;
                else
                    return false;
            }    
            if (target == arr[m-1] )
            {
                return true;
            }
            else if (target > arr[m-1])
                return BinarySearch(m + 1, (m + 1 + r) / 2, r);
            else
                return BinarySearch(l, (l+m-1) / 2, m-1);

        }
    }
}
