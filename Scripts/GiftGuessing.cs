using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GiftGuessing : MonoBehaviour {

	private List<string> giftStrings = new List<string>();
	private GameObject[] giftObjects;
	private List<Sprite> spritesList;
	private List<Sprite> randomSprites;
	private string giftType;
	private int giftAmt;
	private Sprite correctSprite;

	// Use this for initialization
	void Start() {

		Debug.Log("Starting GiftGuessing minigame...");
		string[] giftTypes = {"doll", "car"};
		//load all sprites, randomly pick a correct one
		//show it to the user
		giftType = giftTypes[0];
		spritesList = new List<Sprite>();
		randomSprites = new List<Sprite>();
		foreach(Sprite sprite in Resources.LoadAll<Sprite>("Sprites/GiftGuessing/" + giftType)) {
			spritesList.Add(sprite);
			Debug.Log(sprite);
		}

		LoadGifts();
		
	}

	void LoadGifts() {
		int giftAmt = 3;
		float xPos = -3.5f;
		float xGap = 3.5f;
		float yPos = 0f;
		float zPos = -1f;
		
		for (int i = 0; i < giftAmt; i++) {
			CreateGift(new Vector3(xPos, yPos, zPos));
			xPos += xGap;
		}
	}

	void CreateGift(Vector3 pos) {
		GameObject gift = new GameObject("gift");
		gift.AddComponent<SpriteRenderer>();
		SpriteRenderer sr = gift.GetComponent<SpriteRenderer>();
		Transform tr = gift.GetComponent<Transform>();
		tr.localScale = new Vector3(2.5f, 2.5f, 0f);
		tr.position = pos;
		gift.tag = "GiftGuess";
		
		//choose random sprites
		int randIndex = Random.Range(0, spritesList.Count);
		randomSprites.Add(spritesList[randIndex]);
		sr.sprite = spritesList[randIndex];
		spritesList.RemoveAt(randIndex);
		
		
	}

	
}
