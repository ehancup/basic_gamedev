using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    public Text totalScore;
    public ScoreText score;
    // Update is called once per frame
    void Update()
    {
        totalScore.text = $"Score : {score.firstScore.ToString()}";
    }
}
