// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Define a class using the "class" keyword
class Rectangle{

 // TODO: The constructor accepts parameters used to create the object
    public Rectangle (int w, int h)
    {
        // initialize width and height
        width = w;
        height = h;
    }

// TODO: For convenience, we can have a constructor that takes one value
    // for squares that have the same side size
    public Rectangle (int s)
    {
        width = height = s; 
    }

 // TODO: Classes can define methods that return values
    public int GetArea()
    {
        return width*height; 
    }

// Public is used to let outsider access the properties.
 public int width;
 public int height;

// TODO: member variables hold data


}
   


    


   

