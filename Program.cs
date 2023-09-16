using System;

namespace donguler_for_loop{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Sayıyı giriniz :");
            int number1 = int.Parse(Console.ReadLine());
            for (int i = 1; i < number1 ; i++)
            {
                if(i%2 != 0)
                    Console.WriteLine(i);
            }
            int tektoplam = 0;
            int çifttoplam =0;
            for (int i = 0; i <= 1000; i++)
            {
                if(i % 2 == 1)
                    tektoplam +=i;
                else
                    çifttoplam +=i;
            }
            Console.WriteLine("Tek toplam = "+ tektoplam);
            Console.WriteLine("Çift toplam = "+ çifttoplam); 
        }
    }
}