using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Script para controlar estado do jogo

    private ControlaAviao aviao;
    private Pontuacao pontuacao;
    private InterfaceGameOver interfaceGameOver;
    private ControleDeDificuldade controleDeDificuldade;

    protected virtual void Start()
    {
        aviao = GameObject.FindObjectOfType<ControlaAviao>(); //Pegar objeto avio(Jogador)
        pontuacao = GameObject.FindObjectOfType<Pontuacao>(); //Pegar script de pontuacao
        interfaceGameOver = GameObject.FindObjectOfType<InterfaceGameOver>(); //Pegar Script de controla interface
        controleDeDificuldade = GameObject.FindObjectOfType<ControleDeDificuldade>();
    }

    public void FinalizarJogo()
    {
        Time.timeScale = 0; //Pausar tempo
        pontuacao.SalvarPontuacao(); //Salvar e checar recorde
        interfaceGameOver.MostrarInterface(true);
        controleDeDificuldade.ReniciarDifuculdade();
    }

    public virtual void ReniciarJogo()
    {
        interfaceGameOver.MostrarInterface(false);
        aviao.Reniciar();
        DestruirObstaculos();
        Time.timeScale = 1;
        pontuacao.Reiniciar(); //Zerar a pontuacao
    }

    private void DestruirObstaculos()
    {
        //Pega todos os obstaculos na cena e destroie
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();
        foreach(Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
