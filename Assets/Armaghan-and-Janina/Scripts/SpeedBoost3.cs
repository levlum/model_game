using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost3 : MonoBehaviour

{
    public GameObject particleSystem3;
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.AddForce(Vector3.up * 500);
            particleSystem3.SetActive(true);
            StartCoroutine("StopParticleSystem");
        }
    }
    
    public IEnumerator StopParticleSystem()
    {
        yield return new WaitForSeconds(3);
        particleSystem3.SetActive(false);
    }
}


