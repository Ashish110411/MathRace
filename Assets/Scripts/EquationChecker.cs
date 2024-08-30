using UnityEngine;

public class EquationChecker : MonoBehaviour
{
    public RandomOperation randomOperation;
    public ScoreManager scoreManager;
    public GameObject gameOverScreen;
    
    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        gameOverScreen = GameObject.FindGameObjectWithTag("GameOverUI");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bool isCorrect = false;
            foreach (char validOperator in randomOperation.ValidOperators)
            {
                if (validOperator == '+')
                {
                    if (GameObject.FindWithTag("Addition"))
                    {
                        isCorrect = true;
                        break;
                    }
                }
                else if (validOperator == '-')
                {
                    if (GameObject.FindWithTag("Subtraction"))
                    {
                        isCorrect = true;
                        break;
                    }
                }
                else if (validOperator == '*')
                {
                    if (GameObject.FindWithTag("Multiplication"))
                    {
                        isCorrect = true;
                        break;
                    }
                }
                else if (validOperator == '/')
                {
                    if (GameObject.FindWithTag("Division"))
                    {
                        isCorrect = true;
                        break;
                    }
                }
            }

            if (isCorrect)
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