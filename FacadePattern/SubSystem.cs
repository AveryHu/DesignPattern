using System;

namespace FacadePattern
{
    public class Warrior
    {
        public void Attack()
        {
            Console.WriteLine("Slash !!!!!!!!!!!!!");
        }
    }

    public class Hunter
    {
        public void Attack()
        {
            Console.WriteLine("Shoot ---->  ----> ");
        }
    }

    public class Wizard
    {
        public void Attack()
        {
            Console.WriteLine("Fireball ~ <<))))");
        }
    }
}