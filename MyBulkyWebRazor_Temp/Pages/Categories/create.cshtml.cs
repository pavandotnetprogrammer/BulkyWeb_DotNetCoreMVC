using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBulkyWebRazor_Temp.Data;
using MyBulkyWebRazor_Temp.Models;

namespace MyBulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class createModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;
        //[BindProperty]
        public Category Category { get; set; }

        public createModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost() 
        {
            dbContext.Categories.Add(Category);
            dbContext.SaveChanges();
            TempData["success"] = "Category Created successfully";
            return RedirectToPage("Index");
        
        }
    }
}
