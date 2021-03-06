using UnityEngine;
using System.Collections;

	public class DestroyOnCollision : MonoBehaviour {
	
	public bool destroySelfOnImpact = false;	
	public float delayBeforeDestroy = 0.0f;
	public GameObject explosionPrefab;


	void OnCollisionEnter(Collision collision) 						
		{	//uništavanje samog objekta koji se sudario
			Destroy (gameObject, delayBeforeDestroy);	
			if (explosionPrefab != null) {
				Instantiate (explosionPrefab, transform.position, transform.rotation);
				}
			}
	}





	
