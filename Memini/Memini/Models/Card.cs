using System;
namespace Memini.Models
{
	public class Card
	{
		public int Id { get; set; }
		public string frontText { get; set; }
		public string backText { get; set; }
		public int repetitions { get; set; } = 0;
		public int quality { get; set; }
		public double easiness { get; set; }
		public int interval { get; set; }
        public DateTime nextPractice { get; set; }
    }
}

