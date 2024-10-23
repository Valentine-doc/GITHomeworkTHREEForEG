using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITLessTwoForEG
{
    public class Dog : Animal   // класс Dog наследник класса Animal
    {
            public int Age { get; set; }
            public string Breed { get; set; }
            public string Name { get; set; }


            public virtual void ReactToCar()
            {
                Console.WriteLine("Бежит за машиной");
            }

            public virtual void Sound()
            {
                Console.WriteLine("Гавкать");
            }
        }
    }
