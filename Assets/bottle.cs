using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottle : MonoBehaviour
{

    public static float point;
    public float _point;
    //public points script;
    //public Slider slider;
   // public int randomPlant;
public AudioSource plantAudio;
 public ParticleSystem drops;
  public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // script = GameObject.FindObjectOfType<points>();
              // _point = script._points;


    }

    // Update is called once per frame
    void Update()
    {
       // _point = script._points;  //  Update our score continuously.

    }

         //public Transform explosionPrefab;
                void OnCollisionEnter(Collision collision) {
                   if (collision.gameObject.tag == "house")

                   {//AudioSource.PlayClipAtPoint(plantAudio, this.gameObject.transform.position);
                      plantAudio.Play();
                      Debug.Log("braune Flasche an Wand");
                      //script._points+=3;
                      //slider.value = script._points;
                      //this.gameObject.SetActive(false) ;

                         ContactPoint contact = collision.contacts[0];
                         Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
                        Vector3 pos = contact.point;
                       // drops.Play();
                       // Instantiate(explosionPrefab, pos, rot);
                       // Instantiate(myPrefab, new Vector3(0, pos, rot), Quaternion.identity);
                            Instantiate(myPrefab,pos, rot);
                       Destroy(this.gameObject, 0.1f);


                   }
                }
}
