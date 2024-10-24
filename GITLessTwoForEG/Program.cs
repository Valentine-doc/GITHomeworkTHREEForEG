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

        Animal myAnimal = new();

        System.Console.WriteLine(myDog1.Name);
        myAnimal.ReactToPeople();
        myDog1.ReactToPeople();


// создать pull request


            
            
        }
    }
}