using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
//Создайте программу-рефлектор,
//которая позволит получить информацию о сборке и входящих в ее состав типах.
//Для основы можно использовать программу-рефлектор из урока.
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример использования класса
            Console.WriteLine("Пример использования класса");
            InstanceClass instance = new InstanceClass();
            instance.Method();
            instance.MethodInterface();
            Console.WriteLine(instance.instanceProperty);
            instance.instanceProperty = "anynameproperty";
            Console.WriteLine(instance.instanceProperty);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("После приведения к интерфейсу");
            MyInterface instanceMyInterface = instance as MyInterface;
            instanceMyInterface.MethodInterface();
            Console.WriteLine("После приведения к базовому классу");
            BaseClass instanceBaseClass = instance as BaseClass;
            instanceBaseClass.Method();
            Console.WriteLine(new string('-', 20));
            //Получение имени типа тремя способами
            Console.WriteLine("Получение имени типа тремя способами");
            Type type = instance.GetType();
            Console.WriteLine(type);
            Type type1 = Type.GetType("Task1.InstanceClass");
            Console.WriteLine(type1);
            Type type2 = typeof(InstanceClass);
            Console.WriteLine(type2);
            //Краткая информация о классе InstanceClass 
            Console.WriteLine("Краткая информация о классе InstanceClass");
            MemberInfo[] mem = type.GetMembers(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (var item in mem)
            {
                Console.WriteLine(item.MemberType);
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Информация о сборке");
            Assembly assembly = null;
            assembly = Assembly.Load(@"task1");
            Console.WriteLine(assembly.FullName + assembly.GetManifestResourceNames());
            Type[] types = assembly.GetTypes();
            MethodInfo[] methods = null;
            FieldInfo[] fields = null;
            PropertyInfo[] properties = null;
            foreach (var t in types)
            {
                Console.WriteLine("Тип=" + t.Name + " наследован " + t.BaseType);
                fields = t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (var f in fields)
                {
                    Console.WriteLine("поле-{0} типа-{1}", f.Name, f.FieldType);
                }
                methods = t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (var m in methods)
                {
                    Console.WriteLine("Method -{0} возвращает значение типа-{1} ", m.Name, m.ReturnType);
                }
                properties = t.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (var p in properties)
                {
                    Console.WriteLine("Свойства {0}-{1}", p.Name, p.PropertyType);
                }
                Console.WriteLine(new string('-',20));
            }
            Console.ReadKey();

        }
    }
}
