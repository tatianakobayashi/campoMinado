using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabuleiroController: MonoBehaviour
{
    private GameObject[,] campos;

    [SerializeField] private int sizeX, sizeY;
    // Start is called before the first frame update
    void Start()
    {
        // Buscar todos os objetos com a tag "Campos" e colocar 
        campos = new GameObject[sizeX, sizeY];

        GameObject[] temp = GameObject.FindGameObjectsWithTag("Campos");
        //Debug.Log(temp.Length);

        for(int i = 0; i < temp.Length; i++)
        {
            //Debug.Log(temp[i].name);

            int x = ObterX(temp[i].transform.localPosition.x);
            int y = ObterY(temp[i].transform.localPosition.y);

            //Debug.Log($"X: {x} Y: {y}");

            campos[x, y] = temp[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateBombs(int quantity)
    {
        // Gera posições aleatórias para as bombas
        // Configura as posições das bombas
        // Configura os contadores dos vizinhos
    }

    public void ScanAround(float x, float y)
    {
        // TODO - faz varredura dos campos ao redor da posição do clique
    }

    int ObterX(float x)
    {
        int newX = (int) (x + 3.5f);

        return newX;
    }

    int ObterY(float y)
    {
        int newY = -1 * (int)Mathf.Round(y - 2.25f);

        return newY;
    }

    GameObject ObterCampoPelaPosicao(float x, float y)
    {
        int newX = ObterX(x);
        int newY = ObterY(y);

        return campos[newX, newY];
    }
}
