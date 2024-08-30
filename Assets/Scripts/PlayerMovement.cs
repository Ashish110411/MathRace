using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float multiplier;
    void Update()
    {
        speed += Time.deltaTime * multiplier;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
