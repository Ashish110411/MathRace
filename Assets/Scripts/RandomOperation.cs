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
        ValidOperators = new char[2];
        
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
                y = Random.Range(1, x + 1);
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
                x = y * z;
                ValidOperators[0] = '/';

                if (x - y == z)
                {
                    ValidOperators[1] = '-';
                }
                else if (x * y == z)
                {
                    ValidOperators[1] = '*';
                }
                break;
        }
        xText.text = x.ToString();
        yText.text = y.ToString();
        zText.text = z.ToString();
    }
    void Start()
    {
        GenerateRandomEquation();
    }
}
