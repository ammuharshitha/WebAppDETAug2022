using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.service;

namespace WebAppDETAug2022.Pages
{
    public class HellopageModel : PageModel
    {
        public IHello ob { get; set; }
        public string Message { get; set; }

        public HellopageModel(IHello i)
        {
            ob = i;
        }
        public void OnGet()
        {
            Message = ob.SayHello("AMMU");
        }
    }
        
}
