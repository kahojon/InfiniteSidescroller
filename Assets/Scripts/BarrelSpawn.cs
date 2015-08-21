using UnityEngine;
using System.Collections;

public class BarrelSpawn : MonoBehaviour {
	
	public GameObject[] obj;

	void Start(){
		InvokeRepeating ("Spawn", 1, 3);

	}
	
	void Spawn()
	{
		Instantiate (obj[Random.Range(0,obj.GetLength(0))],new Vector3(transform.position.x,transform.position.y),Quaternion.identity);

	}
}
