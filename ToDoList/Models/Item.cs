using System.Collections.Generic;

namespace Models
{
    public class Allergies
    {

        public string _name { get; set; }
        public int _value { get; set; }

        public static List<Allergies> allergens = new List<Allergies>();
        public Allergies(string name, int value)
        {
            _name = name;
            _value = value;
        }

        public static void ClearAll()
        {
            allergens.Clear();
        }

        public static List<string> FindAllergens(List<Allergies> list, int number)
        {
            List<string> allergenStrings = new List<string>();
            for (int i = list.Count - 1; i > 0; i--)
            {
                if (number >= list[i]._value)
                {
                    allergenStrings.Add(list[i]._name);
                    number -= list[i]._value;
                }
            }
            return allergenStrings;
        }









        // public static void ClearAll()
        // {
        //     _instances.Clear();
        // }
    }
}