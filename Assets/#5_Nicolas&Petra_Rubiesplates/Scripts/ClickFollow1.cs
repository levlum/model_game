using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickFollow1 : MonoBehaviour
{
    public LayerMask clickOn;


    private NavMeshAgent myAgent;

    public CharacterController controller;

    public float jumpHeight = 10f;

    public Rigidbody rb;

    public float verticalVel;

    private Vector3 moveVector;

    private Vector3 velocity;

    [SerializeField] private float gravity;
    [SerializeField] private bool isGrounded;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask groundMask;

    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>(); 
        controller= this.GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        moveVector = new Vector3(0, verticalVel * .2f * Time.deltaTime, 0);

        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo, Mathf.Infinity))
            {
                myAgent.SetDestination(hitInfo.point);
            }

            if (Input.GetMouseButtonDown(1))
            {
                jumpCube();
            }



        }
    }
    private void jumpCube()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
    }
}


