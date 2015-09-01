using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GiftGuessing : MonoBehaviour {

	private List<string> giftStrings = new List<string>();
	private GameObject[] giftObjects;
	private bool gameStart;
	private Sprite[] allSprites;
	private string giftType;
	private int giftAmt;
	private int correctGiftIndex;

	// Use this for initialization
	void Start() {

		Debug.Log("Starting GiftGuessing minigame...");
		//load all sprites, randomly pick a correct one
		//show it to the user
		allSprites = Resources.LoadAll<Sprite>("Sprites/GiftGuessing/" + giftType);
		correctGiftIndex = 0;

		//handle all GameObject creation via scripts
		//GameObject correctGift = new GameObject();

		if (GameManager.miniGameOn) {
			//initialize gifts and sprites
			LoadGifts();
		}
	}

	// Update is called once per frame
	void Update () {

	}

	void LoadGifts() {
		int giftAmt = 3;
		float xPos = -3.5f;
		float xGap = 3.5f;
		float yPos = 0f;
		float zPos = 0f;
		
		for (int i = 0; i < giftAmt; i++) {

			GameObject gift = new GameObject("gift"+i);
			gift.AddComponent<Gift>();
			gift.tag = "GiftGuess";
			gift.SetIndex(i);

			/*gift.AddComponent<SpriteRenderer>();
			gift.tag = "GiftGuess";

			SpriteRenderer SR = gift.GetComponent<SpriteRenderer>();
			Transform T = gift.GetComponent<Transform>();
			T.transform.position = new Vector3(xPos, yPos, zPos);
			T.transform.localScale = new Vector3(2.5f, 2.5f, 1);
			SR.sprite = giftSprites[0];
			xPos += xGap;
			*/
		}
	}
	
}
