namespace ConsoleAppDemo.Models
{
    class Builder
    {
        public Builder()
        {
        
        }
        internal Builder _appBuilder { get; set; } = new Builder();
        internal string _part1 { get; set; } = string.Empty;
        internal string _part2 { get; set; } = string.Empty;
        internal string _part3 { get; set; } = string.Empty;

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
