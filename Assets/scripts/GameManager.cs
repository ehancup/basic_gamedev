using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameDone = false;
    public bool isGameOver = false;
    public float restartDelay = 2f;
    public GameObject levelCompleteUI;
    public void GameOver()
    {
        if (!isGameOver)
        {

            isGameOver = true;
            isGameDone = true;
            Debug.Log("game over");
            Invoke("Restart", restartDelay);
        }
    }

    public void LevelCompleted()
    {
        isGameDone = true;
        levelCompleteUI.SetActive(true);
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
