// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Create some new Rectangle objects with dimensions
Rectangle rect1 = new Rectangle(5,6);
Rectangle rect2 = new Rectangle(8);
Console.WriteLine(rect1.GetArea());
Console.WriteLine(rect2.GetArea());

// TODO: Change the values of width and height
 rect2.width = 5;
rect2.height = 9;
Console.WriteLine(rect2.GetArea());

// Operate on propert