using System;

namespace BuilderPattern
{
    public class Hero
    {
        private string _haircolor;
        private string _weapon;
        private string _gender;
        private string _age;
        private string _zodiac;

        public Hero(string haircolor
        , string weapon, string gender
        , string age, string zodiac)
        {
            this._haircolor = haircolor;
            this._weapon = weapon;
            this._gender = gender;
            this._age = age;
            this._zodiac = zodiac;
        }

        public override string ToString()
        {
            string detail = " ----- Hero Detail ----- \n" +
            " Hair Color : " + _haircolor + "\n" +
            " Weapon : " + _weapon + "\n" +
            " Gender : " + _gender + "\n" +
            " Age : " + _age + "\n" +
            " Zodiac : " + _zodiac + "\n";
            return detail;
        }
    }   
}