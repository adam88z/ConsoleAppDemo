using ConsoleAppDemo.Interfaces;

namespace ConsoleAppDemo.Employees
{
    internal class Salesman : IEmployee
    {
        public string Name { get => "MrBigShot"; set => throw new NotImplementedException(); }
        public string Title { get => "BrownNosing"; set => throw new NotImplementedException(); }
        public string HireDate { get => "1980"; set => throw new NotImplementedException(); }

        public void Promote()
        {
            Console.WriteLine("Salesman has been promoted.");
        }

        public void Quit()
        {
            Console.WriteLine("Salesman said F'it.");
        }

        public void Work()
        {
            Console.WriteLine("Salesman is working over some suckers.");
        }
    }
}