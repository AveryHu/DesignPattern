using System;
namespace FactoryPattern
{
    public interface IMethodProduct
    {
        void PrintName();
    }
    public enum MethodProductType : int
    {
        MethodProductOne = 1,
        MethodProductTwo = 2
    }
    class MethodProductOne : IMethodProduct
    {        
        public void PrintName()
        {
            Console.WriteLine("I'm product one.");
        }
    }
    class MethodProductTwo : IMethodProduct
    {        
        public void PrintName()
        {
            Console.WriteLine("I'm product two.");
        }
    }
}