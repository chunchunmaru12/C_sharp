/*
* Struct(Structure):
-> Value type that is used encapsulate a group of related variables
-> Similarly to classes but have key difference on how they are stored and managed in memory
-> They are useful for representing small, lightweight object  that have a single logical entity
* A struct is similar to a class with following  key difference 
    -> A struct is a value type and a class is a reference type
    -> A struct does not support inheritance
    -> A struct cannot have a default constructor
    -> A struct cannot have a destructor
    -> A struct cannot have a parameterless constructor
* Enums(Enumerations):
    -> A special types that allows you to define set of named constants
    -> Value type and is a primitive data type which is user defined
    -> The default underlying type of the enumeration elements is int
    -> By default the first element of the enumeration has the value 0 and the value of each successive element is increased by 1
    public enum DayOfWeek{
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public class Program{
    static void Main(){
        DayOfWeek today =DayOfWeek.Wednesday;
        Console.WriteLine(today);
        int dayNumber = (int)today;
        Console.WriteLine(dayNumber);
    }
    }
*/
namespace ChapterThree{
public struct Point{
    public int X{get; set; }
    public int Y{get; set;}
    public Point(int x, int y){
        X=x;
        Y=y;
    }
    public void Display(){
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}
public class Struct {
    static void Main(string[] args)
    {
        Point point = new Point(10,20);
        point.Display();
    }
}
}