using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample.Model
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name { get { return name; }
        set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Имя не может быть пустым.");
                name = value;
            }
        }
        public int Age {
            get { return age;}
            set 
            {
                if (value < 0 || value > 120)
                    throw new ArgumentOutOfRangeException("Возраст должен быть в пределах от 0 до 120.");
                age = value;
            }
        }
        public string GetInfo()
        {
            return $"Имя: {Name}, Возраст: {Age}";
        }
    }
}
