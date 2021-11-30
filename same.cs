using System;

namespace Learn_C
{
    class Program
    {
        public static void Main()
        {

            int[] arr1 = new int[100];
            int i, j, n, b = 0; //day la bien dem

            Console.Write("Do dai mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu:", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        b++;
                        break;
                    }
                }
            }

            Console.Write("\nSo phan tu giong nhau trong mang la: {0}\n\n", b);        

            Console.ReadKey();
        } 
    }
}