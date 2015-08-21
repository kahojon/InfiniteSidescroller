using UnityEngine;
using System.Collections;

public class BarrelRoll : MonoBehaviour {
	public float speed = 300;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward * speed * Time.deltaTime, Space.World);
		Vector2 finalTransform = new Vector2 (-2f, 0f);
		transform.Translate (finalTransform, Space.World);
	}	
}
