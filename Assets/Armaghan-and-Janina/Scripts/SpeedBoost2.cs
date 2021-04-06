using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost2 : MonoBehaviour

{
    public GameObject particleSystem2;
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.AddForce(Vector3.up * 500);
            particleSystem2.SetActive(true);
            StartCoroutine("StopParticleSystem");
        }
    }
    
    public IEnumerator StopParticleSystem()
    {
        yield return new WaitForSeconds(3);
        particleSystem2.SetActive(false);
    }
}


