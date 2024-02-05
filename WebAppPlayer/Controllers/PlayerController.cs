using Microsoft.AspNetCore.Mvc;
using WebAppPlayer.Models;

namespace WebAppPlayer.Controllers
{
    public class PlayerController : Controller
    {
        static List<Player> listplay = new List<Player>()
        {
            new Player{Id=1,Name="Sam",Description="Manager"},
            new Player{Id=2,Name="Ritu",Description="Hr"}
        };
        public IActionResult Index()
        {
            return View(listplay);
        }
    }
}
