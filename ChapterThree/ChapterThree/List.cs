using System;
using System.Collections.Generic;
/*
* List: In c# a List<T> is a collections type that represents a list of objects that can be accessed by index.
-> Part of System.Collections.Generic namespace
-> List<T> is a generic type and can store elements of any data type.
* Add() => Adds an object to the end of the List<T>
* Remove() => Removes the first occurrence of a specific object from the List<T>
* Count => Gets the number of elements contained in the List<T>
* IndexOf() => Searches for the specified object and returns the zero-based index of the first occurrence within the entire List<T>
* Sort() => Sorts the elements in the entire List<T>
* Clear() => Removes all elements from the List<T>

*/
namespace ChapterThree
{
    public class List
    {
        public static void Main()
        {
            // Create a new list
            List<int> numbers = new List<int>();
            List<string> names = new List<string>();
            names.Add("John");
            names.Add("Doe");
            names.Add("Jane");
            string[] animal = new string[] { "Cow", "Camel", "Elephant" };
            List<string> animalList = new List<string>();
            animalList.AddRange(animal);
            foreach (string item in animalList)
            {
                Console.WriteLine(item);
            }
            // Add elements to the number list
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            // Print the elements of the list
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}