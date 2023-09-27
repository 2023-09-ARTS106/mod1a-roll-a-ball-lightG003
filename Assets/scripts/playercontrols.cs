using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class playercontrols : MonoBehaviour
{
    public float speed = 0;
    public TMP_Text countText;
    public GameObject winTextObject;


    private Rigidbody rb;
    private int count;
    private float movementx;
    private float movementy;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCounttext();
        winTextObject.SetActive(false);
    }

    void OnMove(InputValue movementvalue)
    {
        Vector2 movementvector = movementvalue.Get<Vector2>();

        movementx = movementvector.x;
        movementy = movementvector.y;

    }
    void SetCounttext()
    {
        countText.text = "Count" + count.ToString();
        if (count >= 15)
            winTextObject.SetActive(true);
    }


    void FixedUpdate()
    {
        Vector3 Movement = new Vector3(movementx, 0.0f, movementy);

        rb.AddForce(Movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;

            SetCounttext();
        }
    }
}
