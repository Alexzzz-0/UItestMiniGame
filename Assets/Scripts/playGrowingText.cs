using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class playGrowingText : MonoBehaviour
{
    public TextMeshProUGUI playText;

    private int[] TextFile = { 0, 1, 2, 3, 4 };
    private int textNum;

    private void Start()
    {
        textNum = TextFile[0];
    }


    private void OnMouseDown()
    {
        Debug.Log("textNum" + textNum.ToString());
        
        switch(textNum){
            case 0:
                playText.fontSize += 10f;
                playText.text = "Me";
                textNum += 1;
                break;
        
            case 1:
                playText.fontSize += 20f;
                playText.text = "To";
                textNum += 1;
                break;
        
            case 2:
                playText.fontSize += 30f; 
                playText.text = "Free"; 
                textNum += 1;
                break;
        
            case 3:
                playText.fontSize += 40f;
                playText.text = "The";
                textNum += 1;
                break;
        
            case 4:
                playText.fontSize += 40f;
                playText.text = "DEMON";
                break;
        }
    }
}
