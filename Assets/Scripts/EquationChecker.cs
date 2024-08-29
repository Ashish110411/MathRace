using System;
using UnityEngine;

public class EquationChecker : MonoBehaviour
{
    public RandomOperation randomOperation; // Reference to RandomOperation script
    public ScoreManager scoreManager; // Reference to ScoreManager script
    public GameObject gameOverScreen;
    

    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        gameOverScreen = GameObject.FindGameObjectWithTag("GameOverUI");
    }

    private void OnTriggerEnter(Collider other)
    {
        // Example check: Make sure to validate the collider as needed
        if (other.CompareTag("Player")) // Change "Player" to the tag of the relevant object
        {
            if (randomOperation.Operator == '+' && GameObject.FindWithTag("Addition"))
            {
                scoreManager.IncrementScore();
            }
            else if (randomOperation.Operator == '-' && GameObject.FindWithTag("Subtraction"))
            {
                scoreManager.IncrementScore();
            }
            else if (randomOperation.Operator == '*' && GameObject.FindWithTag("Multiplication"))
            {
                scoreManager.IncrementScore();
            }
            else if (randomOperation.Operator == '/' && GameObject.FindWithTag("Division"))
            {
                scoreManager.IncrementScore();
            }
            else
            {
                gameOverScreen.transform.GetChild(0).gameObject.SetActive(true);
                
            }
        }
    }
}