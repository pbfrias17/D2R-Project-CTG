using UnityEngine;
using System.Collections;

public class GameManagerLink : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}

	public void Init() {
		GameManager.Init();
		Canvas UI = (Canvas) FindObjectOfType(typeof(Canvas));
		UI.gameObject.SetActive(false);
		GameManager.StartMiniGame();
	}

	//handles input in-game
	public void OnClick() {
		GameManager.StartMiniGame();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
