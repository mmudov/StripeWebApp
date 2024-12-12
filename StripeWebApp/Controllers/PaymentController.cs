using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stripe.Checkout;
using StripeWebApp.Models;

namespace StripeWebApp.Controllers
{
    public class PaymentController : Controller
    {
        private readonly DatabaseContext _databaseContext;

        public PaymentController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        /*public IActionResult Index()
        {
            return View();
        }*/

        public async Task<IActionResult> Index()
        {
            return View(await _databaseContext.Items.ToListAsync());
        }

        [HttpPost]
        public ActionResult CreateCheckout([Bind("Id, Name, ImageUrl, PriceID")] Item item)
        {
            var domain = "https://localhost:7171";
            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                        //Provide the exact Price ID (for example, pr_1234) of the product you want to sell
                        //Price = "{{PRICE_ID}}",
                        //Price = "price_1QV644FCRscjNLWmDLp9BYMl", //From https://docs.stripe.com/
                        Price = $"{item.PriceID}",
                        Quantity = 1,
                    },
                },
                //Mode = "payment",
                Mode = "subscription",
                SuccessUrl = domain + "/Payment/Success",
                CancelUrl = domain + "/Cancel/Success",
            };
            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Cancel()
        {
            return View();
        }
    }
}
