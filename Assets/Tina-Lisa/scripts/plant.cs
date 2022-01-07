using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plant : MonoBehaviour
{

    public int plantCount = 0;
    public static float point; 
    public float _point;
    public points script;
    public Slider slider;
    public int randomPlant;
public AudioSource plantAudio;
public AudioSource error;
    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.FindObjectOfType<points>(); 
       _point = script._points;
        randomPlant = Random.Range(0,4);
    }

    // Update is called once per frame
    void Update()
    {    
        _point = script._points;  //  Update our score continuously.


    }
   
  

         public Transform explosionPrefab;
          public Transform explosionPrefabTwo;
          public Transform explosionPrefabThree;
                public Transform explosionPrefabFour;
                void OnCollisionEnter(Collision collision) {
                   if (collision.gameObject.tag == "house")
                   {//AudioSource.PlayClipAtPoint(plantAudio, this.gameObject.transform.position);

                      plantAudio.Play();
                      script._points+=3;
                      slider.value = script._points;
                      //this.gameObject.SetActive(false) ;
                         ContactPoint contact = collision.contacts[0];
                         Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
                        Vector3 pos = contact.point;
                        if (randomPlant == 0){
                        Instantiate(explosionPrefab, pos, rot);
                         Debug.Log("1 Plant");
                        }
                        else if (randomPlant == 1){
                        Instantiate(explosionPrefabTwo, pos, rot);
                         Debug.Log("2 Plant");
                         }
                          else if (randomPlant == 2){
                          Instantiate(explosionPrefabThree, pos, rot);
                           Debug.Log("3 Plant");
                          }
                         else if (randomPlant == 3){
                         Instantiate(explosionPrefabFour, pos, rot);
                          Debug.Log("4 Plant");
                          }

                        Debug.Log("Plant kaputt");
                       Destroy(this.gameObject, 0.1f);
                        

                   }
                   else if (collision.gameObject.tag == "tonne"){
                    error.Play();
                   }
                }
}
