namespace Homework9;
    class Program
    {
        static void Main(string[] args)
        {
            Student Alice = new Student(111, "Alice");
            Student Bob = new Student(222, "Bob");
            Student Cathy = new Student(333, "Cathy");
            Student David = new Student(444, "David");

            Dictionary<string, double> gradebook = new Dictionary<string, double>
            {
                { "Alice", 4.0 },
                { "Bob", 3.6 },
                { "Cathy", 2.5 },
                { "David", 1.8 }
            };

            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook["Tom"] = 3.3;
            }

            double averageGPA = gradebook.Values.Average();
            Console.WriteLine($"The average GPA is: {averageGPA:F2}");
            foreach (var entry in gradebook)
            {
                if (entry.Value > averageGPA)
                {
                    var student = Student.studentList.Find(s => s.StudentName == entry.Key);
                    if (student != null)
                    {
                        student.PrintInfo();
                    }
                }
            }
        }
    }

    class Student
    {
        private int studentID;
        private string studentName;
        public static List<Student> studentList = new List<Student>();

        public string StudentName => studentName;
        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            studentList.Add(this);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
        }
    }