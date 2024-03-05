using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBulkyWebRazor_Temp.Data;
using MyBulkyWebRazor_Temp.Models;

namespace MyBulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class deleteModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;
        //[BindProperty]
        public Category Category { get; set; }

        public deleteModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void OnGet(int? id)
        {
            if (id != null && id != 0)
            {
                Category = dbContext.Categories.Find(id);
            }

        }
        public IActionResult OnPost()
        {
            Category? obj = dbContext.Categories.FirstOrDefault(u => u.Id == Category.Id);
            if (obj == null)
            {
                return NotFound();
            }
            dbContext.Categories.Remove(obj);
            dbContext.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToPage("Index");
        }
    }
}
