using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost1 : MonoBehaviour

{
    public GameObject particleSystem1;
    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody)
        {
            other.attachedRigidbody.AddForce(Vector3.up * 500);
            particleSystem1.SetActive(true);
            StartCoroutine("StopParticleSystem");
        }
    }
    
    public IEnumerator StopParticleSystem()
    {
        yield return new WaitForSeconds(3);
        particleSystem1.SetActive(false);
    }
}


