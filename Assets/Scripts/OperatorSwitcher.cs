using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorManager : MonoBehaviour
{
    public GameObject[] operators;  // Array to hold the operator prefabs
    private int currentOperatorIndex = 0; // Index to track the current operator
    private GameObject activeOperator;    // Currently active operator object
    
    void Start()
    {
        activeOperator = Instantiate(operators[currentOperatorIndex], transform.position, Quaternion.identity, transform);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detects a left mouse click or screen tap
        {
            ChangeOperator();
        }
    }

    void ChangeOperator()
    {
        Destroy(activeOperator); // Remove the current operator

        currentOperatorIndex = (currentOperatorIndex + 1) % operators.Length; // Move to the next operator

        // Instantiate the next operator
        activeOperator = Instantiate(operators[currentOperatorIndex], transform.position, Quaternion.identity, transform);
    }


}
