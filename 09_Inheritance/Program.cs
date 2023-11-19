using System.Security.Cryptography;

namespace _09_Inheritance
{
    abstract class Person : Object
    {
        //private public protected
        protected string name;
        private readonly DateTime birthday;
        public Person()
        {
            name = "no name";
            birthday = new DateTime();
        }
        public Person(string n, DateTime d)
        {
            name = n;
            if (d > DateTime.Now)
                birthday = new DateTime();
            else
                birthday = d;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name : {name}\nBirthday {birthday.ToShortDateString()}");
        }
        public override string ToString()
        {
            return $"Name : {name}\nBirthday {birthday.ToShortDateString()}";
        }

        public abstract void DoWork();//pure virtual method
    }
    //class Name :  BaseClass, Interface1, Interface2, Interface3
    class Worker: Person //public
    {
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set 
            { 
                salary = value > 0 ? value : 0;    
            }
        }
        public Worker():base()
        {         
            Salary = 0;
        }
        public Worker(string n, DateTime d, decimal s):base(n,d)
        {
            Salary = s;
        }
        public override void DoWork()
        {
            Console.WriteLine("Doing some work!!!!");
        }
        //new - create new member and stop virtal
        //override 
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Salary {Salary}$");
        }
    }
    sealed class Programmer : Worker
    {
        public int CodeLines { get; private set; }
        public Programmer():base()
        {
            CodeLines = 0;  
        }
        public Programmer(string n, DateTime d, decimal s) : base(n,d,s)
        {
            CodeLines = 0;
        }
        public sealed override void DoWork()
        {
            Console.WriteLine("Write C# code!!!!");
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Code lines {CodeLines}$");
        }
        public void WriteLines()
        {
            CodeLines++;
        }
    }
    class TeamLead : Worker
    {
        public int CountProjects { get; set; }
        //public override void DoWork()
        //{
        //    Console.WriteLine("Manage team project!");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TeamLead teamLead = new TeamLead();
            teamLead.DoWork();

            Worker worker = new Worker("Andriy", new DateTime(2000,5,17),15000);
            worker.DoWork();
            worker.Print();
            Console.WriteLine();

            Person[] persons = new Person[]
            {
                //new Person(),
                worker,
                new Programmer("Bob",new DateTime(2005,12,31),45000)
            };

            foreach (var person in persons)
            {
                person.Print();Console.WriteLine(  );
            }

            Programmer pr = null;
            //use explicit type
            try
            {
                pr = (Programmer)persons[2];
                pr.DoWork();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            //use as
            pr = (persons[1] as Programmer)!;
          
            if (pr == null)
                Console.WriteLine("Incorrect type");
            else
                pr.DoWork();

            //use as and is
            if (persons[2] is Programmer)
            {
                pr = (persons[2] as Programmer)!;
                pr.DoWork();
            }
            else
            {
                Console.WriteLine("Incorrect type");
            }
           


        }
    }
}