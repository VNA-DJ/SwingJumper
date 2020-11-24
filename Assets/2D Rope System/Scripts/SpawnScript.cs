using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public Transform prefab;
	public float width = 3;
//	public float second = 1;
	private float sum;
	private bool create = true;
	void Start(){
		prefab.GetChild (0).GetComponent<SwingForce>().forceStrength = 8; 
		prefab.GetChild (0).GetComponent<SwingForce>().maxSpeed = 17.5f; 
		prefab.GetChild (0).GetComponent<SwingForce>().timePerOneSide = 2;
	}
	void Update()
	{
		if(create)
			StartCoroutine("CreatePrefab");
	}
	
	IEnumerator CreatePrefab()
	{
		if (GameObject.FindGameObjectsWithTag ("Rope").Length < 10) {
			create = false;
			sum += width;
//			sum += second;
			prefab.GetChild (0).GetComponent<SwingForce> ().forceStrength += 0.05f; 
			prefab.GetChild (0).GetComponent<SwingForce> ().maxSpeed += 0.05f; 
			prefab.GetChild (0).GetComponent<SwingForce> ().timePerOneSide += 0f; 
			Instantiate (prefab, new Vector3 (sum, Random.Range (4, 8), 0), Quaternion.identity);
			yield return new WaitForSeconds (Random.Range (0.2f, 2.8f));
			create = true;
		}
	}
}
