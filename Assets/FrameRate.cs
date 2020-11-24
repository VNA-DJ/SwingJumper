using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class FrameRate : MonoBehaviour {

	void Awake() {
		Application.targetFrameRate = 60;
	}

	void Start(){
		GooglePlayGames.PlayGamesPlatform.Activate();
	}
}
