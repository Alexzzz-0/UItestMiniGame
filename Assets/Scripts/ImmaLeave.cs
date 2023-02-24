using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmaLeave : MonoBehaviour
{
    public float moveDis = .1f;
    public float scaleNum = 2f;

    public GameObject fish;
    // Update is called once per frame
    
    private void OnMouseDown()
    {
        Vector3 pos = transform.position;
        pos.x += moveDis;
        transform.position = pos;

        Vector3 fishScale;
        fishScale = fish.transform.localScale;
        fishScale.x += moveDis * scaleNum;
        fishScale.y += moveDis * scaleNum;
        fish.transform.localScale = fishScale;
    }
}
