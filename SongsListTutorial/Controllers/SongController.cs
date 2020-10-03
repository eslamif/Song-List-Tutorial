using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SongsListTutorial.Models;

namespace SongsListTutorial.Controllers {
    public class SongController : Controller {
        private SongContext context;

        public SongController(SongContext context) {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Add() {
            ViewBag.Action = "Add";
            ViewBag.Genres = context.Genres.OrderBy(m => m.Name).ToList();
            return View("Edit", new Song());
        }

        [HttpGet]
        public IActionResult Edit(int songId) {
            ViewBag.Action = "Edit";
            ViewBag.Genres = context.Genres.OrderBy(m => m.Name).ToList();
            var song = context.Songs.Find(songId);
            return View(song);
        }

        [HttpPost]
        public IActionResult Edit(Song song) {
            if (ModelState.IsValid) {
                //Add song
                if (song.SongId == 0) {
                    context.Songs.Add(song);
                }
                else {
                    //Edit song
                    context.Songs.Update(song);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else {
                //If there is an issue with the model, redirect back to user
                ViewBag.Action = song.SongId == 0 ? "Add" : "Edit";
                ViewBag.Genres = context.Genres.OrderBy(m => m.Name).ToList();
                return View(song);
            }
        }

        [HttpGet]
        public IActionResult Delete(int songId) {
            var song = context.Songs.Find(songId);
            return View(song);
        }

        [HttpPost]
        public IActionResult Delete(Song song) {
            context.Songs.Remove(song);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
