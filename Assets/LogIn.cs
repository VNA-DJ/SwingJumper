using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class LogIn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Social.localUser.Authenticate ((bool success) => {
			if(success){
				Debug.Log("You've successfully logged in");
			}
			else
			{
				Debug.Log ("Login Failed");
			} 
		});
	}
	/*void Update()
	{
		if (Application.platform == RuntimePlatform.Android)
			{
				if (Input.GetKeyDown(KeyCode.Escape)) 
					PlayGamesPlatform.Instance.SignOut();
					Application.Quit();
			}
	}*/
}
