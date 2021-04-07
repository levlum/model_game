using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost5 : MonoBehaviour

{
    public GameObject particleSystem5;
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.AddForce(Vector3.up * 500);
            particleSystem5.SetActive(true);
            StartCoroutine("StopParticleSystem");
        }
    }
    
    public IEnumerator StopParticleSystem()
    {
        yield return new WaitForSeconds(3);
        particleSystem5.SetActive(false);
    }
}


