using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public Transform pivot;
    public Transform target;
    public GameObject ball;

    public float gyroSpeed = 1;
    float xDir;
    float yDir;


    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(ball, target.position, target.rotation);
        }
        xDir = Input.GetAxis("Horizontal");
        yDir = Input.GetAxis("Vertical");

        if (xDir>0) // rota derecha
        {
            transform.Rotate(0, gyroSpeed, 0);
        }
        else if (xDir<0) // rota izquierda
        {
            transform.Rotate(0, -gyroSpeed, 0);
        }

        if (yDir>0)
        {
            pivot.Rotate(0, gyroSpeed / 2,0 );
        }
        else if (yDir<0)
        {
            pivot.Rotate(0, -gyroSpeed / 2, 0);

        }
    }

}
