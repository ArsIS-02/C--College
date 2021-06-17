using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication40
{
    class Program
    {
        public static void Main()
        {
            int x; // Переменная x известна всему коду
            // в пределах метода Main().
            x = 10;
            if (x == 10)
            { //Создается новая область видимости.
                int y = 20; // Эта переменная будет видна только в рамках
                // этого блока.
                // В данном блоке видны обе переменные, x и y.
                Console.WriteLine("Видны x и y: " + x + " " + y);
                x = y * 2;
            }
            // y = 100; // Ошибка! Переменная y здесь не видна!
            // Выполняется доступ к переменной x, которая была объявлена
            // в этой области видимости.
            Console.WriteLine("Значение переменной x равно: " + x);
            Console.ReadKey();
        }
    }
}
