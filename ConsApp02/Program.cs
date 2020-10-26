using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Net.NetworkInformation;
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
        static int numberDigits(int a)
        {
            int number = 0;
            while (a != 0)
            {
                a = a / 10;
                number++;
            }
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
        #region // задание №4. Написать метод для проверки логина и пароля
        static bool passwordConf(string login, string password)
        {
            if (login == "root" && password == "GeekBrains")
                return true;
            else
                return false;                
        }
        #endregion


        #region //Задание №5. Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
        static double IMT(float weig, float heig)
        {
            return weig / (Math.Pow((heig / 100), 2));
        }

        static void IMTMessage(double index, float weig, float heig)
        {
            if (index <= 16)
                Console.WriteLine($"Ваш ИМТ: {index:f2}. У вас выраженный дефицит массы тела. Необходимо набрать {imtRecommend(weig,heig):f2}кг.");
            else if (index > 16 && index <= 18.5)
                Console.WriteLine($"Ваш ИМТ: {index:f2}. У вас Недостаточная (дефицит) массы тела. Необходимо набрать {imtRecommend(weig, heig):f2}кг.");
            else if (index > 18.5 && index <= 24.99)
                Console.WriteLine($"Ваш ИМТ: {index:f2}. Ваш вес в норме");
            else if (index >= 25 && index <= 30)
                Console.WriteLine($"Ваш ИМТ: {index:f2}. У вас избыточная масса тела (предожирение). Необходимо скинуть {imtRecommend(weig, heig):f2}кг.");
            else if (index > 30 && index <= 35)
                Console.WriteLine($"Ваш ИМТ: {index:f2}. У вас ожирение первой степени. Необходимо скинуть {imtRecommend(weig, heig):f2}кг.");
            else if (index > 35 && index <= 40)
                Console.WriteLine($"Ваш ИМТ: {index:f2}. У вас ожирение второй степени. Необходимо скинуть {imtRecommend(weig, heig):f2}кг.");
            else if (index > 40)
                Console.WriteLine($"Ваш ИМТ: {index:f2}. У вас ожирение третьей степени (морбидное). Необходимо скинуть {imtRecommend(weig, heig):f2}кг.");
        }

        static double imtRecommend(float weig, float heig)
        {
            return Math.Abs(weig - 21.745 * Math.Pow((heig / 100), 2));
        }
        #endregion

        #region // Задание №7. Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b)
        static void Rek(int a, int b)
        {
            if (a >= b) return;
            if (a < b)
            {
                Console.WriteLine(a);
                Rek(a + 1, b);
            }
        }

        static int Sumrek(int a, int b)
        {
            return a == b ? b : a + Sumrek(a + 1, b);
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
            Console.Write("Введите любое число: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
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

            #region // Задание №4. Реализовать метод проверки логина и пароля.
            Console.WriteLine("Задание №4. Реализовать метод проверки логина и пароля.");
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

            #region // Задание №5. Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме
            Console.WriteLine("Задание №5. Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме");
            Console.WriteLine("Введите свой рост в см. и вес в кг.");
            Console.Write("Введите свой вес в кг.: ");
            float weig = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите свой рост в см.: ");
            float heig = Convert.ToSingle(Console.ReadLine());
            double index = IMT(weig, heig);
            IMTMessage(index, weig, heig);
            #endregion
            
            #region // Задание №6. Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр
            Console.WriteLine("Задание №6. Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр");
            int check = 0;
            DateTime start = DateTime.Now;
            for(int i = 1; i < 1000000000; i++)
            {
                sum = 0;
                int value = i;
                int nindex = i;
                while (nindex != 0) 
                {
                    sum += nindex % 10;
                    nindex = nindex / 10; 
                }
                if (value % sum == 0)
                {
                    check++;
                }
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine($"Количество хороших чисел = {check}, время выполнения программы = {finish - start}");
            #endregion

            #region // Задание №7. Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b)
            Console.WriteLine("Задание №7. Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b)");
            Console.Write("Введите значение А: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение Б: ");
            b = Convert.ToInt32(Console.ReadLine());
            Rek(a, b);

            // Задание 7.б

            Console.WriteLine($"Сумма чисел в диапазоне от {a} до {b}: {Sumrek(a, b)}");
            #endregion
            lesson.Pause();
        }
    }
}
 