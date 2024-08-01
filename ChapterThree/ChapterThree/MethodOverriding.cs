using System;
/*
Method Overriding
    -> Method Overriding in c# allows programmers to create base class that allows its inherited
    classes to override same name methods when implementing in their class for different purposes
    -> Method Overriding is used to enforce some must implement feature in derived classes
* Method Overriding is only possible in derived classes not on the same class where the method is declared
* Base class must use virtual or abstract keywords to declare a method then only can a method be overridden
-> virtual method
    A method that can be redefined in desired classes
    it has an implementation in both base and derived classes
    it is used when a method's basic functionality is the same but sometimes more functionality is needed in derived classes
    Features:
        by default methods can be virtual we cannot override a non virtual method
        We cannot use the virtual modifier with the static, abstract private or override modifier
        * If class is not inherited, behaviour of virtual method is some as non virtual method 

*/
namespace ChapterThree{
    public class Employee{
        public Employee(string name)
        {
            Name = name;
        }

        public string Name{get; set; }
        public virtual void DisplayRole(){
            Console.WriteLine($"{Name} is a general employee");
        }
    }
    public class Manager:Employee{
        public Manager(string name): base(name){}
        public override void DisplayRole(){
            Console.WriteLine($"{Name} is a manager");
        }
    }
    public class Developer:Employee{
        public Developer(string name): base(name){}
        public override void DisplayRole(){
            Console.WriteLine($"{Name} is a Developer");
        }
        
    }

    public class MethodOverriding{
        static void Main(string[] args)
        {
            Employee employee = new Employee("somebody");
            Employee obj = new Manager("noor");
            Employee dev = new Developer("md");
            employee.DisplayRole();
            obj.DisplayRole();
            dev.DisplayRole();
           
        }
    }
}