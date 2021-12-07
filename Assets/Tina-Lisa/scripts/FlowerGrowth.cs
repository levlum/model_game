using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerGrowth : MonoBehaviour
{
    public float timer = 0f;
    public float growTime = 6f;
    public float maxSize = 2f;

    public bool isMaxSize = false;
    void Start()
    {
        if(isMaxSize == false){
        StartCoroutine(Grow());
        }
    }
private IEnumerator Grow()
{
Vector3 startScale = transform.localScale;
Vector3 maxScale = new Vector3(maxSize, maxSize, maxSize);

do {
//Grow
transform.localScale = Vector3.Lerp(startScale, maxScale, timer / growTime);

//Increment timer
timer += Time.deltaTime;

// Yield
yield return null;

}
while(timer < growTime);

isMaxSize = true;
}


}
