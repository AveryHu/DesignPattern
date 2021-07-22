namespace FactoryPattern
{
    public class SimpleFactory
    {
        public static ISimpleProduct CreateProduct(SimpleProductType type)
        {
            switch(type)
            {
                case SimpleProductType.SimpleProductOne:
                    return new SimpleProductOne();
                case SimpleProductType.SimpleProductTwo:
                    return new SimpleProductTwo();
                default:
                    throw new System.Exception("No this type of product");
            }
            throw new System.Exception("No this type of product");
        }
    }
}