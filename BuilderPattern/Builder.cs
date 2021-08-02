using System;

namespace BuilderPattern
{
    public abstract class HeroBuilder
    {
        public abstract HeroBuilder SetHairColor(string color);
        public abstract HeroBuilder SetWeapon(string weapon);
        public abstract HeroBuilder SetGender(string gender);
        public abstract HeroBuilder SetAge(string age);
        public abstract HeroBuilder SetZodiac(string zodiac);
        public abstract Hero BuildHero();
    }

    public class MyHeroBuilder : HeroBuilder
    {
        private string _haircolor;
        private string _weapon;
        private string _gender;
        private string _age;
        private string _zodiac;
        public override HeroBuilder SetHairColor(string haircolor)
        {
            this._haircolor = haircolor;         
            return this;
        }
        public override HeroBuilder SetWeapon(string weapon)
        {
            this._weapon = weapon;
            return this;
        }
        public override HeroBuilder SetGender(string gender)
        {
            this._gender = gender;
            return this;
        }
        public override HeroBuilder SetAge(string age)
        {
            this._age = age;
            return this;
        }
        public override HeroBuilder SetZodiac(string zodiac)
        {
            this._zodiac = zodiac;
            return this;
        }
        public override Hero BuildHero()
        {
            return new Hero(_haircolor
                    , _weapon, _gender
                    , _age, _zodiac);
        }
    }
}