using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float speed =  2.0f;

    // Update is called once per frame
    void Update()
    {
        // Moves the object forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
