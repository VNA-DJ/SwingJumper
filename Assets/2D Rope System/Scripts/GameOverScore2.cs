using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScore2 : MonoBehaviour
{
	public static int score;   // The player's score.
	public static int highscore;
	
	
	Text text;                      // Reference to the Text component.
	
	// Set highscoreText up in the inspector.
	public Text highscoreText;
	
	void Awake()
	{
		text = GetComponent<Text>();
		highscore = PlayerPrefs.GetInt("highscore");
	}


	
	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "High Score: " + highscore;

	}

}