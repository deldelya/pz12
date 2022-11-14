using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//12 variant  pz 12 Вычислить сумму: 1!+2!+3!+…+n!, используя функцию вычисления факториала числа k. 
//Использовать метод для нахождения факториала + сделать в  цикле с инт К, чтобы не приходилось зановво открывать консоль

namespace dg
{
    internal class Program
    {
        //static void fktrl(int i)
        //{
        //    int fact = 1;

        //    for (int j = 2; j <= i; j++)
        //    {
        //        fact *= j;
        //    }

        //    Console.WriteLine("Факториал = " + fact);

        //}

        //static void Main(string[] args)
        //{
        //    int k = Convert.ToInt32(Console.ReadLine()); // число 

        //    while ( )
        //    {

        //        continue;
        //    }

        //    fktrl(k);

        //    Console.Read();
        //}

        //21 variant_12pz
        //Описать функцию Quarter(x, y) целого типа, определяющую номер координатной четверти, в 
        //которой находится точка с ненулевыми вещественными координатами (x, y). С помощью этой 
        //функции найти номера координатных четвертей для трех точек с данными ненулевыми 
        //координатами.
    //    static void Quarter(double x, double y)
    //    {
    //        if (x > 0 && y > 0)
    //        {
    //            Console.WriteLine("I четверть");
    //        }
    //        if (x < 0 && y > 0)
    //        {
    //            Console.WriteLine("II четверть");
    //        }
    //        if (x < 0 && y < 0)
    //        {
    //            Console.WriteLine("III четверть");
    //        }
    //        if (x > 0 && y < 0)
    //        {
    //            Console.WriteLine("IV четверть");
    //        }
    //        Console.ReadKey();
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("введите координаты");
    //        double x = Convert.ToDouble(Console.ReadLine());
    //        double y = Convert.ToDouble(Console.ReadLine());
    //        Quarter(x,y);
    //    }

    }
}

//12 variant pz 13 Реализуйте метод, принимающий в качестве параметра массив целых чисел и возвращающий 
//сумму всех четных элементов массива, стоящих на нечетных позициях


//21 variant_pz13
//Реализуйте метод, принимающий в качестве параметра строку. Строка содержит в себе путь 
//к произвольной папке с содержимым. Метод возвращает количество вложенных каталогов и 
//отдельно количество файлов

