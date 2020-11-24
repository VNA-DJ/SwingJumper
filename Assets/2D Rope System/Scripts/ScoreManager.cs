using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
	public static int score;   // The player's score.
	static int highscore;
	
	
	Text text;                      // Reference to the Text component.
	
	// Set highscoreText up in the inspector.
	public Text highscoreText;
	
	void Awake()
	{
		text = GetComponent<Text>();
		score = 0;
		highscore = PlayerPrefs.GetInt("highscore");
	}


	
	void Update ()
	{
		if (score > highscore)
		{
			highscore = score;
			PlayerPrefs.SetInt("highscore", highscore);

		}
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Score: " + score;
		highscoreText.text = "High Score: " + highscore;

		if (score == 200) {
			// unlock achievement (achievement ID "CgkInvnZjK0JEAIQCA")
			Social.ReportProgress("CgkInvnZjK0JEAIQCA", 200.0f, (bool success) => {
				// handle success or failure
			});
		}

		if (score == 400) {
			// unlock achievement (achievement ID "CgkInvnZjK0JEAIQCQ")
			Social.ReportProgress("CgkInvnZjK0JEAIQCQ", 400.0f, (bool success) => {
				// handle success or failure
			});
		}

		if (score == 600) {
			// unlock achievement (achievement ID "CgkInvnZjK0JEAIQCg")
			Social.ReportProgress("CgkInvnZjK0JEAIQCg", 600.0f, (bool success) => {
				// handle success or failure
			});
		}

		if (score == 800) {
			// unlock achievement (achievement ID "CgkInvnZjK0JEAIQCw")
			Social.ReportProgress ("CgkInvnZjK0JEAIQCw", 800.0f, (bool success) => {
				// handle success or failure
			});
		}

		if (score == 1000) {
				// unlock achievement (achievement ID "CgkInvnZjK0JEAIQDA")
				Social.ReportProgress("CgkInvnZjK0JEAIQDA", 1000.0f, (bool success) => {
				// handle success or failure
			});
		}

	}

}