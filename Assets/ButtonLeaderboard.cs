using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class ButtonLeaderboard : MonoBehaviour {

	public Sprite button_leaderboard;
	public Sprite button_leaderboard_down;
	
	// Update is called once per frame
	void OnMouseEnter () {
		GetComponent<SpriteRenderer> ().sprite = button_leaderboard_down;
		}

		void OnMouseExit () {
			GetComponent<SpriteRenderer>().sprite = button_leaderboard;
		}

		void OnMouseDown () {
			PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkInvnZjK0JEAIQBQ");
		}
	}

