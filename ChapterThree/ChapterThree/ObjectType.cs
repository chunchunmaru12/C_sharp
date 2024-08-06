/*
* The object type
    -> object[System Object] is the ultimate base class for all types
    -> Any type can be upcast to object.
    -> It is the base type from which other types(both value types and reference types)
        Values Types                           Reference Types
      * Numeric(int, float, double, etc)       String Classess Arrays and interfaces
        Struct char Boolean
*/
namespace ChapterThree
{

    class ObjectType
    {
        public int X;
        static void SimpleExample()
        {
            //int value = 42 // usual way of declaring int
            object obj1 = 42;
            object obj2 = "Hello World";
            object obj3 = new DateTime(2024, 01, 12);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);
        }
        static void TypeCastingExample()
        {
            object obj = "Hello, world!";
            string str = (string)obj;
            Console.WriteLine(str);
            int? number = obj as int?;
            if (number != null)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Object is not an integer");
            }
        }
        static void Main(string[] args)
        {
            SimpleExample();
            TypeCastingExample();
            ObjectType obj = new ObjectType();
            Console.WriteLine("GetType():");
            Console.WriteLine(obj.GetType().Name);
            Console.WriteLine("typeof():");
            Console.WriteLine(typeof(ObjectType).Name);
            Console.WriteLine(obj.GetType()==typeof(ObjectType));
            Console.WriteLine(obj.X.GetType());
        /* Boxing and Unboxing:
            -> Boxing and unboxing is the processes in c# that involve converting between value types and references types
            * Boxing: Converting a value type(int char double ) to an object type
                Object type:
                    When a value types is boxed it is wrapped in an instance of System.Object and place on the heap rather than on the stack where values types are usually stored
                Example:
                    int value = 123;
                    object boxed= value;
                    Console.WriteLine(boxed); //op 123
            * Unboxing: Extracting the value type from an object type that was previously boxed.
                    This involves casting the object back to the original value type
                        Example:
                            object boxed = 123;
                            int value = (int) boxed;
                            Console.WriteLine(value); //op 123 
                */
        }
    }
}