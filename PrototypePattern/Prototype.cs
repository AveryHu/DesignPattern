using System;

namespace PrototypePattern
{
    public interface Prototype
    {
        Prototype DeepClone();
        Prototype ShallowClone();
    }

    public class ID
    {
        public string _name {get;set;}
        public string _birthday {get;set;}
        public string _gender {get;set;}
        public Guid _id {get;set;}

        public ID(string name, string gender, string birthday)
        {
            this._id = Guid.NewGuid();
            this._name = name;
            this._gender = gender;
            this._birthday = birthday;
        }
    }

    public class Human : Prototype
    {
        public string _hobby {get;set;}
        public string _haircolor {get;set;}
        public ID _identity {get;set;}
        public Human(string hobby, string haircolor, ID identity)
        {
            this._hobby = hobby;
            this._haircolor = haircolor;
            this._identity = identity;
        }

        public Prototype DeepClone()
        {
            Human clone = (Human)this.MemberwiseClone();
            clone._identity = new ID(clone._identity._name
            , clone._identity._gender
            , clone._identity._birthday);
            
            return clone;
        }

        public Prototype ShallowClone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }
}