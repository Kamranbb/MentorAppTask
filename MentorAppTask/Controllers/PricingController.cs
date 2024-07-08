using MentorAppTask.Data;
using MentorAppTask.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MentorAppTask.Controllers
{
    public class PricingController : Controller
    {
        private readonly MentorAppDbContext _mentorAppDbContext;

        public PricingController(MentorAppDbContext mentorAppDbContext)
        {
            _mentorAppDbContext = mentorAppDbContext;
        }

        public IActionResult Index()
        {

            PricingVM pricingVM = new PricingVM();
            pricingVM.Services = _mentorAppDbContext.Services.ToList();
            pricingVM.Pricings = _mentorAppDbContext.Pricings
                .Include(p=>p.PricingServices)
                .ThenInclude(pc => pc.Service)
                .ToList();
            return View(pricingVM);
        }
    }
}
