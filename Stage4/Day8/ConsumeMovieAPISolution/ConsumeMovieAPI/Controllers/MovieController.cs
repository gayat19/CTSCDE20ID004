using ConsumeMovieAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeMovieAPI.Controllers
{
    public class MovieController : Controller
    {
        private readonly IConfiguration _config;
        private readonly string baseUri;

        public MovieController(IConfiguration configuration)
        {
            _config = configuration;
            baseUri = _config.GetValue<string>("ShowWebAPIBaseUrl");
        }
        // GET: MovieController
        public async Task<ActionResult> Index()
        {
            HttpClient client = new HttpClient();
            string uri = baseUri;
            var myResponse = await client.GetAsync(uri);

            if(myResponse.StatusCode == HttpStatusCode.OK)
            {

              var moviesRaw = myResponse.Content.ReadAsAsync<List<Movie>>();
                var movies = moviesRaw.Result;
                return View(movies);
            }
            return View();
            
        }

        // GET: MovieController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MovieController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Movie movie)
        {
            HttpClient client = new HttpClient();
            string uri = baseUri;
            try
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(movie), Encoding.UTF8, "application/json");
                var myResponse = await client.PostAsync(uri, content);
                if(myResponse.StatusCode == HttpStatusCode.OK)
                {
                    var rawResult = JsonConvert.SerializeObject(movie);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                ModelState.Clear();
                ModelState.AddModelError("Error", "Error in creatinga  new movie");
                return View();
            }
            return View();
        }

        // GET: MovieController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MovieController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MovieController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MovieController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
