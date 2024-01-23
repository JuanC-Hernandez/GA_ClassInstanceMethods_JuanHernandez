namespace GA_ClassInstanceMethods_JuanHernandez
{
    internal class Program
    {
        //Juan Hernandez
        // Guided Assignment: Class Instance Methods
        // 01/22/2024
        static void Main(string[] args)
        {
            // Create a list of 5 grades ranging between 0 and 100
            List<int> willGrades = new List<int> { 85, 92, 78, 90, 88 };

            // Create a new instance of the Student class with the name "Will" and the grades list
            Student willStudent = new Student("Will", willGrades);

            willStudent.AddGrade(78); // Success
            willStudent.AddGrade(200); // Fails
            willStudent.AddGrade(-130); // Fails
            //Console.WriteLine($"{willStudent.Name}: {willStudent.ExamScores.ToString}");
            willStudent.DisplayAllGrades();

            willStudent.GetGrade();

            willStudent.DisplayStudentInfo();

            List<Student> randomStudents = GenerateRandomStudents();
            randomStudents.Add(willStudent);
            //loop
            foreach (Student student in randomStudents)
            {
                student.DisplayStudentInfo();
            }
            static List<Student> GenerateRandomStudents()
            {
                List<Student> students = new List<Student>();
                Random random = new Random(); // Random object created here

                for (int i = 1; i <= 5; i++)
                {
                    Student student = new Student($"Student{i}");

                    for (int j = 0; j < 5; j++)
                    {
                        student.ExamScores.Add(random.Next(0, 101));
                    }

                    students.Add(student);
                }

                return students;
            }
        }

    }// Main
}// Program