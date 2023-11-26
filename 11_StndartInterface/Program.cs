using System.Collections;

namespace _11_StandartInterface
{
    class StudentCard : ICloneable
    {
        public int Number { get; set; }//11111 - 11111
        public string Series { get; set; }//0c2c2c2 - 0c2c2c2

        public object Clone()
        {
            StudentCard copy = (StudentCard)this.MemberwiseClone();
            return copy;
        }

        public override string ToString()
        {
            return $"Student card : {Number} - {Series}";
        }
    }
    class Student :IComparable<Student>, ICloneable
    {
        public string FirstName { get; set; }//0x128 = 0x128
        public string LastName { get; set; }//0x123 = 0x123
        public DateTime Birthdate { get; set; }//2000 - 5 -3
        public StudentCard StudentCard { get; set; }//0x333 = 0x333

        public object Clone()
        {
            Student copy = (Student)this.MemberwiseClone();
            copy.FirstName = (string)this.FirstName.Clone();
            copy.LastName = (string)this.LastName.Clone();
            //copy.StudentCard = new StudentCard()
            //{
            //    Number = this.StudentCard.Number,
            //    Series = this.StudentCard.Series
            //};
            copy.StudentCard =(StudentCard) this.StudentCard.Clone();
            return copy;
        }

        public int CompareTo(Student? other)
        {
            return FirstName.CompareTo(other.FirstName);
        }

        //public int CompareTo(object? obj)
        //{
        //    return FirstName.CompareTo( (obj as Student).FirstName);
        //}

        public override string ToString()
        {
            return $"Name : {FirstName}. Last Name : {LastName}. Birthday : {Birthdate.ToShortDateString()}" +
                $"\n{StudentCard}\n";
        }
    }
    class Auditory : IEnumerable
    {
        Student[] students = null;//Array
        public Auditory()
        {
            students = new Student[]//Array
            {
                new Student
                {
                    FirstName = "Bill",
                    LastName = "Tomson",
                    Birthdate = new DateTime(2005, 4, 7),
                    StudentCard = new StudentCard() { Number = 123456, Series = "AA" }
                },
                new Student
                {
                    FirstName = "Olga",
                    LastName = "Ivanchuk",
                    Birthdate = new DateTime(2003, 10, 17),
                    StudentCard = new StudentCard() { Number = 321456, Series = "BA" }
                },
                new Student
                {
                    FirstName = "Candice",
                    LastName = "Leman",
                    Birthdate = new DateTime(2006, 3, 12),
                    StudentCard = new StudentCard() { Number = 7412585, Series = "AA" }
                },
                new Student
                {
                    FirstName = "Nicol",
                    LastName = "Taylor",
                    Birthdate = new DateTime(2004, 7, 14),
                    StudentCard = new StudentCard() { Number = 963258, Series = "BK" }
                }
             };
        }

        public IEnumerator GetEnumerator()
        {
            return students.GetEnumerator();
        }
        public void Sort()
        {
            Array.Sort(students);
        }
        public void Sort(IComparer<Student> comparer)
        {
            Array.Sort(students,comparer);
        }
    }

    class LastNameComparer : IComparer<Student>
    {
        //public int Compare(object? x, object? y)
        //{
        //    if (x is Student && y is Student)
        //    {
        //        return (x as Student).LastName.CompareTo((y as Student).LastName);
        //    }
        //    throw new NotImplementedException();
        //}
        public int Compare(Student? x, Student? y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
    class BirthdayComparer : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.Birthdate.CompareTo(y.Birthdate);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //StudentCard studentCard = new StudentCard() { Number = 11111, Series = "AA" };
            //StudentCard copy = (StudentCard)studentCard.Clone();
            //Console.WriteLine(studentCard);
            //Console.WriteLine(copy);
            //copy.Series = "BBB";
            //Console.WriteLine(studentCard);
            //Console.WriteLine(copy);

            Student original = new Student
            {
                FirstName = "Bill",
                LastName = "Tomson",
                Birthdate = new DateTime(2005, 4, 7),
                StudentCard = new StudentCard() { Number = 123456, Series = "AA" }
            };

            Student copy = (Student)original.Clone();
            Console.WriteLine(original);
            Console.WriteLine(copy);
            copy.StudentCard.Number = 1111111;
            Console.WriteLine(original);
            Console.WriteLine(copy);


            /*
            Auditory auditory = new Auditory();
            foreach (var item in auditory)
            {
                Console.WriteLine(item);
            }

            auditory.Sort();
            Console.WriteLine("__________Sort by First Name_______________");
            foreach (var item in auditory)
            {
                Console.WriteLine(item);
            }

            auditory.Sort(new LastNameComparer());
            Console.WriteLine("__________Sort by Last Name_______________");
            foreach (var item in auditory)
            {
                Console.WriteLine(item);
            }

            auditory.Sort(new BirthdayComparer());
            Console.WriteLine("__________Sort by Birthday_______________");
            foreach (var item in auditory)
            {
                Console.WriteLine(item);
            }
            */
        }
    }
}