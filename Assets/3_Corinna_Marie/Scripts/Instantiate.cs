using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject bubbleOriginal;
    GameObject bubbleClone;
    public float respawnTime = 1.0f;

    private void Update()
    {

        bubbleClone = Instantiate(bubbleOriginal, transform.position, Quaternion.identity) as GameObject;
        bubbleClone.transform.position = new Vector3(Random.Range(0, 30), 5, Random.Range(0, 30));
        Destroy(bubbleClone, 4);
    }
}
