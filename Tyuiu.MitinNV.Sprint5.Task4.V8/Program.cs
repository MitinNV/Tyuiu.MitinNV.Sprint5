using Tyuiu.MitinNV.Sprint5.Task4.V8.Lib;
namespace Tyuiu.MitinNV.Sprint5.Task4.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Чтение данных из текстового файла                                       *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #8                                                            *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Прочитать значение из файла и подставить вместо Х в формуле. Вычислить зн*");
            Console.WriteLine("*начение по формуле (Полученное значение округлить до трёх знаков после за*");
            Console.WriteLine("*апятой) и вернуть полученный результат на консоль.                       *");

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
            string a;
            a = "C:\\DataSprint5\\InPutDataFileTask4V8.txt";
            var result = ds.LoadFromDataFile(a);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}