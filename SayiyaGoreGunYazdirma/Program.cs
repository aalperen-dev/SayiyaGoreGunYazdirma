using System;

namespace SayiyaGoreGunYazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden 1 ve 7 arasında bir sayı isteyen, girilen sayı sırasındaki
            //haftanın gününü veren C# konsol uygulamasının kodları
            //switch-case yapısını kullanarak aşağıdaki boşluğa yazın.

            Console.Write("1 ile 7 arasında bir sayı girin : ");
            int sayi = int.Parse(Console.ReadLine());
            string gun = "";
            //string turunden tanımlanmıs değişkeni null'dan çıkarttım.
            switch (sayi)
            {
                case 1:
                    gun = "Pazartesi";
                    break;
                case 2:
                    gun = "Salı";
                    break;
                case 3:
                    gun = "Çarşamba";
                    break;
                case 4:
                    gun = "Perşembe";
                    break;
                case 5:
                    gun = "Cuma";
                    break;
                case 6:
                    gun = "Cumartesi";
                    break;
                case 7:
                    gun = "Pazar";
                    break;
                default:
                    Console.WriteLine("Yanlış değer girdiniz!");
                    break;
            }
            if (sayi > 0 && sayi < 8)
            {
                Console.WriteLine("Haftanın " + sayi + ". günü : " + gun);
            }

        }
    }
}
