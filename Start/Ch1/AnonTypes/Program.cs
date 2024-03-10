// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Creating and using Anonymous types

// TODO: Anonymous types can be declared using "new" and { }, similar to JS
var myObj = new{
    Name = "jack",
    Age = 1,
    Address = new{
        street = "aaa",
        City = "Jena",
    }
};
Console.WriteLine($"{myObj.Name},{myObj.Address}");

// Anonymous types are read-only and cannot be modified
// myobj.Name = "Jane Doe"; # will cause an error

// TODO: To change a value, use non-destructive mutation and "with" clause
var myobj2 = myObj with {Name= "jackie"}; // using with to change one of the copied values.
Console.WriteLine($"{myobj2.Name},{myobj2.Address}");

// TODO: You can check to see if an anonymous object contains a property
Console.WriteLine($"{myObj.GetType().GetProperty("Name")}!= Null");
Console.WriteLine($"{myObj.GetType().GetProperty("Job")}");
Console.WriteLine(myObj.GetType().GetProperty("Name"));