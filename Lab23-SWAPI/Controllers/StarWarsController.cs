using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lab23_SWAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab23_SWAPI.Controllers
{
    public class StarWarsController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PersonById(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");

            var response = await client.GetAsync($"people/{id}"); //endpoints
            var result = await response.Content.ReadAsAsync<CharacterRoot>(); //read it as a string first!

            return View(result);
        }

        public async Task<IActionResult> PlanetById(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");

            var response = await client.GetAsync($"planets/{id}"); //endpoints
            var result = await response.Content.ReadAsAsync<Planet>(); //read it as a string first!
            return View(result);
        }
    }
}