using System;
/*
* ArrayList: In c# an ArrayList is a collections type that represents a list of objects that can be accessed by index.
-> Part of System.Collections namespace
-> ArrayList is a non-generic type and can store elements of any data type.
* Add() => Adds an object to the end of the ArrayList
* Get() => Returns the object at the specified index in the ArrayList
* Count => Gets the number of elements contained in the ArrayList
* Resize() => Increases or decreases the size of the ArrayList

*/
using System.Collections;
namespace ChapterThree{
    
    public class ArrayList{
        public static void Main()
        {
            // Create a new ArrayList
            System.Collections.ArrayList names = new System.Collections.ArrayList();
            names.Add("John");
            names.Add("Doe");
            names.Add("Jane");
            names.Add(1);
        

            // Print the elements of the list
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}