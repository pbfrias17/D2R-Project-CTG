using UnityEngine;
using System.Collections;

public class MiniGame : MonoBehaviour {

	public bool isDone;
	public string currentGameName;

	// Use this for initialization
	void Start () {
		
	}

	public void CleanUp() {
		GameObject[] gifts = GameObject.FindGameObjectsWithTag("GiftGuess");
		foreach(GameObject gift in gifts) {
			Destroy(gift);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
