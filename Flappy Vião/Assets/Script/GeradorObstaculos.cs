using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    //Script para gerar os obstaculos

    //Como Gerar Obstaculos?
    //Quando Gerar? //tempo
    //Onde Gerar? //Posicao do meu gerador
    //Como criar obstaculos?

    [SerializeField]
    private float tempoParaGerarMin, tempoParaGerarMax;
    private float cronometro;

    private ControleDeDificuldade controleDeDificuldade;

    [SerializeField]
    private GameObject obstaculoPrefab;

    private bool parado;

    void Start()
    {
        cronometro = tempoParaGerarMin;
        controleDeDificuldade = GameObject.FindObjectOfType<ControleDeDificuldade>();
    }

    // Update is called once per frame
    void Update()
    {
        if(parado)
        {
            return;
        }

        cronometro -= Time.deltaTime;

        if(cronometro < 0) //Se o cronometro for menor que 0
        {
            //Criar obstaculo na posicao do gerador
            GameObject.Instantiate(obstaculoPrefab, transform.position, Quaternion.identity);
            cronometro = Mathf.Lerp(tempoParaGerarMin, tempoParaGerarMax, 
                controleDeDificuldade.Dificuldade); //Reniciar tempo do cronometro de acordo com a dificuldade
        }
    }

    public void Parar()
    {
        parado = true;
    }
}
