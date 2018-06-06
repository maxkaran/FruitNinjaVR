using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {

	void OnCollisionEnter(Collision collision) {
		if(collision.collider.tag == "Fruit") {
			Destroy(collision.collider.gameObject);
		}
	}
}
