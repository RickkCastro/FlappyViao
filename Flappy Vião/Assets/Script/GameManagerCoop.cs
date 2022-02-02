using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCoop : GameManager
{
    [SerializeField]
    private int pontosParaReviver;
    private JogadorCoop[] jogadores;
    private bool alguemMorto;
    private int pontosDesdeAMorte;

    private InterfaceCanvasInativo interfaceCanvasInativo;


    protected override void Start()
    {
        base.Start();
        jogadores = GameObject.FindObjectsOfType<JogadorCoop>();
        interfaceCanvasInativo = GameObject.FindObjectOfType<InterfaceCanvasInativo>();
    }

    public void ReviverSePrecisar()
    {
        if(alguemMorto)
        {
            pontosDesdeAMorte++;
            interfaceCanvasInativo.AtualizarTexto(pontosParaReviver - pontosDesdeAMorte);
            if (pontosDesdeAMorte >= pontosParaReviver)
            {
                ReviverJogadores();
            }
        }
    }

    private void ReviverJogadores()
    {
        alguemMorto = false;
        interfaceCanvasInativo.Sumir();
        foreach(var Jogador in jogadores)
        {
            Jogador.Ativar();
        }
    }

    public void AvisarAlguemMorreu(Camera camera)
    {
        if (alguemMorto)
        {
            interfaceCanvasInativo.Sumir();
            FinalizarJogo();
        }
        else
        {
            alguemMorto = true;
            pontosDesdeAMorte = 0;
            interfaceCanvasInativo.AtualizarTexto(pontosParaReviver - pontosDesdeAMorte);
            interfaceCanvasInativo.Mostrar(camera);
        }
    }

    public override void ReniciarJogo()
    {
        base.ReniciarJogo();
        ReviverJogadores();
    }
}
