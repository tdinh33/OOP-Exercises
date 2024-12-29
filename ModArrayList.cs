using System;
using System.Collections.Generic;


namespace OOP;

// CLASS DECLARATION:
// Here, we define a class called ModArrayList<T>. The <T> is known as a 
// type parameter, making this a generic class. It can store and manage 
// a collection of any data type T
public class ModArrayList<D> : List<D>
{
    // INHERITANCE:
    // Notice that ModArrayList<D> is inheriting from List<D>. This means 
    // ModArrayList<D> gets all the functionality of List<D> (like Add, Remove, Count, etc.)
    // We can extend or override behaviours as needed

    // METHOD - GetUsingMod: 
    // This method retrieves an element at a specified index, but instead of the throwing 
    // an exception when the index is out of range, it wraps the index using the modulus operator

    public D GetUsingMod(int index)
    {
        // Step 1: Take the absolute value of the index to ensure it's positive

        // Step 2: Use modules (%) by the count of the list to wrap the index 
        //if it exceeds the bounds of the list. This prevents out-of-range errors 
        int validIndex = Math.Abs(index) % this.Count;

        // Step 3: Return the element at the wrapped index
        return this[validIndex];
    }
}

/* 
 OOP Principles illustrated 

CLASS: ModArrayList<D> is in the class. It's a generic class that defines what data and behaviours 
are available to objects created from it 


INHERITANCE: The ModArrayList<D> : List<D> means that ModArrayList inherits from the generic List<D> class
This allows is to use or extend all methods and properties of List<D, such as Add(), Remove(), and indexing. 


ENCAPSULATION: The internal data used within List<D> is encapsulated by List<D> itself. 
We rely on the List<D> methods like 'this[validIndex]' to access elements properly 
Our class only adds a new method GetUsingMod that doesn't override any existing method but extends functionality

METHOD: GetUsingMod (int Index) is  a method that provides a safer, "wrapped" way to retrieve list elements 




*/