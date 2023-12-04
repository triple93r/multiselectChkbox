using Microsoft.AspNetCore.Mvc;
using Multiselect.Data;
using Multiselect.Models;
using Multiselect.VMs;
using System.Diagnostics;
using System.Linq;

namespace Multiselect.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AssignSubj()
        {
            AllTbls allTbls = new AllTbls();
            allTbls.Subjects = _context.tbl_Subject.Where(x => x.grade == "2").ToList();
            
            return View(allTbls);
        }

        [HttpPost]
        public IActionResult AssignSubj(AllTbls stsbj, string[] subj, string Stud_id, string Class)
        {
            foreach(string a in subj)
            {

            }
            if (Stud_id != null)
            {
                _context.tblAcademics.Add(stsbj.tblAcademic);
                _context.SaveChanges();
            }
            
            return View();
        }

        public IActionResult AddSubj()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSubj(tbl_subject sbj)
        {
            _context.tbl_Subject.Add(sbj);
            _context.SaveChanges();
            return View();
        }

        public IActionResult ViewAllSubj()
        {
            var t = _context.tbl_Subject.ToList();
            return View(t);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}