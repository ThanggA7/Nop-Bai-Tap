using System;

namespace LEARN_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int nam;
            Console.Write("Nhap vao nam ban muon kiem tra:");
            nam = Convert.ToInt32(Console.ReadLine());
            if (nam % 4 == 0 && nam % 100 != 0){
                Console.WriteLine("Nam " + nam + " ban nhap vao la nam nhuan.");
            } else{
                Console.WriteLine("Nam ban nhap vao la nam khong nhuan.");
            }
        }
    }
}
