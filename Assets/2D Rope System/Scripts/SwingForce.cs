using UnityEngine;
using System.Collections;

public class SwingForce : MonoBehaviour {

	public float forceStrength = 8f;
	public float maxSpeed = 17.5f;
	public float timePerOneSide = 2f;

	private Rigidbody2D rb;
	private Vector3 force;
	private float timer = 0.0f; 


	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		timer = timePerOneSide;

	}
	
	void Update()
	{

		timer += Time.deltaTime;
		if(timer >= timePerOneSide)
		{
			force = new Vector3(forceStrength *= -1, 0, 0);
			timer = 0.0f;
		}
		if(rb.velocity.sqrMagnitude <maxSpeed)
			rb.AddForce(force);
	}

}
