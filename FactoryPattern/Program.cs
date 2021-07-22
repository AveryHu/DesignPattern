using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the part of using simple factory pattern with static product creation funcion
            // Does not follow OCP. Adding another new product, you must modify current code. 
            // [One factory for all products]
            RunSimpleFactory();

            // This is the part of using factory method pattern. Each product has their own factory.
            // It follows OCP. However, you have to create as much factories as the number of your product types.
            // [One factory for one product]
            RunMethodFactory();

            // This is the part of using abstract factory pattern (Fine-tune version). 
            // It follows OCP. Only need to add a new class and the enum type for a new version of the product .
            // Add a new function in the factory if there is a new product. 
            // No need to create a new factory for the product in fine-tune version.
            // [One factory for all products with all series]
            RunAbstractFactory();
        }

        private static void RunSimpleFactory()
        {
            Console.WriteLine("------------start test simple factory------------");
            ISimpleProduct one = SimpleFactory.CreateProduct(SimpleProductType.SimpleProductOne);
            one.PrintName();
            ISimpleProduct two = SimpleFactory.CreateProduct(SimpleProductType.SimpleProductTwo);
            two.PrintName();
        }

        private static void RunMethodFactory()
        {
            Console.WriteLine("------------start test factory method pattern------------");
            IMethodFactory FactoryOne = new MethodProductOneFactory();
            IMethodProduct one = FactoryOne.CreateProduct();
            one.PrintName();
            IMethodFactory FactoryTwo = new MethodProductTwoFactory();
            IMethodProduct two = FactoryTwo.CreateProduct();
            two.PrintName();
        }

        private static void RunAbstractFactory()
        {
            Console.WriteLine("------------start test abstract factory (fine-tune version)------------");

            IAbstractProductA Aone = AbstractFactory
                .CreateProductA(AbstractProductAType.AbstractProductA_VersionOne.ToString());
            IAbstractProductA Atwo = AbstractFactory
                .CreateProductA(AbstractProductAType.AbstractProductA_VersionTwo.ToString());
            IAbstractProductB Bone = AbstractFactory
                .CreateProductB(AbstractProductBType.AbstractProductB_VersionOne.ToString());
            IAbstractProductB Btwo = AbstractFactory
                .CreateProductB(AbstractProductBType.AbstractProductB_VersionTwo.ToString());
            
            Aone.PrintName();
            Atwo.PrintName();
            Bone.PrintName();
            Btwo.PrintName();
        }
    }
}
