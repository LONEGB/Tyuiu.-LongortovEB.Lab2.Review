
using Tyuiu._LongortovEB.Lab2.Review.V4.Lib;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Лонгортов Е. Б. | НТм-23-1";
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                               *");
        Console.WriteLine("* Тема: Табулирование функции по методологии разработка через тестирование                *");
        Console.WriteLine("* Задание #2                                                                             *");
        Console.WriteLine("* Вариант #4                                                                              *");
        Console.WriteLine("* Выполнил: Лонгортов Егор Борисович | НТм-23-1                                          *");
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                *");
        Console.WriteLine("* написать программу, которая выводит таблицу значений функции (произвести табулирование) *");
        Console.WriteLine("* f(x) на заданном диапазоне X1, X2. Произвести проверку деления на ноль.                 *");
        Console.WriteLine("* Значения должны храниться в массиве. Округлить значения до двух знаков после запятой.   *");
        Console.WriteLine("*                                                                                         *");
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                                       *");
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("Старт шага:"); int startStep = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Конец шага:"); int endStep = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*******************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                              *");
        Console.WriteLine("*******************************************************************************************");


        double[][] result = ds.GetMassFunction(startStep, endStep);

        // Отступы для каждой колонки
        int columnWidthX = 6;  // Ширина колонки для X
        int columnWidthFx = 10;  // Ширина колонки для F(x)
        int tableWidth = columnWidthX + columnWidthFx + 5;  // Общая ширина таблицы

        // Верхняя линия таблицы
        Console.WriteLine(new string('-', tableWidth));

        // Заголовки таблицы
        Console.WriteLine("|{0," + columnWidthX + "}|{1," + columnWidthFx + "}|", "X", "F(x)");

        // Линия после заголовков
        Console.WriteLine(new string('-', tableWidth));

        // Вывод значений из массива
        foreach (double[] element in result)
        {
            Console.WriteLine("|{0," + columnWidthX + "}|{1," + columnWidthFx + ":0.00}|", element[0], element[1]);
        }

        // Нижняя линия таблицы
        Console.WriteLine(new string('-', tableWidth));

        Console.ReadKey();
    }

}