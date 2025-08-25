using Godot;

public partial class MainMenu : Control
{
	[Export]
	private SpinBox _gridSizeSpinBox;

	private void OnExitButtonPressed()
	{
		GetTree().Quit();
	}

	private void OnPlayButtonPressed()
	{
		GetTree().ChangeSceneToFile("res://src/game/game.tscn");
	}
}
