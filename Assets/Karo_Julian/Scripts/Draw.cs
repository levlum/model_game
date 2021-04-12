using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour

{
    public GameObject Splash_Prefab;
    GameObject obj;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            obj = Instantiate(Splash_Prefab, transform.position, Quaternion.identity);
            /*if (Input.GetButton("Fire1"))
            {
                obj = Instantiate(Splash_Prefab, transform.position, Quaternion.identity);

            }
            //CreateInstance();
            //GameObject splash =  Instantiate(Splash_Prefab);
            //splash.transform.SetParent(GameObject.Find("Floor").transform);
            */

        }

        
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            obj = Instantiate(Splash_Prefab, transform.position, Quaternion.identity);
        }
    }


    private void FixedUpdate()
     {

        if (Input.GetButton("Fire2"))
        {
            Destroy(GameObject.FindWithTag("Dot"));
        }
    }

    /* public void CreateInstance()
     {
         obj = Instantiate(Splash_Prefab, transform.position, Quaternion.identity);
         //Instantiate(Splash_Prefab, )
     }
     public void DestroyInstance()
     {
         Destroy(obj);
     }
     */
}
