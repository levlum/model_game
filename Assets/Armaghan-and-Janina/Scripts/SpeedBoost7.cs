using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost7 : MonoBehaviour

{
    public GameObject particleSystem7;
    public AudioClip BoostSound;
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.AddForce(Vector3.up * 500);
            particleSystem7.SetActive(true);
            AudioSource.PlayClipAtPoint(BoostSound, transform.position, 1);
            StartCoroutine("StopParticleSystem");
        }
    }
    
    public IEnumerator StopParticleSystem()
    {
        yield return new WaitForSeconds(3);
        particleSystem7.SetActive(false);
    }
}


