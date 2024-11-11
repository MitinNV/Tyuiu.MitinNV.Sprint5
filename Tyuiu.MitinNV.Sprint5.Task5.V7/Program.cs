using Tyuiu.MitinNV.Sprint5.Task5.V7.Lib;
namespace Tyuiu.MitinNV.Sprint5.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Чтение набора данных из текстового файла                                *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                            *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан файл С:\\DataSprint5\\InPutDataFileTask5V7.txt (файл взять из архива *");
            Console.WriteLine("*cогласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и ско-*");
            Console.WriteLine("*овать в неё файл) в котором есть набор целых значений. Найти факториал пе*");
            Console.WriteLine("*ервого целого числа в файле. Полученный результат вывести на консоль. У в*");
            Console.WriteLine("*вещественных значений округлить до трёх знаков после запятой.            *");

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

            var a = "C:\\DataSprint5\\InPutDataFileTask5V7.txt";
            var result = ds.LoadFromDataFile(a);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}