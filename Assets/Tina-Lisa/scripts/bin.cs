using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bin : MonoBehaviour
{
    public Text binText;
    public int binCount = 0;
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
            binText.text = binCount.ToString();
        }
        private void OnTriggerEnter(Collider other)

        {
            if (other.gameObject.CompareTag("can"))
            {
                other.gameObject.SetActive(false);
                binCount++;
               UnityEngine.Debug.Log("can in bin");
            }
            if (other.gameObject.CompareTag("bottle"))
            {
                other.gameObject.SetActive(false);
                binCount--;
               UnityEngine.Debug.Log("can in bin");
            }
        }
}
