using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class InstanceClass : BaseClass, MyInterface
    {
        /// <summary>
        /// Открытое свойство для чтения\записи в поле Basefield класса BaseClass
        /// </summary>
        public string instanceProperty
        {
            get { return baseField; }
            set { baseField = value; }
        }

        public InstanceClass() : base()
        {
            Console.WriteLine("instanceClass ctor");
        }
        public InstanceClass(string name) : base(name)
        {
            Console.WriteLine("instanceClass ctor with param");
        }
        public override void Method()
        {
            Console.WriteLine("instanceClass method");
        }

        public void MethodInterface()
        {
            Console.WriteLine("instanceClass interfacemethod");
        }
    }
}
