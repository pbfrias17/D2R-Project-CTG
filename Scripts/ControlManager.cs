using UnityEngine;
using System.Collections;

public class ControlManager : MonoBehaviour {

	//options?
	private string PlayerName;

	// Use this for initialization
	void Start () {
		PlayerName = "Paolo";
		
	}
	
	public void StartGameManager() {
		GameManager.Start();
	}

	public void OptionsMenu() {

	}

	// Update is called once per frame
	void Update () {
	
	}
}
