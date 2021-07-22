using System;
namespace FactoryPattern
{
    public interface ISimpleProduct
    {
        void PrintName();
    }
    public enum SimpleProductType : int
    {
        SimpleProductOne = 1,
        SimpleProductTwo = 2
    }
    class SimpleProductOne : ISimpleProduct
    {        
        public void PrintName()
        {
            Console.WriteLine("I'm product one.");
        }
    }
    class SimpleProductTwo : ISimpleProduct
    {        
        public void PrintName()
        {
            Console.WriteLine("I'm product two.");
        }
    }
}