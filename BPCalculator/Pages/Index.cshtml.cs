using Microsoft.AspNetCore.Mvc;            // ← for [BindProperty]
using Microsoft.AspNetCore.Mvc.RazorPages;
using BPCalculator.Core;                  // ← for your BloodPressure class

namespace BPCalculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int Systolic { get; set; }

        [BindProperty]
        public int Diastolic { get; set; }

        public string Category { get; private set; }

        public void OnGet() { }

        public void OnPost()
        {
            var bp = new BloodPressure { Systolic = Systolic, Diastolic = Diastolic };
            Category = bp.CategoryDisplay;
        }
    }
}