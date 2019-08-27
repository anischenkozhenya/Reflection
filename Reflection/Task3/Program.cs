using System;
using System.Reflection;
//Создайте программу, в которой предоставьте пользователю доступ к
//сборке из Задания 2. Реализуйте использование метода конвертации
//значения температуры из шкалы Цельсия в шкалу
//Фаренгейта.Выполняя задание используйте только рефлексию.

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("Task2");
            Type type = assembly.GetType("Task2.Temperature");
            var temp = Activator.CreateInstance(type);
            MethodInfo method = type.GetMethod("ToForengat");
            Console.WriteLine("Введите погоду в цельсиях");
            int t = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Темпиратура в форенгейтах:{0}\nДля выхода нажмите любую клавишу...", method.Invoke(temp, new object[] { t }));
            Console.ReadKey();
        }
    }
}
