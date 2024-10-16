using ConsoleAppDemo.Repositories;
using ConsoleAppDemo.Interfaces;
using ConsoleAppDemo.Models;
using System.Diagnostics;
using System.Threading;
using ConsoleAppDemo.Employees;

internal class Program
{
    // Static because how can you instantiate
    private static void Main(string[] args)
    {
        Console.WriteLine("Begin");
        EmployeeExample();
    }

    public static void EmployeeExample()
    {
        //TODO - AJ -
        // Make a Module Interface that is able to start these concrete classes for SalesMan and Developer.
        // Loop through the list of interfaces to start up the concrete classes as a way of cleaning up this Main method.
        // and compartmentalizing / turning the stuff into modules that can be easily turner on / off.
    
        IEmployee developer = new Developer();
        Salesman salesman = new Salesman();
        
        List<IEmployee> employees = new List<IEmployee>
        {
            new Developer(),
            new Salesman()
        };

        foreach(var employee in employees)
        {
            employee.Promote();
        }
    }

}