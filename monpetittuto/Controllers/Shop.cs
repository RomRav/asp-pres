using Microsoft.AspNetCore.Mvc;
using monpetittuto.Models;

namespace monpetittuto.Controllers
{
    public class Shop : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Boutique1()
        {
            return View();
        }

        public IActionResult ShopsHome()
        {
            List<ShopModel> shopList = new List<ShopModel>();
            for (var i = 0; i <= 3; i++)
            {
                ShopModel shop = new ShopModel(i, $"Boutique{i}");
                shopList.Add(shop);
            }
            return View(shopList);
        }
    }
}
