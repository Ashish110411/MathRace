using UnityEngine;
using TMPro;

public class RandomOperation : MonoBehaviour
{
    public TextMeshProUGUI xText;
    public TextMeshProUGUI yText;
    public TextMeshProUGUI zText;
    public char[] ValidOperators;

    public void GenerateRandomEquation()
    {
        int x = 0, y = 0, z = 0;
        char[] operators = new char[] { '+', '-', '*', '/' };
        ValidOperators = new char[2]; // Array to store up to 2 valid operators

        // Randomly select an operator to start with
        int operatorIndex = Random.Range(0, operators.Length);
        char selectedOperator = operators[operatorIndex];

        switch (selectedOperator)
        {
            case '+':
                x = Random.Range(1, 10);
                y = Random.Range(1, 10);
                z = x + y;
                ValidOperators[0] = '+';
                break;

            case '-':
                x = Random.Range(1, 10);
                y = Random.Range(1, x + 1); // Ensure y <= x to avoid negative results
                z = x - y;
                ValidOperators[0] = '-';

                if (x % y == 0 && x / y == z)
                {
                    ValidOperators[1] = '/';
                }
                break;

            case '*':
                x = Random.Range(1, 10);
                y = Random.Range(1, 10);
                z = x * y;
                ValidOperators[0] = '*';

                if (x % y == 0 && x / y == z)
                {
                    ValidOperators[1] = '/';
                }
                break;

            case '/':
                y = Random.Range(1, 10);
                z = Random.Range(1, 10);
                x = y * z; // Ensure x is perfectly divisible by y
                ValidOperators[0] = '/';

                if (x - y == z) // If subtraction could also work
                {
                    ValidOperators[1] = '-';
                }
                break;
        }

        // Update the TextMeshPro objects with the values
        xText.text = x.ToString();
        yText.text = y.ToString();
        zText.text = z.ToString();
    }

    void Start()
    {
        GenerateRandomEquation();
    }
}
