using HW3Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HW3Project.Controllers
{
    public class DayMenuController : Controller
    {
        private static Dictionary<DateTime, DayMenu> _dayMenus = new Dictionary<DateTime, DayMenu>();

        public IActionResult Index()
        {
            // For demonstration purposes, assume we're showing the menu for today
            DateTime today = DateTime.Today;
            if (!_dayMenus.ContainsKey(today))
            {
                _dayMenus.Add(today, new DayMenu());
            }

            return View(_dayMenus[today]);
        }

        [HttpPost]
        public IActionResult AddMeal(Meal meal)
        {
            DateTime today = DateTime.Today;
            if (!_dayMenus.ContainsKey(today))
            {
                _dayMenus.Add(today, new DayMenu());
            }

            _dayMenus[today].AddMeal(meal);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveMeal(Meal meal)
        {
            DateTime today = DateTime.Today;
            if (_dayMenus.ContainsKey(today))
            {
                _dayMenus[today].RemoveMeal(meal);
            }

            return RedirectToAction("Index");
        }

        // Other action methods can be added here as needed
    }
}
