using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Reference to the TextMeshProUGUI component
    private int score = 0; // Class-level variable to track the score

    void Start()
    {
        UpdateScoreText(); // Initialize the score text on start
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to a specific object or layer if needed
        // Example: if (other.CompareTag("Player"))

        IncrementScore(); // Call the method to increment the score
    }

    public void IncrementScore()
    {
        score++; // Increment the score
        UpdateScoreText(); // Update the score display
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score; // Update the UI text with the current score
    }
}