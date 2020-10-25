using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsApp02
{
    class Program
    {
        #region // Написать метод, возвращающий минимальное из трех чисел.(Метод для 1-го задания)
        static int minSize(int a, int b, int c)
        {
            int min = 0;
            if (a < b && a < c)
                 min = a;
            else if (b < a && b < c)
                 min = b;
            else if (c < a && c < b)
                 min = c;
            return min;
        }
        #endregion // Написать метод подсчета количества цифр числа (Метод для 2-го задания)
        static int numberDigits(string a)
        {
            int number = 0;
            while (number < a.Length)
                number++;
            return number;
        }
        #region

        #endregion
        static void Main(string[] args)
        {
            Lesson01 lesson = new Lesson01();
            #region // Задание №1. Написать метод, возвращающий минимальное из трех чисел
            Console.WriteLine("Задание №1. Написать метод, возвращающий минимальное из трех чисел");
            Console.Write("Введите значение для 1-ой переменной: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение для 2-ой переменной: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение для 3-eй переменной: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Минмальное значение = {minSize(a, b, c)}");
            #endregion

            #region // Задание №2. Написать метод подсчета количества цифр числа
            Console.WriteLine("Задание №2. Написать метод подсчета количества цифр числа");
            string a2 = Console.ReadLine();
            Console.WriteLine($"Количество чисел в введённом числе = {numberDigits(a2)}");

            #endregion
            lesson.Pause();
        }
    }
}
