using ConsoleAppDemo.Interfaces;

namespace ConsoleAppDemo.Employees
{
    internal class Developer : IEmployee
    {
        public string Name { get => "Green Genes"; set => throw new NotImplementedException(); }
        public string Title { get => "Saurekraut"; set => throw new NotImplementedException(); }
        public string HireDate { get => "2016"; set => throw new NotImplementedException(); }

        public void Promote()
        {
            Console.WriteLine("Employee has been promoted.");
        }

        public void Quit()
        {
            Console.WriteLine("Employee has quit.");
        }

        public void Work()
        {
            Console.WriteLine("Employee is working.");
        }
    }
}