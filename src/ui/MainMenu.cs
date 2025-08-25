using Godot;

public partial class MainMenu : Control {
	[Export]
	private SpinBox _gridSizeSpinBox;

	private GameManager gameManager;

	public override void _Ready() {
		gameManager = GameManager.Instance;
	}

	private void OnExitButtonPressed() {
		GetTree().Quit();
	}

	private void OnPlayButtonPressed() {
		int gridSize = (int) _gridSizeSpinBox.Value;
		gameManager.GridSize = gridSize;
		gameManager.CardsNum = gridSize * gridSize;

		GetTree().ChangeSceneToFile("res://src/game/game.tscn");
	}
}
