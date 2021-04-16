using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lev
{
    public enum  Letters
    {
        A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,z0,z1,z2,z3,z4,z5,z6,z7,z8,z9
    }
    public class Set_Letter_Up : MonoBehaviour
    {
        public Letters letter;
        public Texture[] textures; 
        public float torque_power = 5f;

        // private Letters last_letter;

        public static Vector3[] sides = {
                new Vector3(0, -1, 0), //a (r=b) (f=f)
                new Vector3(-1, 0, 0), //b (r=f) (f=a)
                new Vector3(1, 0, 0), //c (r=d) (f=a)
                new Vector3(0, 0, 1), //d (r=b) (f=a)
                new Vector3(0, 1, 0), //e (r=b) (f=d)
                new Vector3(0, 0, -1)}; //f (r=c) (f=a)

        // private static Vector3[] rights = {
        //         new Vector3(1, 0, 0), //b
        //         new Vector3(0, 0, -1), //f
        //         new Vector3(0, 0, 1), //d
        //         new Vector3(1, 0, 0), //b
        //         new Vector3(-1, 0, 0), //b
        //         new Vector3(1, 0, 0)};//c
        // private static Vector3[] forwards = {
        //         new Vector3(0, 0, -1), //f
        //         new Vector3(0, -1, 0), //a
        //         new Vector3(0, -1, 0), //a
        //         new Vector3(0, -1, 0), //a
        //         new Vector3(0, 0, 1), //d
        //         new Vector3(0, -1, 0)};//a

        private Transform t;
        private Material m;
        private Rigidbody rb;
        private Letters last_letter;
        private Letters up_letter;

        public static float[] rate_y = {0, -90, 90, 180, 180, 0};

        // Start is called before the first frame update
        void Start()
        {
            m = GetComponent<Renderer>().material;
            t = GetComponent<Transform>();
            rb = GetComponent<Rigidbody>();
            m.SetTexture("_MainTex", textures [(int)letter / 6]);
            var face = Set_Letter_Up.sides[(int)letter % 6];
            var alpha = Set_Letter_Up.rate_y[(int)letter % 6];
            t.rotation = Quaternion.FromToRotation(face, Vector3.up);
            t.Rotate(0, alpha, 0, Space.World);
            up_letter = letter;
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            //find, which letter is up.
            
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
                up_letter = (Letters)((int)letter/6 + side);

                    float rot = -Mathf.DeltaAngle(Set_Letter_Up.rate_y[side], t.eulerAngles.y); 
                    // Debug.Log("neuer Buchstabe oben: "+up_letter+"  rot:"+rot);
                    if (Mathf.Abs(rot) > 5) rb.AddTorque(Vector3.up * rot * Time.deltaTime * torque_power);

                if (up_letter != last_letter){
                    last_letter = up_letter;
                    // float rot = Mathf.DeltaAngle(Set_Letter_Up.rate_y[side], t.eulerAngles.y); 
                    // Debug.Log("neuer Buchstabe oben: "+up_letter+"  rot:"+rot);
                    // rb.AddTorque(Vector3.up * rot * Time.deltaTime * torque_power, ForceMode.Impulse);
                }
            }


            if (letter != last_letter){

            }
        }

    }  
}
