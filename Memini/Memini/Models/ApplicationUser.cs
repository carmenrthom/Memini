using System;
using Microsoft.AspNetCore.Identity;

namespace Memini.Models
{
	public class ApplicationUser : IdentityUser
	{
		public List<Deck> decks { get; set; } = new List<Deck>();
	}
}

