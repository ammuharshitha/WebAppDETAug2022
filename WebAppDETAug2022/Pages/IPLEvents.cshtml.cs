using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Pages
{
    public class IPLEventsModel : PageModel
    {
        public List<Ticket> Ticket { get; set; }
        public void OnGet()
        {
            Ticket = new List<Ticket>{
                 new Ticket{Match= "INDIA VS PAKISTAN "  ,Price=5000,Id=1},
                new Ticket{Match= "Sri Lanka VS INDIA"   ,Price=4000,Id=2},
                new Ticket{Match= "INDIA VS Afghanistan",Price=3000,Id=3}
            }; 
        }
    }
}