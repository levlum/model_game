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

        for (int i = cubes.Length - 1; i > 0; i--)
        {
            Debug.Log(i);
            StartCoroutine(ExampleCoroutine(i));
        }
    }
    IEnumerator ExampleCoroutine(int cubeCount)
    {
        yield return new WaitForSeconds(increment(5));
        setCube(cubeCount);
    }
    private void setCube(int index)
    {
        cubes[index].SetActive(true);
    }
    private int increment(int input)
    {
        functionCallCount++;
        return input + (functionCallCount * 2);
    }
}
