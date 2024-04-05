using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEx2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================== Homework 1 (a) ===============");
            int PriceIphone = 1000;
            double ProcentSells = 10;

            double LastPriceIphone = (ProcentSells / 100) * PriceIphone;

            Console.WriteLine($"Цiна Айфону: {PriceIphone}");
            Console.WriteLine($"Знижка: {ProcentSells}");
            Console.WriteLine($"Велечина знижки: {LastPriceIphone}");


            Console.WriteLine("================ Homework 2 (b) ================");

            int Hour = 1;
            int Minutes = 30;
            int Seconds = 20;

            int FullTimeInSeconds = (Hour * 3600) + (Minutes * 60) + Seconds;
            Console.WriteLine($"-Iнформацiя: \n-Час - {Hour} час \n-Мiнути - {Minutes} \n-Секунди - {Seconds}");

            Console.WriteLine($"Загальний час у секундах: {FullTimeInSeconds}");

            Console.WriteLine("================ Homework 3 (v) ================");
            string NameOfBook = "Институт";
            string Autor = "Стивен Кинг";
            int YearOfDrop = 2023;
            int Price = 60;

            Console.WriteLine($"Параметры книги: \n-Название книги: {NameOfBook}\n-Автор: {Autor}\n-Год выпуска:{YearOfDrop}\n-Цена:{Price}$");


        }
    }
}
