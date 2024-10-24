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


            public virtual void ReactToPeople()
            {
                Console.WriteLine("Радостно скулит");
            }

            public virtual void Sound()
            {
                Console.WriteLine("Гавкать");
            }
        }
    }



// в классе Dog заменить ReactToCar на ReactToPeople, текст для вывода в консоль заменить на: радостно скулит.
// в классе Program удалить строки 18-28
// добавить в класс Program строку: Animal myAnimal = new() (или любую другую вариацию этой строки).