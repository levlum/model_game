using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Vector3 = UnityEngine.Vector3;

    

namespace _3_Corinna_Marie.Scripts
{
    public class Player : MonoBehaviour
    {
        [FormerlySerializedAs("m_speed")] [SerializeField] private float mSpeed = 1f;
        private Rigidbody _mPlayerRigidbody;
/*
    private Rigidbody jumpplane;
*/
        public Vector3 jump;
        public float jumpForce = 2.0f;
        public bool isGrounded;
    
    


        // Start is called before the first frame update
        void Start()
        {
            _mPlayerRigidbody = GetComponent<Rigidbody>();
            jump = new Vector3(0.0f, 2.0f, 0.0f);
        }

    
        private void OnCollisionStay()
        {
            isGrounded= true;
        }
    
    
    
        // Update is called once per frame
        void Update()
        {
            Vector3 movement = new Vector3(0f, 0f, 0f);
            _mPlayerRigidbody.AddForce((movement*mSpeed));
        
        
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                _mPlayerRigidbody.AddForce(jump*jumpForce,ForceMode.Impulse);
                isGrounded = false;
            }

            if (GameObject.Find("duck").transform.position.y <= -50)
            {
                UnityEngine.Debug.Log("Game Over!");
                SceneManager.LoadScene("GameOver");
            }


        }

    

    }
}
    



