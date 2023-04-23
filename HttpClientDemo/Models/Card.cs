namespace DeckOfCardsApiDemo.Models
{

	public class Card
	{
		public string code { get; set; }
		public string image { get; set; }
		public Images images { get; set; }
		public string value { get; set; }
		public string suit { get; set; }
	}

	public class Images
	{
		public string svg { get; set; }
		public string png { get; set; }
	}

}
