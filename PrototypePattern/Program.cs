using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using Prototype pattern, avoid the complex initialization which might cost a lot of resources.
            // By different situation, you need to choose whether deep clone or shallow clone to use.
            RunPrototype();
        }

        private static void RunPrototype()
        {
            Human Adam = new Human("Swimming", "Golden", new ID("Adam", "Male", "0000/01/01"));
            Human DeepCloneAdam = (Human)Adam.DeepClone();
            Human ShallowCloneAdam = (Human)Adam.ShallowClone();

            PrintInfoForCompare(Adam, DeepCloneAdam, ShallowCloneAdam);
            Console.WriteLine("\n xxxxxxxxxxxxxxxx Update Real Adam Information xxxxxxxxxxxxxxxx \n");            
            Adam._hobby = "Eatting";
            Adam._haircolor = "Green";
            Adam._identity._name = "Eva";
            Adam._identity._gender = "Female";
            Adam._identity._birthday = "2021/04/04";
            PrintInfoForCompare(Adam, DeepCloneAdam, ShallowCloneAdam);
        }

        private static void PrintInfoForCompare(Human Adam, Human DeepCloneAdam, Human ShallowCloneAdam)
        {
            Console.WriteLine("============ Real Adam / Shallow Adam / Deep Adam ============");
            Console.WriteLine("Hobby : " + Adam._hobby + " / " 
            + ShallowCloneAdam._hobby + " / " 
            + DeepCloneAdam._hobby);
            Console.WriteLine("Hair Color : " + Adam._haircolor 
            + " / " + ShallowCloneAdam._haircolor 
            + " / " + DeepCloneAdam._haircolor);
            Console.WriteLine("Identity : ");
            Console.WriteLine("Name : " + Adam._identity._name 
            + " / " + ShallowCloneAdam._identity._name 
            + " / " + DeepCloneAdam._identity._name);
            Console.WriteLine("Birth : " + Adam._identity._birthday 
            + " / " + ShallowCloneAdam._identity._birthday 
            + " / " + DeepCloneAdam._identity._birthday);
            Console.WriteLine("Gender : " + Adam._identity._gender 
            + " / " + ShallowCloneAdam._identity._gender 
            + " / " + DeepCloneAdam._identity._gender);
            Console.WriteLine("ID : " + Adam._identity._id 
            + " / " + ShallowCloneAdam._identity._id 
            + " / " + DeepCloneAdam._identity._id);
        }
    }
}
