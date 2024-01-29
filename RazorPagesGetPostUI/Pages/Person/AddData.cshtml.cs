using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesGetPostUI.Models;

namespace RazorPagesGetPostUI.Pages.Person
{
    public class AddDataModel : PageModel
    {
        private readonly ILogger<AddDataModel> _logger;
        [BindProperty(SupportsGet =true)]
        public PersonInfo CurrentPerson { get; set; } = new();

        public AddDataModel(ILogger<AddDataModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogInformation("AddData OnGet called");
            _logger.LogInformation($"playerName {CurrentPerson.playerName}");
            _logger.LogInformation($"Postion {CurrentPerson.Postion}");
        }
        public IActionResult OnPost()
        {
            _logger.LogInformation("AddData OnPost called");
            _logger.LogInformation($"playerName {CurrentPerson.playerName}");
            _logger.LogInformation($"Postion {CurrentPerson.Postion}");
            if (ModelState.IsValid)
            {
                return RedirectToPage("Index", CurrentPerson);
            }
            return Page();
           
        }
    }
}
