using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Akopyants
{
    [My_attribute("abstract animal")]
    public abstract class Animal
    {
        public Animal() { }

        public Animal(string _country, bool _hide_from_other_animals, string _name, string _what_animal)
            => (country, hide_from_other_animals, name, what_animal) = (_country, _hide_from_other_animals, _name, _what_animal);


        public virtual void Deconstruct(out string _country, out bool _hide_from_other_animals, out string _name, out string _what_animal)
        {
            _country = country;
            _hide_from_other_animals = hide_from_other_animals;
            _name = name;
            _what_animal = what_animal;
        }


        public virtual eClassification_animal get_classification() => Classification;

        public virtual eFavorite_food get_favorite_food() => favorite_food;

        public enum eClassification_animal
        {
            Hervivores,
            Carnivores,
            Omnivores
        }
        public virtual void say_hello() { }

        public enum eFavorite_food
        {
            Plants,
            Meat,
            Everything
        }
        public eFavorite_food favorite_food;
        public eClassification_animal Classification;
        public string country { set; get; }
        public bool hide_from_other_animals { set; get; }
        public string name { set; get; }
        public string what_animal { set; get; }
    }
}
