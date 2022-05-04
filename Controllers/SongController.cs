using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Laboratorio3.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            var song = GetFavoriteSong();
            ViewBag.MainTitle = "";
            return View(song);
        }

        private SongModel GetFavoriteSong()
        {
            var song = new SongModel  { Country = "Korea", Name = "Can't Control Myself", Genre = "K-Pop", Interpreter = "Taeyeon", ReleaseDate = new DateTime(2022, 10, 26) };

            return song;
        }
    }
}
