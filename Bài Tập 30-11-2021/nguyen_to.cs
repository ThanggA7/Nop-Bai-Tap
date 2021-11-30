using System;

namespace LEARN_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int so;
            Console.Write("Nhap vao nam ban muon kiem tra:");
            so = Convert.ToInt32(Console.ReadLine());
            if (so % 2 != 0 && so % 3 != 0) 
            {
                Console.WriteLine("So ban nhap la so nguyen to.");
            }
            else {
                Console.WriteLine("So ban nhap khong phai la so nguyen to.");
            }
        }
    }
}
