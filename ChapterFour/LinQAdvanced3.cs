namespace Chapter4{
    class StudentThree{
        public string Name { get; set; }
        public string Grade { get; set; }
        public StudentThree(string Name,string Grade) {
            this.Name=Name;
            this.Grade=Grade;
        }
    }
    
    class Advance3{
        static void Main(string[] args)
        {
            List<StudentThree> students = new List<StudentThree>(){
            new StudentThree("Admin","A"),
            new StudentThree("Admin","B"),
            new StudentThree("Charlie","A"),
            new StudentThree("David","A"),
            new StudentThree("Bob","B")
            };
        var filteredStudent = students.GroupBy(s=>s.Grade);
        foreach (var group in filteredStudent)
            {
                Console.WriteLine($"Grade:"+group.Key+" Count:"+group.Count());
                foreach (var student in group)
                {
                    Console.WriteLine($"Student Name: {student.Name}");

                }
                
            }
        }    
    }
}