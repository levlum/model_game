using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Projecttile : MonoBehaviour
{

    public Rigidbody bulletPrefabs;
    public Rigidbody greenBottlePrefab;
    public Rigidbody whiteBottlePrefab;
    public Rigidbody trash;
    public Rigidbody plant;
    public Rigidbody whiteBottlePref;
     public Rigidbody SamenBallPref;
     public Rigidbody greenBottlePref;
      public Rigidbody brownBottlePref;
      public Rigidbody canPref;
    public GameObject cursor;
    public GameObject whiteBottlePointer;
    public GameObject greenBottlePointer;
    public GameObject brownBottlePointer;
    public GameObject canPointer;
    public GameObject samenPointer;
    public LayerMask layer;
    public Transform shootPoint;
    private Camera cam;
    public float randomObject;
    public float i = 0;
    public timer Timer;
    public RaycastHit hit;
    public GameObject endscreen;
    public Button btn;
    public Button quit;

    // Start is called before the first frame update
    void Start()
    {
         //Button btn = PlayAgainButton.GetComponent<Button>();
        btn.onClick.AddListener(RestartGame);
        quit.onClick.AddListener(QuitGame);
       
        randomObject = Random.Range(0,8);
        /*if(randomObject == 0)
                        {
                    SamenBallPref.gameObject.SetActive(true);
                    canPref.gameObject.SetActive(false);
                    brownBottlePref.gameObject.SetActive(false);
                    greenBottlePref.gameObject.SetActive(false);
                 whiteBottlePref.gameObject.SetActive(false);
                 
                                
                      }  
                      if(randomObject == 1 || randomObject == 2)
                        {
                    canPref.gameObject.SetActive(true);
                    SamenBallPref.gameObject.SetActive(false);
                    brownBottlePref.gameObject.SetActive(false);
                 greenBottlePref.gameObject.SetActive(false);
                                whiteBottlePref.gameObject.SetActive(false);
                      } 
                      if(randomObject == 3 || randomObject == 4)
                        {
                    brownBottlePref.gameObject.SetActive(true);
                    canPref.gameObject.SetActive(false);
                    SamenBallPref.gameObject.SetActive(false);
                 whiteBottlePref.gameObject.SetActive(false);
                               greenBottlePref.gameObject.SetActive(false); 
                      } 
                      if(randomObject == 5 || randomObject == 6)
                        {
                    greenBottlePref.gameObject.SetActive(true);
                    canPref.gameObject.SetActive(false);
                    SamenBallPref.gameObject.SetActive(false);
                    brownBottlePref.gameObject.SetActive(false);
                 whiteBottlePref.gameObject.SetActive(false);
                                
                      } 
                       if(randomObject == 7 || randomObject == 8)
                        {
                    whiteBottlePref.gameObject.SetActive(true);
                    canPref.gameObject.SetActive(false);
                    SamenBallPref.gameObject.SetActive(false);
                    brownBottlePref.gameObject.SetActive(false);
                 greenBottlePref.gameObject.SetActive(false);
                                
                      }  */
                    if(randomObject == 0)
                    {
                    whiteBottlePointer.SetActive(false);
                    canPointer.SetActive(false);
                    brownBottlePointer.SetActive(false);
                    greenBottlePointer.SetActive(false); samenPointer.SetActive(true);
                    samenPointer.transform.position = hit.point + Vector3.up * 0.1f;    
                    }  
                    if(randomObject == 1 || randomObject == 2)
                    {
                     samenPointer.SetActive(false);
                     whiteBottlePointer.SetActive(false);
                     brownBottlePointer.SetActive(false);
                     greenBottlePointer.SetActive(false);
                     canPointer.SetActive(true);
                     canPointer.transform.position = hit.point + Vector3.up * 0.1f;
                    } 
                    if(randomObject == 3 || randomObject == 4)
                    {
                    samenPointer.SetActive(false);
                    canPointer.SetActive(false);
                    whiteBottlePointer.SetActive(false);
                    greenBottlePointer.SetActive(false);
                    brownBottlePointer.SetActive(true);
                    brownBottlePointer.transform.position = hit.point + Vector3.up * 0.1f;
                    } 
                    if(randomObject == 5 || randomObject == 6)
                    {
                    samenPointer.SetActive(false);
                    canPointer.SetActive(false);
                    brownBottlePointer.SetActive(false);
                    whiteBottlePointer.SetActive(false);
                    greenBottlePointer.SetActive(true);
                    greenBottlePointer.transform.position = hit.point + Vector3.up * 0.1f;
                    } 
                    if(randomObject == 7 || randomObject == 8)
                    { 
                    samenPointer.SetActive(false);
                    canPointer.SetActive(false);
                    brownBottlePointer.SetActive(false);
                    greenBottlePointer.SetActive(false);
                    whiteBottlePointer.SetActive(true);
                    whiteBottlePointer.transform.position = hit.point + Vector3.up * 0.1f;  
                    } 
        
        cam = Camera.main;
        Timer = GameObject.FindObjectOfType<timer>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
       //
       //Debug.Log(randomObject);
        LaunchProjectile();
       
         if (i == 20) {
                  Timer.finished = true;
                  Debug.Log("finished");
                   endscreen.gameObject.SetActive(true);
              }
    }
    void LaunchProjectile()
    {
        Ray camRay = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(camRay, out hit, 100f, layer))
        {
           // whiteBottlePointer.SetActive(true);
           // whiteBottlePointer.transform.position = hit.point + Vector3.up * 0.1f;

            Vector3 Vo = CalculateVelocity(hit.point, shootPoint.position, 1f);
            transform.rotation = Quaternion.LookRotation(Vo);
      if(randomObject == 0)
                    {
                 SamenBallPref.gameObject.SetActive(false);
                    canPref.gameObject.SetActive(false);
                    brownBottlePref.gameObject.SetActive(false);
                    greenBottlePref.gameObject.SetActive(false);
                 whiteBottlePref.gameObject.SetActive(false);
                    samenPointer.SetActive(true);
            samenPointer.transform.position = hit.point + Vector3.up * 0.1f;    
                      }  
                      if(randomObject == 1 || randomObject == 2)
                        {
                    canPref.gameObject.SetActive(true);
                    SamenBallPref.gameObject.SetActive(false);
                    brownBottlePref.gameObject.SetActive(false);
                 greenBottlePref.gameObject.SetActive(false);
                                whiteBottlePref.gameObject.SetActive(false);
                                canPointer.SetActive(true);
            canPointer.transform.position = hit.point + Vector3.up * 0.1f;
                      } 
                      if(randomObject == 3 || randomObject == 4)
                        {
                    brownBottlePref.gameObject.SetActive(true);
                    canPref.gameObject.SetActive(false);
                    SamenBallPref.gameObject.SetActive(false);
                 whiteBottlePref.gameObject.SetActive(false);
                               greenBottlePref.gameObject.SetActive(false); 
                               brownBottlePointer.SetActive(true);
            brownBottlePointer.transform.position = hit.point + Vector3.up * 0.1f;
                      } 
                      if(randomObject == 5 || randomObject == 6)
                        {
                    greenBottlePref.gameObject.SetActive(true);
                    canPref.gameObject.SetActive(false);
                    SamenBallPref.gameObject.SetActive(false);
                    brownBottlePref.gameObject.SetActive(false);
                 whiteBottlePref.gameObject.SetActive(false);
                 greenBottlePointer.SetActive(true);
            greenBottlePointer.transform.position = hit.point + Vector3.up * 0.1f;
                                
                      } 
                       if(randomObject == 7 || randomObject == 8)
                        {
                    whiteBottlePref.gameObject.SetActive(true);
                    canPref.gameObject.SetActive(false);
                    SamenBallPref.gameObject.SetActive(false);
                    brownBottlePref.gameObject.SetActive(false);
                 greenBottlePref.gameObject.SetActive(false);
                    whiteBottlePointer.SetActive(true);
            whiteBottlePointer.transform.position = hit.point + Vector3.up * 0.1f;  
                      }                 
                    
              
            if(Input.GetMouseButtonDown(0))
            {
                
                if (i < 20){
                    i++;
                if(randomObject == 0)
                {
                Rigidbody objPlant = Instantiate(plant, shootPoint.position, Quaternion.identity);
                objPlant.transform.rotation = Random.rotation ;
                objPlant.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objPlant.velocity = Vo;
               // Debug.Log(randomObject);
                }
                else if (randomObject == 1 || randomObject == 2){
                Rigidbody objTrash = Instantiate(trash, shootPoint.position, Quaternion.identity);
                objTrash.transform.rotation = Random.rotation ;
                objTrash.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objTrash.velocity = Vo;
                //Debug.Log(randomObject);
                }
                else if (randomObject == 3 || randomObject == 4) {
                    
                Rigidbody objTrash = Instantiate(bulletPrefabs, shootPoint.position, Quaternion.identity);
                objTrash.transform.rotation = Random.rotation ;
                objTrash.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objTrash.velocity = Vo;
                //Debug.Log(randomObject);
                
            
                         
                     }
                     else if (randomObject == 5 || randomObject == 6) {
                    
                Rigidbody objTrash = Instantiate(greenBottlePrefab, shootPoint.position, Quaternion.identity);
                objTrash.transform.rotation = Random.rotation ;
                objTrash.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objTrash.velocity = Vo;
                //Debug.Log(randomObject);
                
            
                         
                     }
                      else {
                    
                Rigidbody objTrash = Instantiate(whiteBottlePrefab, shootPoint.position, Quaternion.identity);
                objTrash.transform.rotation = Random.rotation ;
                objTrash.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objTrash.velocity = Vo;
                //Debug.Log(randomObject);
                
            
                         
                     }
                    randomObject = Random.Range(0,8);
                    }        else{
                    cursor.SetActive(false);
                  }
            }

    Vector3 CalculateVelocity(Vector3 target, Vector3 origin, float time)
    {
            //define distance x and y
            Vector3 distance = target - origin;
            Vector3 distanceXZ = distance;
            distanceXZ.y = 0f;

            //create float that represents our distance
            float Sy = distance.y;
            float Sxz = distanceXZ.magnitude;

            float Vxz = Sxz / time;
            float Vy = Sy / time + 0.5f * Mathf.Abs(Physics.gravity.y) * time;


            Vector3 result = distanceXZ.normalized;
            result *= Vxz;
            result.y = Vy;

            return result;
    }
        }
}
 public void RestartGame() {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         }
 public void QuitGame() {
     Debug.Log("Quit");
    //     Application.;
 }
}