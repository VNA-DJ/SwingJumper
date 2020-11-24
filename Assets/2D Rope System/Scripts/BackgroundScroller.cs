using UnityEngine;
using System.Collections;

public class BackgroundScroller : MonoBehaviour {

	public float scrollSpeed = 0.1f;

	
	void Start ()
	{
	
	}
	
	void Update () {
		float offset = Time.time * 0.01f;
		
		GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (offset, 0);
	}
}
