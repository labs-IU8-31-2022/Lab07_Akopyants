using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Akopyants
{
    [My_attribute("Cow")]
    public class Cow : Animal
    {
        public Cow() : base() { }

        public Cow(string _country, bool _hide_from_other_animals, string _name, string _what_animal)
            : base(_country, _hide_from_other_animals, _name, _what_animal) { }



        public override void Deconstruct(out string _country, out bool _hide_from_other_animals, out string _name, out string _what_animal)
        {
            _country = country;
            _hide_from_other_animals = hide_from_other_animals;
            _name = name;
            _what_animal = what_animal;
        }


        public override eClassification_animal get_classification() => eClassification_animal.Hervivores;
        public override eFavorite_food get_favorite_food() => eFavorite_food.Plants;

        public override void say_hello()
        {
            Console.WriteLine("Mooooooooo!");
        }

    }
}
