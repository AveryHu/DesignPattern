using System.Reflection;
namespace FactoryPattern
{
    public class AbstractFactory
    {
        private static readonly string AssemblyName = "FactoryPattern";
        public static IAbstractProductA CreateProductA(string name)
        {
            return (IAbstractProductA)Assembly
            .Load(AssemblyName)
            .CreateInstance(AssemblyName+"."+name);
        }
        public static IAbstractProductB CreateProductB(string name)
        {
            return (IAbstractProductB)Assembly
            .Load(AssemblyName)
            .CreateInstance(AssemblyName+"."+name);
        }
    }
}