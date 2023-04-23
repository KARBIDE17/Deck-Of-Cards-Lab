using DeckOfCardsApiDemo;
using DeckOfCardsApiDemo.Models;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Text;


namespace DeckOfCardsApiDemo.Services
{
    public class DeckOfCardsApiService
    {
        private readonly HttpClient _httpClient;
        public DeckOfCardsApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Deck> ABrandNewDeck()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("new/shuffle/?deck_count=1");
            Deck result = await response.Content.ReadAsAsync<Deck>();

            return result;
        }

        public async Task<DrawResponse> Draw(Deck deck)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{deck.deck_id}/draw/?count=5");
            DrawResponse result = await response.Content.ReadAsAsync<DrawResponse>();

            return result;
        }

    }
}
