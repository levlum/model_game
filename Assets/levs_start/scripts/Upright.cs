using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lev
{
    public class Upright : MonoBehaviour
    {
        public float torque_power = 5f;

        Transform t;
        Rigidbody rb;
        private int last_side;
        private int up_side;

        void Start()
        {
            t = GetComponent<Transform>();   
            rb = GetComponent<Rigidbody>();
            float min = -1f; float max = 1f;
            var randomVec = new Vector3(UnityEngine.Random.Range(min, max), UnityEngine.Random.Range(min, max), UnityEngine.Random.Range(min, max));
            rb.AddTorque(randomVec * 50f, ForceMode.Impulse);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            Vector3 up = t.GetComponent<Transform>().InverseTransformDirection(Vector3.up) ;
                // up = t.GetComponent<Transform>().up;
                int side = -1;
                if (up == new Vector3(0, -1, 0)) side = 0;
                if (up == new Vector3(-1, 0, 0)) side = 1;
                if (up == new Vector3(1, 0, 0)) side = 2;
                if (up == new Vector3(0, 0, 1)) side = 3;
                if (up == new Vector3(0, 1, 0)) side = 4;
                if (up == new Vector3(0, 0, -1)) side = 5;
                if (side >= 0){
                    up_side = side;

                        float rot = -Mathf.DeltaAngle(Set_Letter_Up.rate_y[side], t.eulerAngles.y); 
                        // Debug.Log("neuer Buchstabe oben: "+up_letter+"  rot:"+rot);
                        if (Mathf.Abs(rot) > 5) rb.AddTorque(Vector3.up * rot * torque_power);

                    if (up_side != last_side){
                        last_side = up_side;
                        // float rot = Mathf.DeltaAngle(Set_Letter_Up.rate_y[side], t.eulerAngles.y); 
                        // Debug.Log("neuer Buchstabe oben: "+up_letter+"  rot:"+rot);
                        // rb.AddTorque(Vector3.up * rot * Time.deltaTime * torque_power, ForceMode.Impulse);
                    }
                }
        }
    }
}
