using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Tisa
{

    public class cars : MonoBehaviour
    {
        public Text coinText;
        public GameObject korb;
        public int gross = 0; 
        public int coinCount = 0;
        public GameObject korbrand;
        public Collider other;

        //public GameManager gameManager;
        // Start is called before the first frame update
        void Start()
        {
            korb = GameObject.FindGameObjectWithTag("korb");
            korbrand = GameObject.FindGameObjectWithTag("korbrand");
        }

        // Update is called once per frame
        void Update()
        {
            if (gross > 0){
                 korb.transform.localScale = new Vector3(5, 1, 6);
                  korb.transform.position = new Vector3(-5, 5, 0);
                  korbrand.transform.localScale = new Vector3(1/2.0F, 1/3.0F, 5);
                    other.gameObject.SetActive(false);
                    gross --;
                    }
                    else {
                         korb.transform.localScale = new Vector3(2, 0, 2);
                  korb.transform.position = new Vector3(-10, 5, 0);
                  korbrand.transform.localScale = new Vector3(1/10.0F, 1/8.0F, 1*1.4F);
                    }
        }

        private void FixedUpdate()
        {
            coinText.text = coinCount.ToString();
        }

        private void OnTriggerEnter(Collider other)

        {
            this.other = other;
            if (other.gameObject.CompareTag("car"))
            {
                    gross = 100;
               
                //gameManager.addPoint();
                // korb.transform.position = new Vector3(0, 1.5f, 0);
                coinCount++;
               // UnityEngine.Debug.Log(myFirstObjectReference);
            }
        }

    
    }
}