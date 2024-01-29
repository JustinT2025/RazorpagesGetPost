using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesGetPostUI.Models;

namespace RazorPagesGetPostUI.Pages.Person
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public PersonInfo CurrentPerson { get; set; } = new();
        public void OnGet()
        {
        }
    }
}
