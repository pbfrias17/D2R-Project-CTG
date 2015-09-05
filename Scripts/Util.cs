using UnityEngine;
using System.Collections;

public static class Util {

	public static void ApplySpriteToObject(ref GameObject obj, Sprite sp) {
		//properly fits sprite to object 
		//taking screen size into consideration
		SpriteRenderer sr = obj.GetComponent<SpriteRenderer>();
		if (sr == null) return;
		sr.sprite = sp;
		
		obj.transform.localScale = new Vector3(1f,1f,1f);
		
		float width = sr.sprite.bounds.size.x;
		float height = sr.sprite.bounds.size.y;
		double worldScreenHeight = Camera.main.orthographicSize * 2.0;
		double worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;
		
		obj.transform.localScale = new Vector2((float)worldScreenWidth / width, (float)worldScreenHeight / height);
	}
}
