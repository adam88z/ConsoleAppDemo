using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppDemo.Objects;

namespace ConsoleAppDemo.DesignPatterns.Builder
{
    internal class ConcreteBuilder<T> : AbstractBuilder
    {
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("PartA");
        }
        public override void BuildPartB()
        {
            _product.Add("PartB");
        }
        public override Product GetResult()
        {
            return _product;
        }
    }
}
