using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITLessTwoForEG
{
    public class Animal
    {
        public void Sound()
        {
            Console.WriteLine("Животное издает звуки");
        }
        public void ReactToPeople()
        {
            Console.WriteLine("Реагирует на человека");
        }
    }
}


// в классе Animal заменить ReactToCar на ReactToPeople, текст для вывода в консоль заменить на: реагирует на человека
// в классе Dog заменить ReactToCar на ReactToPeople, текст для вывода в консоль заменить на: радостно скулит.
// в классе Program удалить строки 18-28
// добавить в класс Program строку: Animal myAnimal = new() (или любую другую вариацию этой строки).