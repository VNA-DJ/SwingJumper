using UnityEngine;
using System.Collections;

public class ScoreCollision : MonoBehaviour {
	
	public int scoreValue = 10;
	public bool scorverdi = false;
	public GameObject pEffect;
	public AudioClip scor;

	void Start () {
	
	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player" && !scorverdi){
			ScoreManager.score += scoreValue;
			Instantiate(pEffect,new Vector3(transform.position.x,transform.position.y,transform.position.z - 1),Quaternion.identity);
			GameObject.Find("player").GetComponent<AudioSource>().PlayOneShot(scor, 1.5f); //scoring sound
			foreach(Transform child in transform.parent)
			{
				child.GetComponent<ScoreCollision>().scorverdi = true;

			}

		}
	}
}