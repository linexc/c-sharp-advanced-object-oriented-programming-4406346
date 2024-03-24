// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog = new Dog{Name= "Jacie", Age = 4, IsTrained = false};
Cat cat = new Cat{Name = "Bing", Age= 2,IsDeclawed= true};
Console.WriteLine($"Dog : {dog.Name},{dog.Age}");

// TODO: Initializers can be used on anonymous types
var pet = new {Name= "Charilie",Age = 5};


// TODO: Collections can also be initialized this way
int[] numbers = new int[] {1,2,3,4,5}; 
Console.WriteLine($"the length is {numbers.Length}" ); 

// TODO: Initialize a collection with a set of objects

PetOwner owner = new PetOwner{
    Name = "Joe",
    Pets = new List<Pet> {
        new Dog{Name = "Anu", Age = 5},
        new Cat{Name = "Michi", Age = 6},
        new Dog{Name = "Itit", Age = 5}
    }

}; 

foreach (Pet p in owner.Pets)
{
    Console.WriteLine($"{p.Name} + {p.Age}"); 
}