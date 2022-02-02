using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorCoop : MonoBehaviour
{
    private Parallaxe[] cenario;
    private GeradorObstaculos geradorObstaculos;

    void Start()
    {
        cenario = GetComponentsInChildren<Parallaxe>();
        geradorObstaculos = GetComponentInChildren<GeradorObstaculos>();
    }

    public void Desativar()
    {
        geradorObstaculos.Parar();
        foreach(var parallaxe in cenario)
        {
            parallaxe.enabled = false;
        }
    }
}
