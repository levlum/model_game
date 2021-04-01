using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecttile : MonoBehaviour
{
    public Rigidbody bulletPrefabs;
    public Rigidbody trash;
    public Rigidbody plant;
    public GameObject cursor;
    public LayerMask layer;
    public Transform shootPoint;
    private Camera cam;
    public float randomObject;
    public float i = 0;
    public timer Timer;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        Timer = GameObject.FindObjectOfType<timer>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        randomObject = Random.Range(0,5);
       LaunchProjectile();

         if (i == 20) {
                  Timer.finished = true;
                  Debug.Log("finised");
              }
    }
    void LaunchProjectile()
    {
        Ray camRay = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(camRay, out hit, 100f, layer))
        {
            cursor.SetActive(true);
            cursor.transform.position = hit.point + Vector3.up * 0.1f;

            Vector3 Vo = CalculateVelocity(hit.point, shootPoint.position, 1f);
            transform.rotation = Quaternion.LookRotation(Vo);

            if(Input.GetMouseButtonDown(0))
            {
                if (i < 20){
                    i++;
                if(randomObject == 0)
                {
                Rigidbody objWine = Instantiate(trash, shootPoint.position, Quaternion.identity);
                objWine.transform.rotation = Random.rotation ;
                objWine.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objWine.velocity = Vo;
               // Debug.Log(randomObject);
                }
                else if (randomObject == 1){
                Rigidbody objTrash = Instantiate(bulletPrefabs, shootPoint.position, Quaternion.identity);
                objTrash.transform.rotation = Random.rotation ;
                objTrash.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objTrash.velocity = Vo;
                //Debug.Log(randomObject);
                }
                else {
                Rigidbody objTrash = Instantiate(plant, shootPoint.position, Quaternion.identity);
                objTrash.transform.rotation = Random.rotation ;
                objTrash.transform.Rotate(new Vector3(Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f),Random.Range(-500.0f, 500.0f)) * Time.deltaTime, Space.World);

                objTrash.velocity = Vo;
                //Debug.Log(randomObject);
                }
            

              } 
            
            }
        }
        else{
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