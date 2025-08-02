using System;

namespace dcit318_assignment2_11262526
{
    class Program
    {
        static void Main(string[] args)
        {
            // === Task 1: Inheritance and Method Overriding ===
            Console.WriteLine("=== Inheritance and Method Overriding ===");

            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            genericAnimal.MakeSound();  // Output: Some generic sound
            dog.MakeSound();            // Output: Bark
            cat.MakeSound();            // Output: Meow

            // === Task 2: Abstract Classes and Methods ===
            Console.WriteLine("\n=== Abstract Classes and Methods ===");

            Shape circle = new Circle(5);           // radius = 5
            Shape rectangle = new Rectangle(4, 6);  // length = 4, width = 6

            Console.WriteLine($"Circle Area: {circle.GetArea():F2}");       // Expected: 78.54
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea():F2}"); // Expected: 24.00

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
