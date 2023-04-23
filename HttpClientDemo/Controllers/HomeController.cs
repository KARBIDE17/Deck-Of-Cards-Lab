using DeckOfCardsApiDemo.Models;
using DeckOfCardsApiDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeckOfCardsApiDemo.Controllers
{
    public class HomeController : Controller
    {
       private readonly DeckOfCardsApiService _deckOfCardsApiService;

        public HomeController(DeckOfCardsApiService deckOfCardsApiService)
        {
            _deckOfCardsApiService = deckOfCardsApiService;
        }

        public async Task<IActionResult> Index()
        {

                Deck result = await _deckOfCardsApiService.ABrandNewDeck();
                return View(result);

            


        }

        public async Task<IActionResult> Draw()
        {
			Deck result = await _deckOfCardsApiService.ABrandNewDeck();
			
			DrawResponse response = await _deckOfCardsApiService.Draw(result);
            return View(response);
        }

    }
}