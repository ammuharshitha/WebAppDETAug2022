//using APIDemo.Models;
//using APIDemo.Services;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace APIDemo.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TicketsController : ControllerBase
//    {
//        [HttpGet]
//        [Route("all")]
//        public List<Ticket> Get()
//        {
//            return TicketServices.GetAll();
//        }
//        [HttpGet]
//        [Route("id")]
//        public Ticket Get(int id)
//        {
//            Ticket t = TicketServices.Get(id);
//            return t;
//        }
//    }
//}