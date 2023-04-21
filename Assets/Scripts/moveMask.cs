using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMask : MonoBehaviour
{

    public GameObject bone;

    private Vector3 initialPos;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        Debug.Log(("onMouseOver"));
        bone.transform.position += Vector3.back ;
    }

    private void OnMouseExit()
    {
        bone.transform.position = initialPos;
    }
}
