using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour{

	// This creates a button in Unity for attaching the UI button to. This starts the game
	public Button startButton;

	// This button brings you back to the main menu
	public Button backToMainMenuButton;

	// This button exits the game
	public Button exitButton;

	// This function makes it do something, appears on main menu
	public void startPress(){
		// 0 is Main Menu, 1 is Game Scene
		SceneManager.LoadScene(1);
	}

	// This function takes you to main menu, appears in game
	public void backToMainMenuPress(){
		SceneManager.LoadScene(0);
	}

	// This function exits the game, appears on main menu
	public void exitPress(){
		Debug.Log("Exiting game...");
		Application.Quit();
	}
}
