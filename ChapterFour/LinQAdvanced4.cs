namespace Chapter4
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }

    class Enrollment
    {
        public int StudentId { get; set; }
        public string CourseName { get; set; }
    }

    class Advance4
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { StudentId = 1, Name = "John" },
                new Student { StudentId = 2, Name = "Jane" },
                new Student { StudentId = 3, Name = "Alex" }
            };

            List<Enrollment> enrollments = new List<Enrollment>
            {
                new Enrollment { StudentId = 1, CourseName = "Math" },
                new Enrollment { StudentId = 2, CourseName = "Science" },
                new Enrollment { StudentId = 4, CourseName = "History" }
            };
            var resultJoin = students.Join(enrollments, str1 => str1.StudentId, str2 => str2.StudentId, (str1, str2) => new { str1.Name, str2.CourseName });
            foreach (var result in resultJoin)
            {
                Console.WriteLine($"Student: {result.Name}, Enrollment: {result.Name}");
            }
        }
    }
}