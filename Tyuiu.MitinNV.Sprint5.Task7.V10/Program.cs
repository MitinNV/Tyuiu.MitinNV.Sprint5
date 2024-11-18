using Tyuiu.MitinNV.Sprint5.Task7.V10.Lib;
namespace Tyuiu.MitinNV.Sprint5.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Митин Никита Владимирович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Митин Никита Владимирович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Дан файл ... (файл взять из архива согласно вашему варианту. Создать папк*");
            Console.WriteLine("*ку в ручную ... и скопировать в неё файл) в котором есть набор символьных*");
            Console.WriteLine("*х данных.Заменить все заглавные латинские буквы на строчные.Полученный ре*");
            Console.WriteLine("*езультат сохранить в файл ...                                            *");

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
            a = "C:\\DataSprint5\\InPutDataFileTask7V10.txt";
            var result = ds.LoadDataAndSave(a);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}