using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте свою пользовательскую сборку, сборка будет
//использоваться для работы с конвертером температуры.

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите темпиратуру в цельсиях: ");
            int temp = Convert.ToInt32(Console.ReadLine()); 
            Temperature temperature = new Temperature();
            Console.WriteLine("В Форенгейтах: "+temperature.ToForengat(temp)+"\nДля выхода нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
