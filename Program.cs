using System;

namespace dcit318_assignment2_11262526
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding ===");

            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            genericAnimal.MakeSound();  // Output: Some generic sound
            dog.MakeSound();            // Output: Bark
            cat.MakeSound();            // Output: Meow

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
