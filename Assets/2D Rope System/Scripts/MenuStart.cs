using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class MenuStart : MonoBehaviour {

	public Sprite button_menu;
	public Sprite button_menu_down;
	// Use this for initialization
	void OnMouseEnter () {
		GetComponent<SpriteRenderer> ().sprite = button_menu_down;
	}
	
	void OnMouseExit () {
		GetComponent<SpriteRenderer> ().sprite = button_menu;
	}
	
	void OnMouseDown () {
		Social.localUser.Authenticate ((bool success) => {
			if(success){
				Debug.Log("You've successfully logged in");
			}
			else
			{
				Debug.Log ("Login Failed");
			}
		});
		Application.LoadLevel(1);

	}
	void Update(){
		if (Application.platform == RuntimePlatform.Android)
		{
			if (Input.GetKeyDown(KeyCode.Escape)) 
				Application.Quit();
		} 
}
}

