using System;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Проверяем как ведут себя значимые типы данных.
            // Создаем два объекта, во второй помещаем первый,
            // а затем изменяем второй. Первый остается неизменным.
            var int1 = 5;
            Console.WriteLine("int1: " + int1);
            var int2 = int1;
            int2 = 7;
            Console.WriteLine("int1: " + int1);
            Console.WriteLine("int2: " + int2);

            Console.WriteLine(new string('-', 30));

            // Проверяем как ведут себя обычные ссылочные типы данных.
            // Создаем два объекта, во второй помещаем первый,
            // а затем изменяем второй. Первый объект тоже изменился.
            int[] array1 = new int[] { 1, 2, 3};
            Console.WriteLine("First item in array1: " + array1[0]);
            int[] array2 = array1;
            array2[0] = 100;
            Console.WriteLine("First item in array1: " + array1[0]);
            Console.WriteLine("First item in array2: " + array2[0]);

            Console.WriteLine(new string('-', 30));

            // Проверяем как ведут себя клонируемые объекты.
            // Создаем два объекта, во второй помещаем клон первого,
            // а затем изменяем второй. Первый остается неизменным.
            PagePrototype page1 = new PagePrototype("Hello, World!");
            page1.IdInfo = new IdInfo(1);

            //PagePrototype page2 = page1;
            PagePrototype page2 = page1.Clone() as PagePrototype;
            page2.Content = "HELLO";
            page2.IdInfo.IdNumber = 2;

            //page1.Content = "Hi World";
            //page1.IdInfo.IdNumber = 3;

            Console.WriteLine(page1.IdInfo.IdNumber + " cloneText1:" + page1.Content);
            Console.WriteLine(page2.IdInfo.IdNumber + " cloneText2:" + page2.Content);

            Console.ReadKey();
        }
    }
}
