using UnityEngine;
using System.Collections;

public class FlyScript : MonoBehaviour {

	float heightTest = 10.5f;

	void Start() {
		/* Debug.Log(transform.position.y); */
		if (transform.position.y <= heightTest) {
			/* Debug.Log("Coming down!"); */
			Fly();
		} /* else if (transform.position.y >= heightTest) {
			Debug.Log("Still flying!");
		} */
	}

	void Fly() {
		/* Debug.Log("Flying up!"); */
		Vector3 newPosition = new Vector3(0,10,0);
		transform.position = newPosition;
	}


}