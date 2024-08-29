using UnityEngine;

public class DistanceTracker : MonoBehaviour
{
    public Transform player;          // Reference to the player object
    public ScoreManager scoreManager; // Reference to the ScoreManager script
 // Reference to the RandomOperation script

    private float lastRecordedPosition; // Tracks the last recorded position for scoring
    private float lastEquationPosition; // Tracks the last recorded position for equation generation
    private float scoreThreshold = 2f; // Distance threshold for score increment
    private float equationThreshold = 5f; // Distance threshold for equation generation

    void Start()
    {
        lastRecordedPosition = player.position.z;
        lastEquationPosition = player.position.z;
    }

    // void Update()
    // {
    //     float distanceTraveled = player.position.z - lastRecordedPosition;
    //
    //     // Check for score update
    //     if (distanceTraveled >= scoreThreshold)
    //     {
    //         scoreManager.IncrementScore(1); // Increase score by 1 for every 2 meters
    //         lastRecordedPosition = player.position.z; // Update the last recorded position for score
    //     }

        // Check for equation generation
        // if (player.position.z - lastEquationPosition >= equationThreshold)
        // {
        //     randomOperation.GenerateRandomEquation(); // Generate a new random equation
        //     lastEquationPosition = player.position.z; // Update the last recorded position for equation generation
        // }
    // }
}