using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesGetPostUI.Models;

namespace RazorPagesGetPostUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        [BindProperty(SupportsGet = true)]
        public PersonInfo? CurrentPerson { get; set; }
        public void OnGet()
        {
            _logger.LogInformation("Main site Index OnGet() called");
        }
        public void OnPost()
        {
            _logger.LogInformation("Main site Index OnGet() called");
        }
    }
}