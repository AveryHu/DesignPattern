using System;

namespace BuilderPattern
{
    public class HeroStore {        
        private HeroBuilder _builder;
        public HeroStore(HeroBuilder builder) {
            this._builder = builder;
        }
        public Hero Male_OldWarrior_White_Aries() {
            return _builder.SetGender("Male")
                        .SetAge("60")
                        .SetHairColor("White")
                        .SetWeapon("Sword")
                        .SetZodiac("Aries")
                        .BuildHero();
        }
        public Hero FeMale_YoungHunter_Yellow_Virgo() {
            return _builder.SetGender("Female")
                        .SetAge("21")
                        .SetHairColor("Yellow")
                        .SetWeapon("Bow")
                        .SetZodiac("Virgo")
                        .BuildHero();
        }
    }
}