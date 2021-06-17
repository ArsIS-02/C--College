using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{/*
Проект 2-1
"Разговор с Марсом"
Назовите этот файл Mars.cs
*/
    using System;
    class Mars
    {
        public static void Main()
        {
            double distance;
            double lightspeed;
            double delay;
            double delay_in_min;
            distance = 34000000; // 34000000 миль
            lightspeed = 186000; // 186,000 миль в секунду
            delay= distance / lightspeed;
            delay_in_min = delay / 60;
            Console.WriteLine("Расстояние между Землей и Марсом сигнал " +"пройдет за \n{0:###.###} секунд.", delay);
            Console.WriteLine("Время задержки сигнала составляет {0:###.###} минут.", delay_in_min);
            Console.ReadKey();
        }
    }
}
