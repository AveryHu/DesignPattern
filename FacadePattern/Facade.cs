using System;

namespace FacadePattern
{
    public class Facade
    {        
        private Warrior _mywarrior;
        private Hunter _myhunter;
        private Wizard _mywizard;
        public Facade()
        {
            _mywarrior = new Warrior();
            _myhunter = new Hunter();
            _mywizard = new Wizard();
        }
        public void PhysicalAttack()
        {
            _mywarrior.Attack();
            _myhunter.Attack();
        }

        public void MagicalAttack()
        {
            _mywizard.Attack();
        }
    }
}