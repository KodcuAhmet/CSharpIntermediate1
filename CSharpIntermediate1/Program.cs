#region
// OOP / INHERITENCE / CONSTRUCTORS
//namespace CSharpIntermediate1
//{
//    class Person
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        public Person(string firstName, string lastName)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//        }
//        public Person(string name)
//        {
//            // This is a second constructor, so we can choose which constructor we need
//        }
//        public virtual void Display()
//        {
//            Console.WriteLine("Person - {0}, {1}", LastName, FirstName);
//        }
//        public virtual int CalculateYearlyIncome(int year)
//        {
//            if (year < 2000)
//            {
//                return 50000;
//            }
//            return 10000;
//        }
//    }
//    class Employee : Person
//    {
//        public int YearlyIncome { get; set; }

//        // We have to create a new constructor because constructors don't get inherited
//        // We delegate some args to the base class by using ": base(...)"
//        public Employee(string firstName, string lastName, int yearlyIncome) : base(firstName, lastName)
//        {
//            YearlyIncome = yearlyIncome;
//        }
//        public override void Display()
//        {
//            Console.WriteLine("Employee - {0}, {1}, {2}", LastName, FirstName, YearlyIncome);
//        }

//        // virtual class is overriden and ".base.{method}" is used to use base method
//        public override int CalculateYearlyIncome(int year)
//        {
//            return base.CalculateYearlyIncome(year) * 100;
//        }

//        class Child : Employee
//        {
//            public Child() : base("first name", "second name", 1)
//            {
//                // This 3rd class is invoking only the constructor of its parent
//            }
//        }

//        internal class Program
//        {
//            static void Main(string[] args)
//            {
//                List<Person> people = new List<Person>();

//                Person p1 = new Person("Nelson", "LeQuet");
//                people.Add(p1);

//                Employee e1 = new Employee("Whoa", "Hey", 23);
//                people.Add(e1);

//                for (int i = 0; i < 5; i++)
//                {
//                    people.Add(GetPersonFromInput());
//                }

//                foreach (Person person in people)
//                {
//                    person.Display();
//                }
//                Console.ReadKey();
//            }
//            static Person GetPersonFromInput()
//            {
//                while (true)
//                {
//                    Console.WriteLine("[1] - Person\n[2] - Employee");
//                    int choice = int.Parse(Console.ReadLine());

//                    if (choice == 1)
//                    {
//                        return new Person(GetString("First Name"), GetString("Last Name"));
//                    }

//                    if (choice == 2)
//                    {
//                        return new Employee(GetString("First Name"), GetString("Last Name"), GetInt("Yearly Income"));
//                    }
//                }
//            }
//            static int GetInt(string prompt)
//            {
//                Console.Write("{0}> ", prompt);
//                return int.Parse(Console.ReadLine());
//            }

//            static string GetString(string prompt)
//            {
//                Console.Write("{0}> ", prompt);
//                return Console.ReadLine();
//            }
//        }
//    }
//}
#endregion

#region
// VIRTUAL / OVERRIDE CLASS
//namespace CSharpIntermediate1
//{
//    class Item
//    {
//        public virtual void Display() { }
//        public virtual void Use() { }
//    }
//    class Chair : Item
//    {
//        private string _model;
//        public Chair(string model)
//        {

//            _model = model;
//        }
//        public override void Display()
//        {
//            Console.WriteLine("Chair model: {0}", _model);
//        }
//        public override void Use()
//        {
//            Console.WriteLine("You sat down!");
//        }
//    }
//    class Potion : Item
//    {
//        private string _type;
//        public Potion(string type)
//        {

//            _type = type;
//        }
//        public override void Display()
//        {
//            Console.WriteLine("Potion model: {0}", _type);
//        }
//        public override void Use()
//        {
//            Console.WriteLine("Stuff happened!");
//        }
//    }
//    class Gun : Item
//    {
//        private string _type;
//        public Gun(string type)
//        {

//            _type = type;
//        }
//        public override void Display()
//        {
//            Console.WriteLine("Gun model: {0}", _type);
//        }
//        public override void Use()
//        {
//            Console.WriteLine("BANG!");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Item> inventory = new List<Item>();
//            inventory.Add(new Chair("Stuff"));
//            inventory.Add(new Gun("AR-15"));
//            inventory.Add(new Potion("Health"));

//            foreach (Item item in inventory)
//            {
//                item.Display();
//                item.Use();
//            }

//            Console.ReadKey();
//        }
//        static int GetInt(string prompt)
//        {
//            Console.Write("{0}> ", prompt);
//            return int.Parse(Console.ReadLine());
//        }

//        static string GetString(string prompt)
//        {
//            Console.Write("{0}> ", prompt);
//            return Console.ReadLine();
//        }
//    }
//}

#endregion

#region
//// ABSTRACT CLASS
//// Abstract classes do not have implementation, only signature.
//// There is no default implementation of the abstract class/method.
//// Abstract classes enforce implementation if inherited.

//namespace CSharpIntermediate1
//{
//    // If there is any abstract method or class in a parent class, then the parent class must be also abstract
//    // In other words, there must be at least one child abstract class in a parent abstract class
//    abstract class Item
//    {
//        public abstract void Display();
//        public abstract void Use();
//    }
//    class Chair : Item
//    {
//        private string _model;
//        public Chair(string model)
//        {

