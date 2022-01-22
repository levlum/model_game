using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hut : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "dog")
        {
            Object.Destroy(gameObject);
        }
        
    }
}
