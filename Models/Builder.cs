namespace ConsoleAppDemo.Models
{
    class Builder
    {
        public Builder()
        {
        
        }
        internal Builder _appBuilder;
        internal string _part1;
        internal string _part2;
        internal string _part3;

        internal Builder AddPart(string partName)
        {
            this._part1 = partName;
            return this;
        }

        internal Builder AddPart2(string partName)
        {
            this._part2 = partName;
            return this;
        }

        internal Builder AddPart3(string partName)
        {
            this._part3 = partName;
            return this;
        }
    }
}
