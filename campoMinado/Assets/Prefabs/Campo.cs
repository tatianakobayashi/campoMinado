using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campo : MonoBehaviour
{
    private bool hasBomb;
    private int proximityCounter = 0;

    TabuleiroController tabuleiro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToCounter()
    {
        proximityCounter++;
    }
}
