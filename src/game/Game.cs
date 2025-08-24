using Godot;
using System;
using System.Collections.Generic;

public partial class Game : CanvasLayer
{
	[Export] private GridContainer _gridContainer;
	[Export] private TextureButton _card;

	public Texture2D Image { get; private set; }
	
	public override void _Ready()
	{
		GameManager gameManager = GameManager.Instance;
		int difficulty = gameManager.Difficulty;
		_gridContainer.Columns = difficulty;
		
		int cardNum = gameManager.CardsNum;
		for (int i = 0; i < cardNum ; i++)
		{
            _gridContainer.AddChild(_card.Duplicate());
		}

		Random random = new Random();
        HashSet<int> randomCards = new HashSet<int>();
		HashSet<int> randomPositions = new HashSet<int>();

        while (randomCards.Count < cardNum / 2)
        {
            randomCards.Add(random.Next(20));
		}

		while (randomPositions.Count < cardNum)
		{
			randomPositions.Add(random.Next(cardNum));
		}


        foreach (int num in randomCards)
        {
			int i = 0;
			foreach (int position in randomPositions)
			{
				Card card = (Card) GetChild(0).GetChild(position);
				card.CardReveal = (Texture2D) GD.Load("res://assets/cards/" + num + ".png");

				randomPositions.Remove(position);
				i++;

				if (i == 2)
				{
					break;
				}
			}
        }
	}
}
