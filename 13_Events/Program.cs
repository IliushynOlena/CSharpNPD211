using System.Reflection.Metadata;

namespace _13_Events
{
    public delegate void FinishAction();
    public delegate void ExamDelegate(string task);

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public void PassExam(string task)
        {
            Console.WriteLine($"First Name : {FirstName}. Last Name : {LastName}. " +
                $"Date birthday {Birthday.ToShortDateString()}");
        }
    }
    class Teacher
    {
        //public event ExamDelegate ExamDelegate; // auto delegate
        //full deledate
        private ExamDelegate examDelegate;

        public event ExamDelegate ExamDelegate
        {
            add
            {
                examDelegate += value;
                Console.WriteLine(value.Method.Name + " was added!!!");
            }
            remove
            {
                examDelegate -= value;
                Console.WriteLine(value.Method.Name + " was remove!!!");
            }
        }

        public void CreateExam()
        {
            string task = "C# exam 24.12.2023 in Microsoft Teams";
           //exam creating
           //some code

            //call event 
            examDelegate?.Invoke(task);
        }

    }
    class Exachange
    {
        public double Course { get; set; }
        public void GenerateCourse()
        {
            Random random = new Random();
            Course = Math.Round(random.Next(30, 40) + random.NextDouble(), 2);
            Console.WriteLine(Course);

        }
        void CallTreaders()
        {
           // deledate.Invoke(Course);
        }
    }
    internal class Program
    {
        static void HardWork(FinishAction action)
        {

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Operation {i + 1}  working.....");
                Thread.Sleep(random.Next(500));
                Console.WriteLine($"Operation {i + 1}  finished.....");
            }

            action?.Invoke();
        }
        static void Action1()
        {
            Console.WriteLine("Bye bye");
        }
        static void Action2()
        {
            Console.WriteLine("Go to home. You are a good worker. ");
        }
        static void Main(string[] args)
        {


          
                Student[] students = new Student[]//Array
                {
                    new Student
                    {
                        FirstName = "Bill",
                        LastName = "Tomson",
                        Birthday = new DateTime(2005, 4, 7),
                    },
                    new Student
                    {
                        FirstName = "Olga",
                        LastName = "Ivanchuk",
                        Birthday = new DateTime(2003, 10, 17),
                    },
                    new Student
                    {
                        FirstName = "Candice",
                        LastName = "Leman",
                        Birthday = new DateTime(2006, 3, 12),
                    },
                    new Student
                    {
                        FirstName = "Nicol",
                        LastName = "Taylor",
                        Birthday = new DateTime(2004, 7, 14),

                    }
                };

            Teacher teacher = new Teacher();

            foreach (Student st in students)
            {
                teacher.ExamDelegate += new ExamDelegate(st.PassExam);
            }

            teacher.ExamDelegate -= students[3].PassExam;
            //teacher.ExamDelegate = null;

            teacher.CreateExam();

            }

            /*
            HardWork(Action1);
            HardWork(Action2);
            HardWork(delegate () { Console.WriteLine("You are a very cleaver human!!!"); });
            */
        
    }
}