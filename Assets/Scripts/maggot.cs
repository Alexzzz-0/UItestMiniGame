using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class maggot : MonoBehaviour
{
    public GameObject fish;

    //private Vector3 fish;
    
    public float fishScaleDis = .1f;
    private void Update()
    {
      
    }

    private void OnMouseDown()
    {
        
        transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-4, 4), 0);

        Vector3 fishScale;
        fishScale = fish.transform.localScale;
        fishScale.x += fishScaleDis;
        fishScale.y += fishScaleDis;
        fish.transform.localScale = fishScale;
    }
}
