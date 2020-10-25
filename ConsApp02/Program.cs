using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography;
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
        #endregion 

        #region // Написать метод подсчета количества цифр числа (Метод для 2-го задания)
        static int numberDigits(string a)
        {
            int number = 0;
            while (number < a.Length)
                number++;
            return number;
        }
        #endregion

        /*
        Метод для 4-го задания
        Реализовать метод проверки логина и пароля. 
        На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
        С помощью цикла do while ограничить ввод пароля тремя попытками. 
         */
        #region
        static bool passwordConf(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
                return true;
            else
                return false;                
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
            Console.WriteLine($"Минмальное значение = {minSize(a, b, c)}");
            #endregion

            #region // Задание №2. Написать метод подсчета количества цифр числа
            Console.WriteLine("Задание №2. Написать метод подсчета количества цифр числа");
            string a2 = Console.ReadLine();
            Console.WriteLine($"Количество чисел в введённом числе = {numberDigits(a2)}");
            #endregion

            #region // Задание №3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            Console.WriteLine("Задание №3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел");
            int a3;
            int sum = 0;
            Console.WriteLine("Введите любое число. Для выхода из программы введите 0.");
            do
            {
                Console.Write("Введите число: ");
                a3 = Convert.ToInt32(Console.ReadLine());
                if (a3 > 0 && (a3 % 2 != 0))
                    sum += a3;
            }
            while (a3 != 0);
            Console.WriteLine($"Сумма введённых полoжительных нечётных цифр = {sum}");
            #endregion

            /*
        Задание "№4
        Реализовать метод проверки логина и пароля. 
        На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
        С помощью цикла do while ограничить ввод пароля тремя попытками. 
         */

            #region
            Console.WriteLine("Введите логин и пароль");
            int count = 0;
            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();
                if (passwordConf(login, password) == true)
                {
                    Console.WriteLine("поздравляем! Вы успешно авторизовались!");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы неверно ввели логин или пароль!");
                    count++;
                }

            }
            while (count < 3);
            if (count == 3)
                Console.WriteLine($"Вы ввели {count} раза неправильный логин или пароль!\nВ авторизации Отказано!");
            #endregion
            lesson.Pause();
        }
    }
}
 