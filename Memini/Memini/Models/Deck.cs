using System;
namespace Memini.Models
{
	public class Deck
	{
		public int Id { get; set; }
        public string name { get; set; }
        public List<Card> cards = new List<Card>();
	}
}

