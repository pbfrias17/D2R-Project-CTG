using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class GiftGuessing : MonoBehaviour {

	private int giftAmt;
	private string giftType;
	private List<Sprite> spritesList;
	private List<Sprite> randomSprites;
	private Sprite correctSprite;

	// Use this for initialization
	IEnumerator Start() {
		string[] giftTypes = {"doll", "car"};
		giftType = giftTypes[0];
		giftAmt = 3;

		spritesList = new List<Sprite>();
		foreach(Sprite sprite in Resources.LoadAll<Sprite>("Sprites/GiftGuessing/" + giftType)) {
			spritesList.Add(sprite);
		}

		LoadSprites();
		yield return StartCoroutine("ShowCorrectGift");
		CreateGifts();
		
	}

	void LoadSprites() {
		randomSprites = new List<Sprite>();
		for (int i = 0; i < giftAmt; i++) {
			int randIndex = Random.Range(0, spritesList.Count);
			randomSprites.Add(spritesList[randIndex]);
			spritesList.RemoveAt(randIndex);
		}
	}

	IEnumerator ShowCorrectGift() {
		Debug.Log("randomSprites = " + randomSprites.Count);
		int i = Random.Range(0, randomSprites.Count);
		correctSprite = randomSprites[i];

		GameObject gift = new GameObject("memorize this!");
		gift.AddComponent<SpriteRenderer>();
		SpriteRenderer sr = gift.GetComponent<SpriteRenderer>();
		sr.sprite = correctSprite;
		Transform tr = gift.GetComponent<Transform>();
		tr.localScale = new Vector3(3.5f, 3.5f, 0f);
		tr.position = new Vector3(0f, 0f, -1f);
		
		//show for 3 seconds then hide
		yield return new WaitForSeconds(3);
		DestroyObject(gift);
	}

	void CreateGifts() {
		float xPos = -3.5f;
		float xGap = 3.5f;
		float yPos = 0f;
		float zPos = -1f;

		foreach(Sprite giftSprite in randomSprites) {
			GameObject gift = new GameObject("gift");
			gift.AddComponent<BoxCollider2D>();
			gift.AddComponent<SpriteRenderer>();
			SpriteRenderer sr = gift.GetComponent<SpriteRenderer>();
			Transform tr = gift.GetComponent<Transform>();
			tr.localScale = new Vector3(2.5f, 2.5f, 0f);
			tr.position = new Vector3(xPos, yPos, zPos);
			xPos += xGap;
			gift.tag = "GiftGuess";
			sr.sprite = giftSprite;
		}
	}

	void Update() {
		if (Input.GetMouseButtonDown(0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
			
			if (Physics.Raycast(ray, out hit)) {
				if (hit.collider.gameObject.tag == "GiftGuess") {
					Debug.Log( "My object is clicked by mouse");
				}
			} else {
				Debug.Log(ray);
			}

		}
	}

	
}
