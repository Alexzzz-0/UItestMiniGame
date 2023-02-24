using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{

    private void Update()
    {
        
        transform.rotation = Quaternion.Euler(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
