using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverScore : MonoBehaviour
{
	public static int score;   // The player's score.
	static int highscore;
	
	
	Text text;                      // Reference to the Text component.
	
	// Set highscoreText up in the inspector.
	public Text highscoreText;
	
	void Awake()
	{
		text = GetComponent<Text>();
		score = PlayerPrefs.GetInt("score");
	}


	
	void Update ()
	{
		// Set the displayed text to be the word "Score" followed by the score value.
		text.text = "Score: " + score;

	}

}