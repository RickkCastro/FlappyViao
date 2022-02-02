using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCoop : GameManager
{
    private bool alguemMorto;
    private int pontosDesdeAMorte;

    public void ReviverSePrecisar()
    {
        if(alguemMorto){
            pontosDesdeAMorte++;
        }
    }

    public void alguemMorreu()
    {
        alguemMorto = true;
        pontosDesdeAMorte = 0; 
    }
}
