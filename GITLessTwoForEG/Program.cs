using GITLessTwoForEG;

namespace GITLessTwoForEG
{
    public class Program
    {
        static void Main(string[] args)
        {

            Dog myDog1 = new()
            {
                Name = "Lightyear",
                Age = 9,
                Breed = "Jeckrussel"
            };


            Dog myDog2 = new()
            {
                Name = "Bazz",
                Age = 10
            };

            Console.WriteLine($"Первую мою собаку зовут {myDog1.Name}, вторую {myDog2.Name}. Они брат с сестрой, {myDog1.Name} младше, ей {myDog1.Age}, а { myDog2.Name} уже {myDog2.Age}.");
            Console.WriteLine($"\nРеакция на машины у них разная: {myDog1.Name} начинает ");
            myDog1.Sound();
            Console.WriteLine($"В то время как {myDog2.Name} ");
            myDog2.ReactToCar();
            
        }
    }
}