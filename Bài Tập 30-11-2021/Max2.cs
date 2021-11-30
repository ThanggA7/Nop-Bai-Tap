using System;

namespace LearnC_
{
    class Program
    {
        public static void Main()
        {
          int n;
          Console.Write("Mang co do dai la: ");
          n = Convert.ToInt32(Console.ReadLine());
          int [] so = new int[n];

          for (int i = 0; i < n; i++)
          {
           Console.Write("Nhap Array:");
           so[i] = Convert.ToInt32(Console.ReadLine());
          }
         foreach (int i in so)
         {
            Array.Sort(so);
         }
          Console.Write("So lon thu 2 trong mang la so :"+ so[so.Length-2]);
        } 
    }
}