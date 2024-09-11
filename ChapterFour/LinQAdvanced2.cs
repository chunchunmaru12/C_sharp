using System.Runtime.CompilerServices;

namespace Chapter4{
    class StudentOne{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set;}
        public StudentOne(int id, string name, string address){
            this.Id=id;
            this.Name=name;
            this.Address=address;
        }   
    }
    class Advance2{
    static void Main(string[] args)
    {
       // List<string> exampleList = new List<string>(){"A", "B", "C", "D", "E", "F"};
        List<StudentOne> example= new List<StudentOne>();
        example.Add(new StudentOne(1,"md","dhobighat"));
        example.Add(new StudentOne(2,"yube","dhobighat"));
        example.Add(new StudentOne(3,"rusar","bagdol"));
        example.Add(new StudentOne(4,"mewo","patan"));
        var filteredStudent = example.Where(s => s.Address.Contains("dhobighat")||s.Name.Contains("mewo"));
        foreach (var std in filteredStudent){
            Console.WriteLine(std.Name);
        }
        // foreach (var student in example){
        //     if(student.Address=="dhobighat"){
        //         Console.WriteLine("Student Id:" + student.Id+ " Name:" + student.Name+ " Address:" + student.Address);
        //     }
            
        // }
        
    }
    }
    
}