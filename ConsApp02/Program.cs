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
        #region // создание метода для 1-го задания
        static int MinSize(int a, int b, int c)
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
            Console.WriteLine($"Минмальное значение = {MinSize(a, b, c)}");
            #endregion

            lesson.Pause();
        }
    }
}
