using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;
    void Start()
    {
        UpdateScoreText(); 
    }
    private void OnTriggerEnter(Collider other)
    {
        IncrementScore();
    }
    public void IncrementScore()
    {
        score++;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}