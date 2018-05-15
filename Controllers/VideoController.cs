using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EvilLyo.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EvilLyo.Controllers
{
    public class VideoController : Controller
    {
        private DataContext _context;

        public VideoController(DataContext context)
        {
            _context = context;
        }

        // GET: /Picture/
        public IActionResult Index()
        {
            List<Video> ptlist = _context.video
                .Take(100)
                .ToList();
            ViewBag.ptlist = ptlist;

            return View();
        }

        // GET: /Picture/Detail
        public IActionResult Detail(int id)
        {
            Video vd = _context.video.Where(p => p.ID == id).ToList()[0];
            //ViewBag.ptlist = ptlist;

            return View(vd);
        }
    }
}
