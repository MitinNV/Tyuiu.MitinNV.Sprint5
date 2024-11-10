using Tyuiu.MitinNV.Sprint5.Task0.V22.Lib;
namespace Tyuiu.MitinNV.Sprint5.Task0.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись данных в текстовый файл                              *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дано выражение вычислить его значение при x = 3, результат сохранить в те*");
            Console.WriteLine("*екстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх*");
            Console.WriteLine("*х знаков после запятой.                                                  *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            var result = ds.YOURFUNCTION(a, b);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}