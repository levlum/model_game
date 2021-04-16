using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost6 : MonoBehaviour

{
    public GameObject particleSystem6;
    public AudioClip BoostSound;
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.AddForce(Vector3.up * 1000f * Time.deltaTime, ForceMode.Impulse);
            particleSystem6.SetActive(true);
            AudioSource.PlayClipAtPoint(BoostSound, transform.position, 1);
            StartCoroutine("StopParticleSystem");
        }
    }
    
    public IEnumerator StopParticleSystem()
    {
        yield return new WaitForSeconds(3);
        particleSystem6.SetActive(false);
    }
}


