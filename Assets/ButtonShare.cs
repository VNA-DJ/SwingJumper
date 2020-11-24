using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using UnityEngine.EventSystems;

public class ButtonShare : MonoBehaviour, IPointerClickHandler {

	public void OnPointerClick (PointerEventData eventData) {
		// post score 12345 to leaderboard ID "Cfji293fjsie_QA")
		Social.ReportScore(GameOverScore2.score, "CgkInvnZjK0JEAIQBQ", (bool success) => {
			// handle success or failure
			if(success)
			{
				Debug.Log("Successfully");
			}
		});
	}
}
