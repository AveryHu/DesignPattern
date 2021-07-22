namespace FactoryPattern
{
    public interface IMethodFactory
    {
        IMethodProduct CreateProduct();
    }

    public class MethodProductOneFactory : IMethodFactory
    {
        public IMethodProduct CreateProduct()
        {
            return new MethodProductOne();
        }
    }

    public class MethodProductTwoFactory : IMethodFactory
    {
        public IMethodProduct CreateProduct()
        {
            return new MethodProductTwo();
        }
    }
}