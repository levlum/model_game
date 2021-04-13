using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Anas{
public class cam_ray : MonoBehaviour
{
   public float power = 1f;

   private bool last_frame_hit = false;

   // Start is called before the first frame update
   void Start()
   {

   }

   // Update is called once per frame
   void FixedUpdate()
   {
      RaycastHit hit;
      var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
      if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null)
      {
         if (!last_frame_hit)
         {
            hit.rigidbody.AddForce(Vector3.up * power, ForceMode.Impulse);
         }
         last_frame_hit = true;
      }
      else
      {
         last_frame_hit = false;
      }
   }
}
}