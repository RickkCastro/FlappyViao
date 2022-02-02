using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorCoop : MonoBehaviour
{
    private Parallaxe[] cenario;
    private GeradorObstaculos geradorObstaculos;
    private ControlaAviao controlaAviao;
    private bool EstouMorto;

    void Start()
    {
        cenario = GetComponentsInChildren<Parallaxe>();
        geradorObstaculos = GetComponentInChildren<GeradorObstaculos>();
        controlaAviao = GetComponentInChildren<ControlaAviao>();
    }

    public void Desativar()
    {
        geradorObstaculos.Parar();
        foreach(var parallaxe in cenario)
        {
            parallaxe.enabled = false;
        }

        EstouMorto = true;
    }

    public void Ativar()
    {
        if (EstouMorto)
        {
            geradorObstaculos.Ativar();
            foreach (var parallaxe in cenario)
            {
                parallaxe.enabled = true;
            }

            controlaAviao.Reniciar();
            EstouMorto = false;
        }
    }
}
