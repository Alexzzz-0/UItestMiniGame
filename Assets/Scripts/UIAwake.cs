using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIAwake : MonoBehaviour
{
    public TextMeshProUGUI ESC;
    // Start is called before the first frame update
    void Start()
    {
        ESC.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        Debug.Log("click ESC");
        ESC.fontSize = 90f;
        ESC.color = Color.red;
    }

    private void OnMouseExit()
    {
        ESC.fontSize = 10f;
        ESC.color = Color.yellow;
    }
}
