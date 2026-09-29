//*************************************************************************
//* Практичсекая работа № 7                                               *
//* Выполнила: Трухина Е.Д., группа 2ИСП                                  *
//* Задание: составить программу циклической структуры: цикл с параметром *
//*************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Title = "Практичсекая работа 7";
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Здравствуй!");
                Console.Write("Введите n = ");
                int n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите эпсилон(ε) = ");
                double epsilon = Convert.ToDouble(Console.ReadLine());

                double sum = 0;
                double a = 1;

                for (int i = 1; i <= n; i++)
                {
                    if (i == 1)
                    {
                        a = 1.5;// a_1 = (3^1 * 1!) / (2!)= 3 / 2 = 1.5
                    }
                    else
                    {
                        a = a * 3.0 / (2.0 * (2.0 * i - 1.0));// a_i = a_{i-1} * 3 / (2 * (2*i - 1))
                    }
                    if (Math.Abs(a) >= epsilon)
                    {
                        sum += a;
                    }
                }
                Console.WriteLine($"\nСумма членов ряда, удовлетворяющих условию: {sum}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Вы ввели не число! Пожалуйста, введите цифры.");//Если пользователь вводит символы вместо цифр
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: Введенное число слишком большое или слишком маленькое.");//Если введенное число слишком большое или слишком маленькое для типа double
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла непредвиденная ошибка: " + ex.Message);//любая другая ошибка
            }
            Console.ReadKey();
        }
    }
}
