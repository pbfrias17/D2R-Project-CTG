using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public static class GameManager {

	public static bool miniGameOn;
	public static string currentMiniGame;
	public static GameObject currentGameObject;
	public static SpriteRenderer sr;
	public static List<string> miniGames = new List<string>();
	public static string[] strings;
	public static int currentStage;
	public static int currentLives;

	// Use this for initialization
	public static void Init() {
		Debug.Log("Starting GameManager...");
		currentLives = 3;
		miniGames.Add("GiftGuessing");
		currentGameObject = new GameObject("background");
		currentGameObject.AddComponent<SpriteRenderer>();
		//Resources.Load<Sprite>("Sprites/MainMenu/Wallpaper.jpg");
		//sr.sprite = Resources.Load<Sprite>("Sprites/MainMenu/Wallpaper.jpg");
		Util.ApplySpriteToObject(ref currentGameObject, Resources.Load<Sprite>("Sprites/MainMenu/Wallpaper.jpg"));
	}

	public static void StartMiniGame() {
		miniGameOn = true;
		currentStage = 1;
		currentMiniGame = miniGames[0];
		//add script and sprite
		UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(currentGameObject, "Assets/D2R-Project-CTG/Scripts/GameManager.cs (27,3)", currentMiniGame);
		Util.ApplySpriteToObject(ref currentGameObject, Resources.Load<Sprite>("Sprites/" + currentMiniGame + "/general/" + currentMiniGame + "bg.jpg"));
	}

	public static void EndMiniGame(bool success) {
		if(success) {
			Debug.Log("GM: GOOD JOB!");
			currentStage++;
		} else {
			Debug.Log("GM: DARN!");
			currentLives--;
			if(currentLives > 0) {
				currentStage++;
			} else {
				GameOver();
			} 
		}
		
	}

	public static void GameOver() {
		Debug.Log("GM: g4ME oV3r");
	}


	// Update is called once per frame
	static void Update () {
	
	}
}
