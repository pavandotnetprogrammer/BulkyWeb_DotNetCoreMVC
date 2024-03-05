using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBulkyWebRazor_Temp.Data;
using MyBulkyWebRazor_Temp.Models;

namespace MyBulkyWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class editModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;
        //[BindProperty]
        public Category Category { get; set; }

        public editModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void OnGet(int? id)
        {
            if(id!=null && id != 0)
            {
                Category = dbContext.Categories.Find(id);
            }

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                dbContext.Categories.Update(Category);
                dbContext.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
