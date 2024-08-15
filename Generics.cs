
/* Create a class CustomList<T> that implemenitems a simple list of element of type T the class should include:
1. A constructor to initialize an empty list
2. An Add Method to add elemenitems to the list
3. An indexer to access elemenitems by index
4. Overload the + operator to concatenate two customList<T> instances into one
*/
using System.Collections.Generic;
using System;

namespace LabTwo
{
    public class CustomList<T>
    {
        private List<T> items;
        public CustomList()
        {
            items = new List<T>();
        }
        public void Add(T value)
        {
            items.Add(value);
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < items.Count)
                {
                    return items[index];
                }
                throw new IndexOutOfRangeException("Index out of range");
            }
            set
            {
                if (index >= 0 && index < items.Count)
                {
                    items[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
            }
        }

        public static CustomList<T> operator +(CustomList<T> c1, CustomList<T> c2)
        {
            CustomList<T> temp = new CustomList<T>();
            foreach (T item in c1.items)
            {
                temp.Add(item);
            }
            foreach (T item in c2.items)
            {
                temp.Add(item);
            }
            return temp;
        }
    }

    public class Generics
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> c1 = new CustomList<int>();
            CustomList<int> c2 = new CustomList<int>();
            c1.Add(2);
            c1.Add(2);
            c2.Add(3);
            c2.Add(7);
            CustomList<int> result = c1 + c2;
            for (int i = 0; i <result[2] ; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
