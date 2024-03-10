// Example file for Advanced C#: Object Oriented Programming by Joe Marini

// Create some rectangle objects
Rectangle rect1 = new Rectangle(10,20);
Rectangle rect2 = new Rectangle(30);

Console.WriteLine(rect1.GetArea());
Console.WriteLine(rect2.GetArea());

// TODO: Operate on the Properties
rect1.BorderSize = -1; 
Console.WriteLine(rect1.BorderSize);

// the difference with rect1.width is the public exposed properties, but the wide is private still. 
// Due to the public Height, it is possible to add some limitations on the value. 
rect1.Width = 5; 
rect1.Height= -1; 
Console.WriteLine(rect1.GetArea());
// TODO: Try setting an invalid value
