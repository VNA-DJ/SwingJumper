using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player") {
			PlayerPrefs.SetInt ("score", ScoreManager.score);
			Application.LoadLevel (2);
			return;

		} 
		else if (other.gameObject.tag == "rope2D" || other.gameObject.tag == "tack" || other.gameObject.tag == "ground") {

			Destroy(other.transform.parent.gameObject);
			Destroy(GameObject.Find("Toon Slap 01 PS(Clone)"), 2);

		}
	}
	


}
