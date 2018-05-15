using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EvilLyo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EvilLyo.Controllers
{
    public class StoryController : Controller
    {
        private DataContext _context;

        public StoryController(DataContext context)
        {
            _context = context;
        }

        // GET: /Story/
        public IActionResult Index()
        {
            List<Story> ptlist = _context.story
                .Take(100)
                .ToList();
            ViewBag.ptlist = ptlist;

            return View();
        }

        // GET: /Story/Detail
        public IActionResult Detail(int id)
        {
            Story st = _context.story.Where(p => p.ID == id).ToList()[0];
            //ViewBag.ptlist = ptlist;

            return View(st);
        }
    }
}
