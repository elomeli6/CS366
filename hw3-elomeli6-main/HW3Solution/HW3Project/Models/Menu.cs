using System;
using System.Collections.Generic;

namespace HW3Project.Models
{
    public class Meal
    {
        public string Name { get; set; }
        public MealType Type { get; set; }
        public List<string> Ingredients { get; set; }

        public Meal()
        {
            Ingredients = new List<string>();
        }
    }

    public enum MealType
    {
        Breakfast,
        Lunch,
        Dinner
    }
}
