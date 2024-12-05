using HW3Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HW3Project.Controllers
{
    public class MenuController : Controller
    {
        private static List<Meal> _meals = new List<Meal>
        {
            new Meal { Name = "Pancakes", Type = MealType.Breakfast, Ingredients = new List<string> { "Flour", "Eggs", "Milk" } },
            new Meal { Name = "Grilled Chicken Salad", Type = MealType.Lunch, Ingredients = new List<string> { "Chicken", "Lettuce", "Tomatoes" } },
            new Meal { Name = "Spaghetti Bolognese", Type = MealType.Dinner, Ingredients = new List<string> { "Pasta", "Ground Beef", "Tomato Sauce" } }
        };

        public IActionResult Index()
        {
            return View(_meals);
        }

        // Other action methods can be added here as needed
    }
}
