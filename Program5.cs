namespace DoSelectM1Assingmnet
{
    public delegate bool IsEligibleforScholarship(Student std);

    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public char SportsGrade { get; set; }

        //public Student(int RollNo,string Name,int Marks ,char SportsGrade)
        //{
        //    this.RollNo = RollNo;
        //    this.Name = Name;
        //    this.Marks = Marks;
        //    this.SportsGrade= SportsGrade;
        //}
        public static string GetEligibleStudents(List<Student> studentList,IsEligibleforScholarship isEligible)
        {
            string Result = "";
            foreach(var student in studentList)
            {
                if (isEligible(student)==true)
                {
                    if (Result == "")
                    {
                        Result += student.Name;
                    }
                    else
                    {
                        Result += ", " + student.Name;
                    }
                }
            }
            return Result;
        }
    }
    public class Program5
    {
        public static bool ScholarshipEligibility(Student std)
        {
            if(std.Marks>80 && std.SportsGrade == 'A')
            {
                return true;
            }
            return false;

        }
        public static void Main(string[] args)
        {
            List<Student> lstStudents = new List<Student>();
            Student obj1 = new Student() { RollNo = 1, Name = "Raj", Marks = 75, SportsGrade = 'A' };
            Student obj2 = new Student() { RollNo = 2, Name = "Rahul", Marks = 82, SportsGrade = 'A' };
            Student obj3 = new Student() { RollNo = 3, Name = "Kiran", Marks = 89, SportsGrade = 'B' };
            Student obj4 = new Student() { RollNo = 4, Name = "Sunil", Marks = 86, SportsGrade = 'A' };

            lstStudents.Add(obj1);
            lstStudents.Add(obj2);
            lstStudents.Add(obj3);
            lstStudents.Add(obj4);

            IsEligibleforScholarship DeleObj = new IsEligibleforScholarship(ScholarshipEligibility);
            var Result=Student.GetEligibleStudents(lstStudents, DeleObj);
            Console.WriteLine(Result);
        }
    }
}
