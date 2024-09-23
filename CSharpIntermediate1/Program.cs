
#region
namespace CSharpIntermediate1
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Display()
        {
            Console.WriteLine("Person - {0}, {1}", LastName, FirstName);
        }
    }

    class Employee : Person
    {
        public int YearlyIncome { get; set; }
        public override void Display()
        {
            Console.WriteLine("Employee - {0}, {1}, {2}", LastName, FirstName, YearlyIncome);
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                List<Person> people = new List<Person>();
                //Person p1 = new Person();
                //p1.FirstName = "Nelson";
                //p1.LastName = "LaQuet";
                //people.Add(p1);

                //Employee nelson = new Employee();
                //nelson.FirstName = "Nelson";
                //nelson.LastName = "LaQuet";
                //nelson.YearlyIncome = 10;
                //people.Add(nelson);

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
                        Person person = new Person();
                        person.FirstName = GetString("First Name");
                        person.LastName = GetString("Last Name");
                        return person;
                    }

                    if (choice == 2)
                    {
                        Employee employee = new Employee();
                        employee.FirstName = GetString("First Name");
                        employee.LastName = GetString("Last Name");

                        Console.WriteLine("Yearly Income: ");
                        employee.YearlyIncome = int.Parse(Console.ReadLine());
                        return employee;
                    }
                }
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