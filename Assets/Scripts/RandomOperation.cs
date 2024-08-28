using UnityEngine;
using TMPro; // Include this for TextMeshPro

public class RandomOperation : MonoBehaviour
{
    public TextMeshProUGUI xText; // Reference to the TextMeshProUGUI component for x
    public TextMeshProUGUI yText; // Reference to the TextMeshProUGUI component for y
    public TextMeshProUGUI resultText; // Reference to the TextMeshProUGUI component for z

    void Start()
    {
        // Generate and display random numbers and operator
        GenerateAndDisplayRandomOperation();
    }

    public void GenerateAndDisplayRandomOperation()
    {
        // Generate two random integers between 1 and 100 (inclusive)
        int x = Random.Range(1, 101);
        int y = Random.Range(1, 101);

        // Array of operators
        char[] operators = new char[] { '+', '-', '*', '/' };

        // Randomly select an operator
        int operatorIndex = Random.Range(0, operators.Length);
        char selectedOperator = operators[operatorIndex];

        // Initialize the result variable
        int z = 0;

        switch (selectedOperator)
        {
            case '+':
                z = x + y;
                break;
            case '-':
                z = x - y;
                break;
            case '*':
                z = x * y;
                break;
            case '/':
                // Handle division by ensuring y is not zero and x is divisible by y
                while (y == 0 || x % y != 0)
                {
                    y = Random.Range(1, 101); // Regenerate y if conditions aren't met
                }
                z = x / y;
                break;
        }

        // Update the TextMeshProUGUI components with the values
        if (xText != null)
        {
            xText.text =x.ToString();
        }

        if (yText != null)
        {
            yText.text = y.ToString();
        }

        if (resultText != null)
        {
            resultText.text =z.ToString();
        }
    }
}