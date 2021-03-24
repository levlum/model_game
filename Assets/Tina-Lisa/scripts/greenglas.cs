using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class greenglas : MonoBehaviour
{
    public Text greenText;
    public int greenCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
        {
            greenText.text = greenCount.ToString();
        }
        private void OnTriggerEnter(Collider other)

        {
            if (other.gameObject.CompareTag("bottle"))
            {
                other.gameObject.SetActive(false);
                greenCount++;
               UnityEngine.Debug.Log("bottle in bin");
            }
            if (other.gameObject.CompareTag("can"))
            {
                other.gameObject.SetActive(false);
                greenCount--;
               UnityEngine.Debug.Log("bottle in bin");
            }
        }
}
