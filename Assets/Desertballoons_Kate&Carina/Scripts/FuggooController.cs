using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuggooController : MonoBehaviour
{
    public Text coinText;

    public int coinCount = 0;

    private void FixedUpdate()
    {
        coinText.text = coinCount.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("collectable"))
        {
            other.gameObject.SetActive(false);
            //gameManager.addPoint();
            coinCount++;
            UnityEngine.Debug.Log("score");
        }
    }
}

