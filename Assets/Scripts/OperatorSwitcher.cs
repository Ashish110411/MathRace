using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorManager : MonoBehaviour
{
    public GameObject[] operators;
    private int currentOperatorIndex = 0;
    private GameObject activeOperator;
    
    void Start()
    {
        activeOperator = Instantiate(operators[currentOperatorIndex], transform.position, Quaternion.identity, transform);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeOperator();
        }
    }

    void ChangeOperator()
    {
        Destroy(activeOperator);
        currentOperatorIndex = (currentOperatorIndex + 1) % operators.Length;
        activeOperator = Instantiate(operators[currentOperatorIndex], transform.position, Quaternion.identity, transform);
    }


}
