using AspWebApplicationDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspWebApplicationDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IDetailsRepository detailsInfo;

        public IndexModel(IDetailsRepository detailsRepository)
        {
            detailsInfo=detailsRepository;
        }

        public void OnGet()
        {
            ViewData["number"] = detailsInfo.GetDetails().number;
            ViewData["name"] = detailsInfo.GetDetails().name;
        }
    }
}