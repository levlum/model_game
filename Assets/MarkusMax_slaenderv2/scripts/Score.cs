using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private Text score;
    private int scoreAmount;

    void Start()
    {
        scoreAmount = 0;
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = scoreAmount.ToString();
    }

    public void AddScore()
    {
        scoreAmount += 1;
    }

}
