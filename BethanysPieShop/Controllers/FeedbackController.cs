using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    [Authorize]
    public class FeedbackController : Controller
    {
       private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(FeedbackViewModel feedbackViewModel)
        {
            if (ModelState.IsValid)
            {
                _feedbackRepository.AddFeedback(feedbackViewModel.FeedbackForm);
                return RedirectToAction("FeedbackComplete");
            }
            return View(feedbackViewModel);
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}