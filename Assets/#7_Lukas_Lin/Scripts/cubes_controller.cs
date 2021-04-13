using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubes_controller : MonoBehaviour
{
    public GameObject Cube = null;

    public void Start()
    {
        //Cube.SetActive(false);

        //ShowCube();

        //StartCoroutine(WaitBeforeShow());

        //Cube.SetActive(true);

        Invoke("SetCube", 2);//this will happen after 2 second
    }

    private IEnumerator WaitBeforeShow()
    {
        yield return new WaitForSeconds(5);

    }


    private void SetCube()
    {
        Cube.SetActive(true);
    }

    

}
