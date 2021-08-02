using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Builder pattern, making object creation become easier.
            // Try this when the object have a complex constructor or customization object is needed in the future.
            RunBuilder();
        }

        private static void RunBuilder()
        {
            HeroBuilder builder = new MyHeroBuilder();
            HeroStore herostore = new HeroStore(builder);
            Console.WriteLine(herostore.Male_OldWarrior_White_Aries().ToString());
            Console.WriteLine(herostore.FeMale_YoungHunter_Yellow_Virgo().ToString());
        }
    }
}
