using System;
namespace FactoryPattern
{
    public interface IAbstractProductA
    {
        void PrintName();
    }
    public interface IAbstractProductB
    {
        void PrintName();
    }
    public enum AbstractProductAType : int
    {
        AbstractProductA_VersionOne = 1,
        AbstractProductA_VersionTwo = 2,
    }
    public enum AbstractProductBType : int
    {
        AbstractProductB_VersionOne = 1,
        AbstractProductB_VersionTwo = 2,
    }
    class AbstractProductA_VersionOne : IAbstractProductA
    {        
        public void PrintName()
        {
            Console.WriteLine("I'm product A [version one].");
        }
    }
    class AbstractProductA_VersionTwo : IAbstractProductA
    {        
        public void PrintName()
        {
            Console.WriteLine("I'm product A [version two].");
        }
    }
    class AbstractProductB_VersionOne : IAbstractProductB
    {        
        public void PrintName()
        {
            Console.WriteLine("I'm product B [version one].");
        }
    }
    class AbstractProductB_VersionTwo : IAbstractProductB
    {        
        public void PrintName()
        {
            Console.WriteLine("I'm product B [version two].");
        }
    }
}