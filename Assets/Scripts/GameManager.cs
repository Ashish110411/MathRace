
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverScript;
    public PlayerMovement playerMovement;
    public TextMeshProUGUI scoreText;
    public ScoreManager scoreManager;
    public void FixedUpdate()
    {
        scoreText.text = scoreManager.score.ToString("Score: 00");
        if (gameoverScript.activeInHierarchy)
        {
            playerMovement.speed = 0;
            if (Input.GetMouseButton(1))
            {
                gameoverScript.SetActive(false);
                Time.timeScale = 1;
                SceneManager.LoadScene(0);
            }
        }
        
    }
}
