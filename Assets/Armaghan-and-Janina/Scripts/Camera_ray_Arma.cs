using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Camera_ray_Arma : MonoBehaviour
{
    //public GameObject Light1;
    //public GameObject Light2;
    //public GameObject Light3;
    //public GameObject Light4;
    public GameObject player;
    public AudioClip PassedRing;
    public AudioClip FinalRing;
    public Rigidbody rb_player;

    private Vector3 Cposition;
    private int CurrentLevel;
    private int PreviousLevel;

    // Start is called before the first frame update
    void Start()
    {
        Cposition = new Vector3(0.0f,24.0f,-36.0f);
        Debug.Log("Started");
        PreviousLevel = 1;
        CurrentLevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(Vector3.up, ForceMode.Impulse);
            //Debug.Log(hit.collider);
            if (hit.rigidbody.tag == "Player")
            {
                if (Input.GetMouseButtonDown(0))

                    hit.transform.Rotate(new Vector3(45, 0, 45));
            }
        }
        
    }

    void FixedUpdate()
    {
        PreviousLevel = CurrentLevel;
        if((player.transform.position[1]>=32)&&(player.transform.position[1]<48))
        {
            Cposition = new Vector3(0.0f,40.0f,-36.0f);
            CurrentLevel = 3;
//            Light1.SetActive(true);
//            Light2.SetActive(true);
//            Light3.SetActive(true);
//            Light4.SetActive(false);
        }
        if(player.transform.position[1]<16)
        {
            CurrentLevel = 1;
            Cposition = new Vector3(0.0f,24.0f,-36.0f);
//            Light1.SetActive(true);
//            Light2.SetActive(false);
//            Light3.SetActive(false);
//            Light4.SetActive(false);
        }
        if((player.transform.position[1]<32)&&(player.transform.position[1]>=16))
        {
            CurrentLevel = 2;
            Cposition = new Vector3(0.0f,24.0f,-36.0f);
//            Light1.SetActive(true);
//            Light2.SetActive(true);
//            Light3.SetActive(false);
//            Light4.SetActive(false);
        }
        if((player.transform.position[1]>=48)&&(player.transform.position[1]<64))
        {
            CurrentLevel = 4;
            Cposition = new Vector3(0.0f,56.0f,-36.0f);
//            Light1.SetActive(true);
//            Light2.SetActive(true);
//            Light3.SetActive(true);
//            Light4.SetActive(true);
        }
        if(player.transform.position[1]>=64)
        {
            CurrentLevel = 5;
            Cposition = new Vector3(0.0f,72.0f,-36.0f);
            AudioSource.PlayClipAtPoint(FinalRing, transform.position, 1);
        }
        if (CurrentLevel > PreviousLevel)
        {
            AudioSource.PlayClipAtPoint(PassedRing, transform.position, 1);
            if(CurrentLevel == 3 || CurrentLevel == 4)
            {
                rb_player.AddForce(Vector3.up, ForceMode.Impulse);
                Debug.Log("Impulse");
                Debug.Log(player.GetComponent<Collider>());
            }
        }
    }
// Trigger did not work. Don't know why!
/*    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.gameObject.CompareTag("Level1"))
        {
            
            Level1.SetActive(false);
            Level2.SetActive(true);
            Level3.SetActive(true);
            Cposition = new Vector3(0.0f,24.0f,-36.0f);
            Debug.Log("Level1");
        }
        if (other.gameObject.CompareTag("Level2"))
        {
            Level1.SetActive(true);
            Level2.SetActive(false);
            Level3.SetActive(true);
            Cposition = new Vector3(0.0f,40.0f,-36.0f);
        }
        if (other.gameObject.CompareTag("Level3"))
        {
            Level1.SetActive(true);
            Level2.SetActive(true);
            Level3.SetActive(false);
            Cposition = new Vector3(0.0f,56.0f,-36.0f);
        }
    }
*/
    void LateUpdate()
    {
        transform.position = Cposition;
    }
}