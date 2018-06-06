using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour {

	public GameObject[] fruitToSpawn;

	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnFruit());
	}

	IEnumerator SpawnFruit() {
		while (true) {
			Vector3 randPosition = new Vector3(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y, transform.position.z);

			GameObject fruit = Instantiate(fruitToSpawn[Random.Range(0, fruitToSpawn.Length*10-8)/10], randPosition, Quaternion.identity);
			
			Rigidbody fruitRigid = fruit.GetComponent<Rigidbody>();
			fruitRigid.useGravity = true;

			fruitRigid.angularVelocity = new Vector3(Random.Range(-1,1), Random.Range(-1, 1), Random.Range(-1, 1));

			if (Random.Range(-1, 1) > 0)
				fruitRigid.velocity = new Vector3(0.5f, 5f, 0);
			else
				fruitRigid.velocity = new Vector3(-0.5f, 5f, 0);

			yield return new WaitForSeconds(1f);
		}
	}
	

}
