namespace consoleappdemo
{
    public class Person
    {
        private string? _name;
        public string? Name 
        {
             get { return _name; }
             set { _name = value; } 
        }

        private string? _iAmAPrivateMember
        {
            get { return "hi"; }
            set { _iAmAPrivateMember = "random"; }
        }

    }
}