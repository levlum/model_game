using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost4 : MonoBehaviour

{
    public GameObject particleSystem4;
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.AddForce(Vector3.up * 500);
            particleSystem4.SetActive(true);
            StartCoroutine("StopParticleSystem");
        }
    }
    
    public IEnumerator StopParticleSystem()
    {
        yield return new WaitForSeconds(3);
        particleSystem4.SetActive(false);
    }
}


