using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_movement : MonoBehaviour
{
    public float speed = 2.0f;
    public Vector3 desiredPos;
    public float timer = 1f;
    public float timerSpeed;
    public float timeToMove;
    private float xPos;
    private float zPos;


    void Start()
    {
        xPos = Random.Range(5f, 95f);
        zPos = Random.Range(5f, 95f);
        desiredPos = new Vector3(xPos, transform.position.y, zPos);
    }

    void Update()
    {
        timer += Time.deltaTime * timerSpeed;
        if (timer >= timeToMove)
        {
            transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * speed);
            if (Vector3.Distance(transform.position, desiredPos) <= 0.01f)
            {
                xPos = Random.Range(5f, 95f);
                zPos = Random.Range(5f, 95f);
                desiredPos = new Vector3(xPos, transform.position.y, zPos);
                timer = 0.0f;
            }
        }
    }
}
