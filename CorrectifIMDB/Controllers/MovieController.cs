using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocalModel.Services;
using Microsoft.AspNetCore.Mvc;

namespace CorrectifIMDB.Controllers
{
    public class MovieController : Controller
    {
        MovieService _service;
        public MovieController()
        {
            _service = new MovieService();
        }

        public IActionResult Index()
        {
            return View(_service.GetAll());
        }
    }
}