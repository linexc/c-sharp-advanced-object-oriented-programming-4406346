// Example file for Advanced C#: Object Oriented Programming by Joe Marini

Car c = new Car() {Make = "Ford", Model = "Escort"};
Motorcycle m = new Motorcycle() {Make = "Triumph", Model = "Thunderbird"};

// Exercise the methods and properties
Console.WriteLine(c.WheelCount());
c.SoundHorn();

Console.WriteLine(m.WheelCount());
m.SoundHorn();
