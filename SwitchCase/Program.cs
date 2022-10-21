using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Козырского Ильи 24ис");
            Console.WriteLine("Введите оценку");
            String selection = Console.ReadLine(); // строковая переменная 
            switch (selection)// сравниваем выражение
            {
                case "1": // значение выражения
                    Console.WriteLine("плохо");
                    break;
                case "2":// значение выражения
                    Console.WriteLine("неудовлетворительно");
                    break;
                case "3":// значение выражения
                    Console.WriteLine("Удовлетворительно ");
                    break;
                case "4":// значение выражения
                    Console.WriteLine("Хорощо");
                    break;
                case "5":// значение выражения
                    Console.WriteLine("отлично");
                    break;
                default:// совпадений нет
                    Console.WriteLine("ошибки при вводе ");
                    break;
            }
            Console.ReadKey();// конец программы

        }
    }
}
