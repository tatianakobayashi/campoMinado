using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campo : MonoBehaviour
{
    public bool hasBomb;
    public int proximityCounter = 0;

    TabuleiroController tabuleiro = new TabuleiroController();

    // Start is called before the first frame update
    void Start()
    {
        tabuleiro = GameObject.FindGameObjectWithTag("Tabuleiro").GetComponent<TabuleiroController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Botão Esquerdo
            if(!hasBomb && proximityCounter == 0) tabuleiro.ScanAround(transform.localPosition.x, transform.localPosition.y);
            else if(proximityCounter > 0)
            {
                AbrirCampo();
            }
            if (hasBomb) Debug.Log("Fim de Jogo");
        }


        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            // Botão Direito
        }
    }

    private void AbrirCampo()
    {
        if (hasBomb) Debug.Log("Não deveria chegar aqui...");
    }

    public void AddToCounter()
    {
        if(!hasBomb) proximityCounter++;
    }

    public bool ContinueScan()
    {
        AbrirCampo();
        return proximityCounter == 0;
        // OBS: Se for fazer recursivo, chamar função scan around no lugar de retornar bool
    }
}
