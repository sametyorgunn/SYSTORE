using EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace SYSTORE.Controllers
{
    public class OdemeController : Controller
    {
        public async Task<IActionResult> Index()
        {
           
            return View();
        }
        public IActionResult Index2()
        {
            // Shopier API bağlantı bilgilerini ayarlayın
            string apiKey = "d46724cc9f0f27e5dc41609871fec9ff";
            string apiSecret = "ef95da16f702b5d44cc6d1f4a9f09daa";

            // Sipariş detaylarını hazırlayın
            string productName = "product_name";
            decimal productPrice = 1;
            int quantity = 1;
            string buyerName = "buyer_name";
            string buyerEmail = "buyer_email";
            string buyerAddress = "buyer_address";
            string buyerCity = "buyer_city";
            string buyerCountry = "buyer_country";
            string buyerZipcode = "buyer_zipcode";
            string description = "product_description";
            string callbackUrl = "callback_url";

            // Shopier API isteği oluşturun
            var request = new RestRequest("payments", RestSharp.Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("api_key", apiKey);
            request.AddParameter("api_secret", apiSecret);
            request.AddParameter("product_name", productName);
            request.AddParameter("product_price", productPrice);
            request.AddParameter("quantity", quantity);
            request.AddParameter("buyer_name", buyerName);
            request.AddParameter("buyer_email", buyerEmail);
            request.AddParameter("buyer_address", buyerAddress);
            request.AddParameter("buyer_city", buyerCity);
            request.AddParameter("buyer_country", buyerCountry);
            request.AddParameter("buyer_zipcode", buyerZipcode);
            request.AddParameter("description", description);
            request.AddParameter("callback_url", callbackUrl);

            // Shopier API'ye istek gönderin
            var client = new RestClient("https://api.shopier.com/api/v2/");
            var response = client.Execute(request);

            // Shopier ödeme sayfasına yönlendirin
            return Redirect(response.Content);

        }
    }
}
