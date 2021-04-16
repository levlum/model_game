using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_controller : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] cubes;
    private int functionCallCount = 0;

    void Start()
    {
        cubes = GameObject.FindGameObjectsWithTag("cube");

        for (int j = 0; j < cubes.Length; j++)
        {
            cubes[j].SetActive(false);
        }

        StartCoroutine(Activate_Cubes());

        // for (int i = cubes.Length - 1; i > 0; i--)
        // {
        // }
    }
    IEnumerator Activate_Cubes()
    {

        for (int cube_nr = transform.childCount-1; cube_nr>=0; cube_nr--){
            yield return new WaitForSeconds(5);
            transform.GetChild(cube_nr).gameObject.SetActive(true);
        }
    }
    // private void setCube(int index)
    // {
    //     cubes[index].SetActive(true);
    // }
    // private int increment(int input)
    // {
    //     functionCallCount++;
    //     return input + (functionCallCount * 2);
    // }
}
