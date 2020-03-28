using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOfReadLineFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
                
            string ad,soyad,gozRengi,oynadiginOyun;
            Console.WriteLine("Lutfen Ad,Soyad,Goz Renginizi ve Oynadiginiz Oyunu Sirasiyla Yazin.");
            ad = Console.ReadLine();
            soyad = Console.ReadLine();
            gozRengi = Console.ReadLine();
            oynadiginOyun = Console.ReadLine();
            Console.WriteLine("AD : " + ad);
            Console.WriteLine("Soyad : " + soyad);
            Console.WriteLine("Goz Rengi : " + gozRengi);
            Console.WriteLine("Oynadigin Oyun : " + oynadiginOyun);
            Console.WriteLine("Kimliğiniz bulundu siz Peysersiniz : " + ad + " bey");
            Console.ReadKey();

        }
    }
}
