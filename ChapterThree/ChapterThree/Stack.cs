using System;
/*
* Stack: In c# a Stack<T> is a collections type that represents a last-in, first-out (LIFO) data structure.
-> Part of System.Collections.Generic namespace.
-> Manage elements where the last element added is the first element removed.
* Contains() => Determines whether an element is in the Stack<T>
* Clear() => Removes all elements from the Stack<T>
* Peek() => Returns the object at the top of the Stack<T> without removing it.
* Pop() => Removes and returns the object at the top of the Stack<T>
* Push() => Adds an object to the top of the Stack<T>
*/
namespace ChapterThree
{
    public class Stack
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");
            stack.Push("Four");
            stack.Push("Five");
            stack.Pop(); // remove the last element Five
            stack.Pop(); // remove the second last element Four
            bool isThree = stack.Contains("Three");
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
        }
    
    }
}