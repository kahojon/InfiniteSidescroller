using UnityEngine;
using System.Collections;

public class BarrelSpawn : MonoBehaviour {
	
	public GameObject[] obj;

	void Start(){
		Spawn ();
	}
	
	void Spawn()
	{
		Instantiate (obj[0],new Vector3(transform.position.x,transform.position.y),Quaternion.identity);
		Invoke (Spawn (), 2);
	}
}
