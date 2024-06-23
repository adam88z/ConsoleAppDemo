using ConsoleAppDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo.Repositories
{
    /// <summary>
    /// In C#, a repository is a design pattern commonly used to abstract and encapsulate the data access layer. 
    /// It provides a structured way to interact with data storage, such as databases, 
    /// without directly coupling the application's business logic to the specific data access technology or implementation details
    /// </summary>
    internal class EmployeeRepository
    {
        private string? _test = "Default Test value";
        public string Test
        {
            get { return _test; }
            set { _test = value; }
        }
        public string HeresSomeJunk(string input)
        {
            string output = input;
            return output;
        }
    }
}
