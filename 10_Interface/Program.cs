namespace _10_Interface
{    
    interface IWorker
    {
        event EventHandler WorkEnded;
        public bool IsWorking { get; set; }
        string Work();
    }

    abstract class Human: Object
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public override string ToString()
        {
            return $"First name : {FirstName}. \nLast name : {LastName}. " +
                $"\nBirthday : {Birthday.ToShortDateString()}";
        }
    }
    abstract class Employee : Human
    {
        public string Position { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"\nPosition : {Position} . \nSalary : { Salary}";
        }
    }
    interface IWorkable
    {
        bool IsWorking { get;  }
        string Work();
    }
    interface IManager
    {
        List<IWorkable> ListOfWorkers { get; set; }
        void Organize();
        void MakeBudget();
        void Control();
    }
    class Director : Employee, IManager//implement/realize interface
    {
        public List<IWorkable> ListOfWorkers { get; set ; } // = null

        public void Control()
        {
            Console.WriteLine("I am controling work!!!");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I make budject!!!!");
        }

        public void Organize()
        {
            Console.WriteLine("I organize work!!!");
        }
    }
    class Seller : Employee, IWorkable
    {
        public bool IsWorking =>true;

        public string Work()
        {
            return "I am selling product!";
        }
    }
    class Cashier : Employee, IWorkable
    {
        public bool IsWorking => true;

        public string Work()
        {
            return "I get the pay for product!";
        }
    }
    class Administrator : Employee, IWorkable, IManager
    {
        public List<IWorkable> ListOfWorkers { get ; set; }
        //public List<Employee> ListOfWorkers1 { get ; set; }

     
        public bool IsWorking => true;

        public void Control()
        {
            Console.WriteLine("Xaxaxaaxxa. I am A BOSSS!!!");
        }

        public void MakeBudget()
        {
            Console.WriteLine("I have a million!!!");
        }

        public void Organize()
        {
            Console.WriteLine("I organize work");
        }

        public string Work()
        {
            return "I do my work((((((((";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Director director = new Director
            IManager director = new Director
            {
                FirstName = "Bob",
                LastName = "Tomson",
                Birthday = new DateTime(1967, 12, 5),
                Position = "Director",
                Salary = 45000

            };
            

           
            //director.Salary = 5;
            Console.WriteLine(director);
            director.Organize();
            director.MakeBudget();
            director.Control();

            IWorkable seller = new Seller
            {
                FirstName = "Olga",
                LastName = "Ivanchuk",
                Birthday = new DateTime(1995,7, 15),
                Position = "Seller",
                Salary = 10000
            };
            //seller.Salary = 45000;
            Console.WriteLine(seller.Work()); 
            Console.WriteLine(seller);

            if(seller is Employee)
                Console.WriteLine( $"Seller salary : {(seller as Employee).Salary}" );

            director.ListOfWorkers = new List<IWorkable>
            {
                  seller,
                  new Administrator
                  {
                      FirstName = "Sasha",
                    LastName = "Oliunuk",
                    Birthday = new DateTime(1985, 5, 17),
                    Position = "Administrator",
                    Salary = 21000
                  },
                  new Cashier
                  {
                      FirstName = "Ivanka",
                    LastName = "Petruc",
                    Birthday = new DateTime(2001, 5, 17),
                    Position = "Cashier",
                    Salary = 1000
                  }
            };
           
            Console.WriteLine();
            foreach (var item in director.ListOfWorkers)
            {
                Console.WriteLine(item);

                if(item is Cashier)
                    Console.WriteLine("Cashier");

                if(item.IsWorking)
                    Console.WriteLine(item.Work());
                Console.WriteLine("________________________________");
            }

            //Multiple interaces
            Administrator admin = new Administrator();            

            IManager manager = admin;
            manager.Control();         

            IWorkable worker = admin;           
            worker.Work();

        }
    }
}