using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionTeclado : MonoBehaviour
{

    public float vel = 10f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, 0f, vel * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 0f, -vel  * Time.deltaTime);
        }
    }
}
