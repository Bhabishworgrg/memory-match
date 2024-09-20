using Godot;


// Singleton
public partial class GameManager : Node
{
	// One and only instance of GameManager
	public static GameManager Instance { get; private set; }

	public int Difficulty { get; set; }
	public int CardsNum { get; set; }
	public Card FirstCard { get; set; }

    public override void _Ready()
	{
		// Set current instance as the only instance of the GameManager
		Instance = this;
		
		Difficulty = 4;
		CardsNum = Difficulty * Difficulty;
	}
}
