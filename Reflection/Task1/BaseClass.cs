using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Абстрактный класс
    /// </summary>
    abstract class BaseClass
    {
        /// <summary>
        /// защищенное поле BaseClass типа string
        /// </summary>
        protected string baseField;
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public BaseClass()
        {
            Console.WriteLine("BaseClass ctor 0 param");
        }
       /// <summary>
       /// Конструктор с одним параметром
       /// </summary>
       /// <param name="field">Поле в BaseClass</param>
        public BaseClass(string field)
        {
            this.baseField = field;
            Console.WriteLine("BaseClass ctor 1 param");
        }
        /// <summary>
        /// Абстрактный метод
        /// </summary>
        public abstract void Method();
    }
}
