using DeckOfCardsApiDemo;
using DeckOfCardsApiDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Text;


namespace DeckOfCardsApiDemo.Services
{
    public class DeckOfCardsApiService
    {

        // adds a new instance of the http client and assigns it to a variable i can use
        private readonly HttpClient _httpClient;
        public DeckOfCardsApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Deck> ABrandNewDeck()
        {
            // this is where the program adds the endpoints to the base api to use the apis functions for a new deck

            // response variable awaits the http client with endpoint, this will return our data for a new deck
            HttpResponseMessage response = await _httpClient.GetAsync("new/shuffle/?deck_count=1");
            // then we store that new deck in a variable called result and use async to make it a stored deck
            Deck result = await response.Content.ReadAsAsync<Deck>();
            // then we return that result variable to the ABrandNewDeck action that gets called in the home controller
            return result;
        }

        public async Task<DrawResponse> Draw(Deck deck)
        {
            // this is where the program adds the endpoints to the base api to use the apis functions for drawing 5 cards

            // response variable awaits the http client with endpoint, this will return our data for a drawing any amount of cards, i chose 5
            // additionally, the deck variable that was passed in can be used here to draw from a specific deckid
            HttpResponseMessage response = await _httpClient.GetAsync($"{deck.deck_id}/draw/?count=5");
            // then we store that responce in a variable called result and use async to make it a stored set of 5 cards with all its properties
            DrawResponse result = await response.Content.ReadAsAsync<DrawResponse>();

            // then we return that result variable to the Draw action that gets called in the home controller
            return result;
        }

    }
}
