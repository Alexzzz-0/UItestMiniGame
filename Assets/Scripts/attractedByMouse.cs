using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attractedByMouse : MonoBehaviour
{
    public float velocity = 2f;

    private Vector3 direction;

    private Rigidbody2D rb;
    private Vector3 initialPos;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        initialPos = transform.position;
    }

    void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.z = 0;

        direction = mousePos - transform.position;
        
        rb.AddForce(direction);
    }

    private void OnMouseDown()
    {
        rb.MovePosition(initialPos);
    }
}
