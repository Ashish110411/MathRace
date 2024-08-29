using System;
using UnityEngine;

public class EquationChecker : MonoBehaviour
{
    // public RandomOperation randomOperation; // Reference to RandomOperation script
    public ScoreManager scoreManager; // Reference to ScoreManager script

    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Example check: Make sure to validate the collider as needed
        if (other.CompareTag("Player")) // Change "Player" to the tag of the relevant object
        {
            Debug.Log("Correct");
            scoreManager.IncrementScore(); // Call method to increment score
        }
    }
}