using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;


	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Ground")
			Spawn ();
	}

	void Spawn()
	{
		Instantiate (obj[0],new Vector3(transform.position.x,transform.position.y),Quaternion.identity);
	}
}
