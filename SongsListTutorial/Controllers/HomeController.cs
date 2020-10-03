using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SongsListTutorial.Models;

namespace SongsListTutorial.Controllers {
    public class HomeController : Controller {
        private SongContext context;

        public HomeController(SongContext context) {
            this.context = context;
        }

        public IActionResult Index() {
            var songs = context.Songs.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(songs);
        }
    }
}
