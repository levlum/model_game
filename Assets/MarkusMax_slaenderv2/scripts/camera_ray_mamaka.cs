using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class camera_ray_mamaka : MonoBehaviour
{
    public float power = 10f;

    public float pointsPerHIT = 1;
    private float score = 5000;
    public GameObject Player;
    public GameObject gameOverText;

    GUIStyle myStyle = new GUIStyle();



    // Start is called before the first frame update
    void Start()
    {
        myStyle.normal.textColor = Color.white;
        myStyle.fontSize = 50;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        RaycastHit hit;
        var ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 50) && hit.rigidbody != null)
        {
            hit.rigidbody.AddForce(Vector3.up * Time.deltaTime * power, ForceMode.Impulse);

            if (hit.collider.tag == "Player")
            {
                AddPoints(pointsPerHIT);
            }
        }


        if (score == 0)
        {
            UnityEngine.Debug.Log("YOU WIN!");
            {
                SceneManager.LoadScene("menu");
            }
            //gameOverText.SetActive(true);
            //StartCoroutine(waitALittleBit());
        }
        //}
    }


    void OnGUI()
    {
        //guiStyle.fontSize = 20;
        GUILayout.BeginArea (new Rect(Screen.width / 18, Screen.height / 18, 3000, 3000));
        GUILayout.Label("Energy left: " + score.ToString("0"), myStyle);
        GUILayout.EndArea();
    }

    void AddPoints(float points)
    {
        score -= points;

    }
}