//            _model = model;
//        }
//        public override void Display()
//        {
//            Console.WriteLine("Chair model: {0}", _model);
//        }
//        public override void Use()
//        {
//            Console.WriteLine("You sat down!");
//        }
//    }
//    class Potion : Item
//    {
//        private string _type;
//        public Potion(string type)
//        {

//            _type = type;
//        }
//        public override void Display()
//        {
//            Console.WriteLine("Potion model: {0}", _type);
//        }
//        public override void Use()
//        {
//            Console.WriteLine("Stuff happened!");
//        }
//    }
//    class Gun : Item
//    {
//        private string _type;
//        public Gun(string type)
//        {

//            _type = type;
//        }
//        public override void Display()
//        {
//            Console.WriteLine("Gun model: {0}", _type);
//        }
//        public override void Use()
//        {
//            Console.WriteLine("BANG!");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Item> inventory = new List<Item>();
//            inventory.Add(new Chair("Stuff"));
//            inventory.Add(new Gun("AR-15"));
//            inventory.Add(new Potion("Health"));

//            foreach (Item item in inventory)
//            {
//                item.Display();
//                item.Use();
//            }

//            Console.ReadKey();
//        }
//        static int GetInt(string prompt)
//        {
//            Console.Write("{0}> ", prompt);
//            return int.Parse(Console.ReadLine());
//        }

//        static string GetString(string prompt)
//        {
//            Console.Write("{0}> ", prompt);
//            return Console.ReadLine();
//        }
//    }
//}

#endregion

#region

//// Inheritence and abstract classes used in an algorithm called TEMPLATE METHOD

//namespace CSharpIntermediate1
//{
//    abstract class EvenNumbergenerator
//    {
//        public void Run(int min, int max)
//        {
//            for (int i = min; i <= max; i++)
//            {
//                if ((i % 2) == 0)
//                {
//                    ProcessNumber(i);
//                }
//            }
//        }
//        public abstract void ProcessNumber(int number);
//    }

//    class ConsoleEvenNumberPrinter : EvenNumbergenerator
//    {
//        public override void ProcessNumber(int number)
//        {
//            Console.WriteLine("Even number: {0}", number);
//        }
//    }

//    class FileEvenNumberPrinter : EvenNumbergenerator
//    {
//        public override void ProcessNumber(int number)
//        {
//            Console.WriteLine("Pretend this is prtinted on a file: {0}", number);
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            ConsoleEvenNumberPrinter printer = new ConsoleEvenNumberPrinter();
//            printer.Run(1, 200);

//            FileEvenNumberPrinter printer2 = new FileEvenNumberPrinter();
//            printer2.Run(200, 500);

//            Console.ReadKey();
//        }
//    }
//}

#endregion

#region

namespace CSharpIntermediate1
{
    class GraphicsCard
    {
        public virtual void Render()
        {

        }
    }
    class CPU
    {
        public int CountOfCores { get; private set; }
        public CPU(int countOfCores)
        {
            CountOfCores = countOfCores;
        }

        public virtual void Compute()
        {

        }
    }
    class Motherboard
    {
        public virtual void DoStuff()
        {

        }
    }
    class Computer
    {
        public GraphicsCard GraphicsCard { get; private set; }
        public CPU CPU { get; private set; }
        public Motherboard Motherboard { get; private set; }
        public Computer(GraphicsCard graphicsCard, CPU cpu, Motherboard motherboard)
        {
            GraphicsCard = graphicsCard;
            CPU = cpu;
            Motherboard = motherboard;
        }
        public void Run()
        {
            CPU.Compute();
            GraphicsCard.Render();
            Motherboard.DoStuff();
        }
    }
    class NVidia : GraphicsCard
    {
        private string _series;
        public NVidia(string series)
        {
            _series = series;
        }
        public override void Render()
        {
            Console.WriteLine("Rendering GraphicsCard with series {0}", _series);
        }
    }
    class Intel : CPU
    {
        private string _series;
        public Intel(int cores, string series) : base(cores)
        {
            _series = series;
        }
        public override void Compute()
        {
            Console.WriteLine("Intel CPU: series {0} with {1} cores", _series, CountOfCores);
        }
    }
    class Asus : Motherboard
    {
        private string _series;
        private string _cpuSocket;
        public Asus(string series, string cpuSocket)
        {
            _series = series;
            _cpuSocket = cpuSocket;
        }
        public override void DoStuff()
        {
            Console.WriteLine("Doing stuff with Asus mobo {0} with cpu socket {1}", _series, _cpuSocket);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer(new NVidia("GTX 500"), new Intel(4, "i7"), new Asus("stuff", "LG6013"));
            computer.Run();

            Console.ReadKey();
        }
    }
}

#endregion

#region

//\\// HOMEWORK \\//\\
// Create an abstract Pet class that has abstract functionality (at least 3 methods).
// It must have a "string Name" read-only property that is filled by a paramater to the ctor.
// At least one of the methods must take in paramaters,
// and at least one of the methods must return a value instead of printing things to the console.
// Create four implementations of the Pet class that all appropriately implement the different methods.
// Allow the user to enter 0 to many pets (can be any type) and store them into a List<Pet> object.
// After the user is done entering in pets, allow the user to
// A) select a pet
// B) perform an operation
// - You will have to collect the arguments from the user required to invoke a method that has paramaters. C) Repeat A-B until the user decides to quit

#endregion