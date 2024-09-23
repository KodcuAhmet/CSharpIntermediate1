
#region
namespace CSharpIntermediate1
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(string name)
        {
            // This is a second constructor, so we can choose which constructor we need
        }
        public virtual void Display()
        {
            Console.WriteLine("Person - {0}, {1}", LastName, FirstName);
        }
        public virtual int CalculateYearlyIncome(int year)
        {
            if (year < 2000)
            {
                return 50000;
            }
            return 10000;
        }
    }
    class Employee : Person
    {
        public int YearlyIncome { get; set; }

        // We have to create a new constructor because constructors don't get inherited
        // We delegate some args to the base class by using ": base(...)"
        public Employee(string firstName, string lastName, int yearlyIncome) : base(firstName, lastName)
        {
            YearlyIncome = yearlyIncome;
        }
        public override void Display()
        {
            Console.WriteLine("Employee - {0}, {1}, {2}", LastName, FirstName, YearlyIncome);
        }

        // virtual class is overriden and ".base.{method}" is used to use base method
        public override int CalculateYearlyIncome(int year)
        {
            return base.CalculateYearlyIncome(year) * 100;
        }

        class Child : Employee
        {
            public Child() : base("first name", "second name", 1)
            {
                // This 3rd class is invoking only the constructor of its parent
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                List<Person> people = new List<Person>();

                Person p1 = new Person("Nelson", "LeQuet");
                people.Add(p1);

                Employee e1 = new Employee("Whoa", "Hey", 23);
                people.Add(e1);

                for (int i = 0; i < 5; i++)
                {
                    people.Add(GetPersonFromInput());
                }

                foreach (Person person in people)
                {
                    person.Display();
                }
                Console.ReadKey();
            }
            static Person GetPersonFromInput()
            {
                while (true)
                {
                    Console.WriteLine("[1] - Person\n[2] - Employee");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        return new Person(GetString("First Name"), GetString("Last Name"));
                    }

                    if (choice == 2)
                    {
                        return new Employee(GetString("First Name"), GetString("Last Name"), GetInt("Yearly Income"));
                    }
                }
            }
            static int GetInt(string prompt)
            {
                Console.Write("{0}> ", prompt);
                return int.Parse(Console.ReadLine());
            }

            static string GetString(string prompt)
            {
                Console.Write("{0}> ", prompt);
                return Console.ReadLine();
            }
        }
    }
}
#endregion