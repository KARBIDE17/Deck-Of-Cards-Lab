using DeckOfCardsApiDemo.Models;
using DeckOfCardsApiDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DeckOfCardsApiDemo.Controllers
{
    public class HomeController : Controller
    {
        // creates a private instance of the api service and sets it to avariable
       private readonly DeckOfCardsApiService _deckOfCardsApiService;

        public HomeController(DeckOfCardsApiService deckOfCardsApiService)
        {
            _deckOfCardsApiService = deckOfCardsApiService;
        }



        // async task of Iactionresult that calls the index action
        public async Task<IActionResult> Index()
        {



            // create a new deck variable called result, awaits the api and calls the ABrandNewDeck method from DeckOfCardsApiService, this is stored in result
            Deck result = await _deckOfCardsApiService.ABrandNewDeck();


                // return the index view and pass the deck result 
                return View(result);

            


        }

        public async Task<IActionResult> Draw()
        {
            // create a new deck variable called result, awaits the api and calls the ABrandNewDeck method from DeckOfCardsApiService,, this is stored in result
            Deck result = await _deckOfCardsApiService.ABrandNewDeck();


            // create a new draw response variable called draw response, awaits the api and calls the draw method from DeckOfCardsApiService, and passes result Deck to that method, this is stored in response
            DrawResponse response = await _deckOfCardsApiService.Draw(result);

            //response is then passed to the draw view
            return View(response);
        }

    }
}