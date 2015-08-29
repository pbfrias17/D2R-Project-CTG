using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GiftGuessing : MonoBehaviour {

	private List<string> giftStrings = new List<string>();
	private GameObject[] giftObjects;
	private bool gameStart;
	public Sprite[] giftSprites;
	private string giftType;
	

	// Use this for initialization
	void Start () {
		gameStart = true;
		giftStrings.Add("doll");
		giftType = "doll";
		giftObjects = GameObject.FindGameObjectsWithTag("GiftGuess");
		foreach(GameObject gift in giftObjects) {
			Debug.Log("Found " + gift);
		}
		giftSprites = Resources.LoadAll<Sprite>("Sprites/GiftGuessing/" + giftType);  
		AssignSprites();
	}

	void AssignSprites() {
		foreach(GameObject gift in giftObjects) {
			SpriteRenderer SR = gift.GetComponent<SpriteRenderer>();
			SR.sprite = giftSprites[0];
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
