using Tyuiu.MitinNV.Sprint5.Task6.V26.Lib;
namespace Tyuiu.MitinNV.Sprint5.Task6.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Обработка текстовых файлов                                              *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан файл ... (файл взять из архива согласно вашему варианту. Создать папк*");
            Console.WriteLine("*ку в ручную ... и скопировать в неё файл) в котором есть набор символьных*");
            Console.WriteLine("*х данных.Найти количество знаков вопроса в заданной строке.              *");

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
            var a = "C:\\DataSprint5\\InPutDataFileTask6V26.txt";
            var result = ds.LoadFromDataFile(a);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}