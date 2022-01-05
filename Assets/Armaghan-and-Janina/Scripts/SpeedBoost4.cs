using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost4 : MonoBehaviour

{
    public GameObject particleSystem4;
    public AudioClip BoostSound;
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.AddForce(Vector3.down *300);
            particleSystem4.SetActive(true);
            AudioSource.PlayClipAtPoint(BoostSound, transform.position, 5);
            StartCoroutine("StopParticleSystem");
        }
    }
    
    public IEnumerator StopParticleSystem()
    {
        yield return new WaitForSeconds(3);
        particleSystem4.SetActive(false);
    }
}


