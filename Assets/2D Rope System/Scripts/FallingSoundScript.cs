using UnityEngine;
using System.Collections;
public class FallingSoundScript : MonoBehaviour {
	
	public AudioClip fall;
	AudioSource audio;


	private static FallingSoundScript _instance;

	void Awake()
	{
		//if we don't have an [_instance] set yet
		if(!_instance)
			_instance = this ;
		//otherwise, if we do, kill this thing
		else
			Destroy(this.gameObject) ;
		

		DontDestroyOnLoad(this.gameObject) ;
	}

	void Start() {

		audio = GetComponent<AudioSource>();
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player" && !audio.isPlaying) {
			audio.PlayOneShot (fall, 0.8F);

		}
	}
}
