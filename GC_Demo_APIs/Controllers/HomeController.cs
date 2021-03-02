using GC_Demo_APIs.Models;
using GC_Demo_APIs.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GC_Demo_APIs.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private StarWarsDAL starWarsDAL = new StarWarsDAL();
        private WeatherDAL weatherDAL = new WeatherDAL();
        private RedditDAL redditDAL = new RedditDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<PersonPlanetViewModel> personPlanets = new List<PersonPlanetViewModel>();

            for (int i = 1; i < 15; i++)
            {
                PersonPlanetViewModel personPlanet = new PersonPlanetViewModel()
                {
                    Person = starWarsDAL.ConverToSWCharacter(i),
                    Planet = starWarsDAL.ConverToPlanet(i)
                };

                personPlanets.Add(personPlanet);
            }

            return View(personPlanets);
        }

        public IActionResult Forecast()
        {
            WeatherModel weather = new WeatherModel();

            weather = weatherDAL.ConvertJsonToWeatherModel(42, 83);

            return View(weather);
        }

        public IActionResult Reddit()
        {
            RedditModel reddit = new RedditModel();
            reddit = redditDAL.ConvertDataToRedditModel("aww");

            List<RedditPostViewModel> redditPosts = new List<RedditPostViewModel>();

            foreach (var item in reddit.data.children)
            {
                RedditPostViewModel singlePost = new RedditPostViewModel()
                {
                    subredditName = item.data.subreddit_name_prefixed,
                    Title = item.data.title,
                    thumbUrl = item.data.thumbnail,
                    url = item.data.url,
                    dateCreated = DateTimeOffset.FromUnixTimeSeconds((long)item.data.created_utc).ToLocalTime()
                };

                redditPosts.Add(singlePost);
            }

            return View(redditPosts.Take(10).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
