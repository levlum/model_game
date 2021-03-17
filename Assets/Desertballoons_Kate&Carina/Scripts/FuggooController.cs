using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Kate_Carina {
    public class FuggooController_kaca : MonoBehaviour
    {
    public GameObject explosion; // drag your explosion prefab here

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
        }

        void OnCollisionEnter()
        {
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(gameObject); // destroy the grenade
            Destroy(expl, 3); // delete the explosion after 3 seconds
        }
    }
}
