using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text score;
    public GameManager gameManager;
    public float firstScore = 0;
    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameOver)
        {
            score.text = $"Game Over\nScore : {firstScore.ToString("0")}";
        }
        else
        {
            score.text = $"Score : {firstScore.ToString("0")}";
        }
    }

    void FixedUpdate()
    {
        if (!gameManager.isGameDone)
        {
            ScoreIncrement();
        }
    }

    public void ScoreIncrement()
    {
        firstScore++;
    }
}
