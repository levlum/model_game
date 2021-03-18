using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{

    public GameObject bubbleOriginal;
    public float respawnTime = 1.0f;

    void Start()
    {
        StartCoroutine(bubbleWave());
        //GameObject BubbleClone = Instantiate(bubbleOriginal);
        //CreateBubbles(3);
    }

    private void spawnBubble() {
        GameObject a = Instantiate(bubbleOriginal) as GameObject;
        a.transform.position = new Vector3(Random.Range(0,1),1, Random.Range(0, 1));
    }

    IEnumerator bubbleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnBubble();
        }
      
    }

    //void CreateBubbles(int bubbleNum)
    //{
    //    for (int i = 0; i < bubbleNum; i++)
    //    {
    //        GameObject BubbleClone = Instantiate(bubbleOriginal, new Vector3(i, bubbleOriginal.transform.position.y, i), bubbleOriginal.rotation);
    //    }
    //}

}
