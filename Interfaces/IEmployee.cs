namespace ConsoleAppDemo.Interfaces
{
    public interface IEmployee 
    {
        string Name { get; set; }
        string Title { get; set; }
        string HireDate { get; set; }
        void Work();
        void Quit();
        void Promote();
    }
}
