using System;

namespace LabWork8_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x="); //вывод на консоль
            double x = double.Parse(Console.ReadLine()); //ввод и задание переменной вещественного типа

            Console.WriteLine("Введите y="); //вывод на консоль
            double y = double.Parse(Console.ReadLine());//ввод и задание переменной вещественного типа

            double r = Math.Pow(Math.Pow(3, 2) + Math.Pow(3, 2), 0.5); //ввод и задание переменной вещественного типа

            double a = Math.Pow(Math.Pow(x, 2) + Math.Pow(y, 2), 0.5); //задание переменной вещественного типа по формуле

            if (a < r && x >= -3 && x <= 3 && y <= 3 && y >= 0) //проверка выполнения условия
                Console.WriteLine("Точка попадает в заштрихованную область");//вывод на консоль
            else //другой исход
                Console.WriteLine("Точка не попадает в заштрихованную область");//вывод на консоль
        }
    }
}
