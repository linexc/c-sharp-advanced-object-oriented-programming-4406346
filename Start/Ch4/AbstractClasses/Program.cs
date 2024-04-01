// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining abstract classes

Car c = new Car() {Marke = "Ford", Model = "Escort"};
Motorcycle m = new Motorcycle() {Marke = "Triumph", Model = "Thunderbird"};

Console.WriteLine(c);
c.SoundHorn();
Console.WriteLine(m);
m.SoundHorn();

// TODO: Instantiate the base class
