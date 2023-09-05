using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unityengine.InputSystem;

public class playercontrols : MonoBehaviour
{

    private Rigidbody rb;
    private float movementx;
    private float movementy;

    // Start is called before the first frame update
    void Start()
    {
        rb = Getcomponent<Rigidbody>();
    }

    void Onmove(InputVaule movenentvaule)
    {
        vector2 movementvector = movementvaule.get<Vector2>();

        movementx = movementvector.x;
        movementy = movementvector.y;

    }

    void Fixedupdate
    {
        vector3 movement = new vector3(movementx, 0.0f, movementy);

        rb.Addforce(MovementVector);
    }
