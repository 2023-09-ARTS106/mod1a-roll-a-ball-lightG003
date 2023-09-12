using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playercontrols : MonoBehaviour
{
    public float speed = 0;

    private Rigidbody rb;
    private float movementx;
    private float movementy;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMove(InputValue movementvalue)
    {
        Vector2 movementvector = movementvalue.Get<Vector2>();

        movementx = movementvector.x;
        movementy = movementvector.y;

    }

    void FixedUpdate()
    {
        Vector3 Movement = new Vector3(movementx, 0.0f, movementy);

        rb.AddForce(Movement * speed );
    }
}
