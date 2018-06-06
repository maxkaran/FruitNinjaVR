using UnityEngine;
using System.Collections;

public class SwordCut : MonoBehaviour {

	public Material capMaterial;

	void OnCollisionEnter(Collision collision) {
		GameObject victim = collision.collider.gameObject;

		GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

		pieces[0].tag = "Fruit";
		pieces[1].tag = "Fruit";

		pieces[0].AddComponent<DestructorFall>();
		pieces[1].AddComponent<DestructorFall>();

		if (!pieces[1].GetComponent<Rigidbody>()) {
			pieces[1].AddComponent<Rigidbody>();
			
			MeshCollider mesh = pieces[1].AddComponent<MeshCollider>();
			mesh.convex = true;
		}

		//Destroy(pieces[1], 1);
	}

}
