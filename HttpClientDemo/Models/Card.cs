namespace DeckOfCardsApiDemo.Models
{

	public class Card
	{
		public string code { get; set; }
		public string image { get; set; }
		public Images images { get; set; } //images is an objects so it will need to be referenced below
		public string value { get; set; }
		public string suit { get; set; }
	}

	public class Images
	{
		public string svg { get; set; }
		public string png { get; set; }
	}

}
