using UnityEngine;
using TMPro;

public class RandomOperation : MonoBehaviour
{
    
    public TextMeshProUGUI xText;
    
    public TextMeshProUGUI yText;
    
    public TextMeshProUGUI zText;
    

    public void GenerateRandomEquation()
    {
        // Generate two random integers between 1 and 100 (inclusive)
        int x = Random.Range(1, 10);
        int y = Random.Range(1, 10);

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
                    y = Random.Range(1, 10); // Regenerate y if conditions aren't met
                }
                z = x / y;
                break;
        }

        // Update TextMeshPro objects with the new equation
        xText.text = x.ToString();
        yText.text = y.ToString();
        zText.text = z.ToString();

        // Optionally log the equation for debugging
        // Debug.Log(x + " " + selectedOperator + " " + y + " = " + z);
    }
    void Start()
    {
        GenerateRandomEquation();
    }
}