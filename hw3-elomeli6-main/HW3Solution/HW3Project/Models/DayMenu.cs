using System.Collections.Generic;

namespace HW3Project.Models
{
    public class DayMenu
    {
        public List<Meal> Meals { get; set; }

        public DayMenu()
        {
            Meals = new List<Meal>();
        }

        // Method to add a meal to the day's menu
        public void AddMeal(Meal meal)
        {
            Meals.Add(meal);
        }

        // Method to remove a meal from the day's menu
        public bool RemoveMeal(Meal meal)
        {
            return Meals.Remove(meal);
        }
    }
}
