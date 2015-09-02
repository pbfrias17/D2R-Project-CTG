using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public static class GameManager {

	public static bool miniGameOn;
	public static string currentMiniGame;
	public static List<string> miniGames = new List<string>();
	public static string[] strings;
	public static int currentStage;

	// Use this for initialization
	public static void Init () {
		miniGames.Add("GiftGuessing");
	}

	public static void StartMiniGame() {
		miniGameOn = true;
		currentStage = 1;
		currentMiniGame = miniGames[0];
		//create object that has proper mini game script
		GameObject currentGameObject = new GameObject("background");
		currentGameObject.transform.localScale = new Vector3(4.1f, 4f, 0f);
		UnityEngineInternal.APIUpdaterRuntimeServices.AddComponent(currentGameObject, "Assets/D2R-Project-CTG/Scripts/GameManager.cs (27,3)", currentMiniGame);
		currentGameObject.AddComponent<SpriteRenderer>();
		SpriteRenderer background = currentGameObject.GetComponent<SpriteRenderer>();
		background.sprite = Resources.Load<Sprite>("Sprites/" + currentMiniGame + "/general/" + currentMiniGame + "bg.jpg");

	}

	// Update is called once per frame
	static void Update () {
	
	}
}
