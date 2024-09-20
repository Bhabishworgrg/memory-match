using Godot;

public partial class Card : TextureButton
{
	[Export] private Texture2D _cardBack;
	[Export] private GridContainer _gridContainer;
	[Export] private Timer _timer;

	private GameManager _gameManager;
	
	public Texture2D CardReveal { get; set; }

    public override void _Ready()
    {
        _gameManager = GameManager.Instance;
    }

	private void OnClicked()
	{
		if (TextureNormal != null)
		{
			TextureNormal = CardReveal;
			if (_gameManager.FirstCard == null)
			{
				_gameManager.FirstCard = this;
			}
			else
			{
				_timer.Start();
			}
		}
	}

	private void OnTimerTimeout()
	{
			if (TextureNormal == _gameManager.FirstCard.TextureNormal)
			{
				_gameManager.FirstCard.TextureNormal = null;
				TextureNormal = null;
			}
			else
			{
				for (int i = 0; i < _gridContainer.GetChildCount(); i++)
				{
					Card card = (Card) _gridContainer.GetChild(i);
					card.TextureNormal = _cardBack;
				}
			}

			_gameManager.FirstCard = null;
	}
}
