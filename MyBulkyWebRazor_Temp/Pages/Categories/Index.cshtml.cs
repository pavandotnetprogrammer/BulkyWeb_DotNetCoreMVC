using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBulkyWebRazor_Temp.Data;
using MyBulkyWebRazor_Temp.Models;

namespace MyBulkyWebRazor_Temp.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;
        public List<Category> CategoryList { get; set; }

        public IndexModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void OnGet()
        {
            CategoryList=dbContext.Categories.ToList();
        }
    }
}
