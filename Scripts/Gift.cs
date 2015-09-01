using UnityEngine;
using System.Collections;

public class Gift : MonoBehaviour {

	public SpriteRenderer SR;
	public int index;
	public bool isCorrect;

	// Use this for initialization
	void Start() {
		gameObject.AddComponent<SpriteRenderer>();
		SR = gameObject.GetComponent<SpriteRenderer>();
	}

	public void SetSprite(Sprite sp) {
		index = 3;
	}

	public void SetIndex(int id) {
		index = id;
	}

	public void SetCorrect(bool tf) {
		isCorrect = tf;
	}

	public bool GetCorrect() {
		return isCorrect;
	}

	// Update is called once per frame
	void Update() {
	
	}
}
