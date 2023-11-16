using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using BulkyBookWeb.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BulkyBookWeb.Areas.Customer.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public PortfolioController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Create()
        {
            var model = new Portfolio(); // Create a new instance of the Portfolio model
            model.Name = "Default Name";
            return View(model); // Pass the model to the view
        }


        [HttpPost]
        public IActionResult Create(Portfolio model)
        {
            if (ModelState.IsValid)
            {
                // Save the submitted data to the database or perform other processing

                return RedirectToAction("Success"); // Redirect to a success page
            }

            return View(model);
        }

    }
}
