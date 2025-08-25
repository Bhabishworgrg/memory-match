using Godot;

public partial class GameManager : Node {
	public static GameManager Instance { get; private set; }

	public int GridSize { get; set; }
	public int CardsNum { get; set; }
	public Card FirstCard { get; set; }

    public override void _Ready() {
		Instance = this;
		
		GridSize = 6;
		CardsNum = 36;
	}
}
