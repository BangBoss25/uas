using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uas.Models;
using uas.Services.Service;

namespace uas.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class StuffController : Controller
    {
        private readonly IStuffService _service;

        public StuffController(IStuffService s)
        {
            _service = s;
        }

        public IActionResult Index()
        {
            _service.AmbilSemuaBarang();

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Stuff brg, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                _service.BuatBarangNew(brg, Image);

                return RedirectToAction("Index");
            }

            return View(brg);
        }
    }
}
