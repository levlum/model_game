using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enter_3 : MonoBehaviour
{
    public int coins_3 = 0;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "jumpy")
        {
            coins_3++;
        }
    }
}
