using LabNet2021.Logic.ApiLogic;
using LabNet2021.Models.PokeModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LabNet2021.WebApi.Controllers
{
    public class ApiPokemonController : Controller
    {
        // GET: ApiPokemon
        public ActionResult Index()
        {
            try
            {
                PokeLogic pokeLogic = new PokeLogic();
                PokeListView pokeListView = new PokeListView();
                pokeListView = pokeLogic.ListPoket();                 
                return View(pokeListView);
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View("Error");
            }
        }


    }
}