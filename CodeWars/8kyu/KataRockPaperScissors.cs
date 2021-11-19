namespace CodeWars._8kyu
{
	internal class KataRockPaperScissors
	{
		public string Rps(string p1, string p2)
		{
			string p1w = "Player 1 won!",
				p2w = "Player 2 won!",
				draw = "Draw!";

			//rock > scissors > paper > rock
			switch (p1)
			{
				case "rock":
					if (p2 == "paper") return p2w;
					else if (p2 == "scissors") return p1w;
					else return draw;

				case "scissors":
					if (p2 == "rock") return p2w;
					else if (p2 == "paper") return p1w;
					else return draw;

				case "paper":
					if (p2 == "scissors") return p2w;
					else if (p2 == "rock") return p1w;
					else return draw;
			}
			return "";
		}
	}

	
}
