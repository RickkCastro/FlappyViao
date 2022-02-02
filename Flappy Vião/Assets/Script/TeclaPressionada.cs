using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TeclaPressionada : MonoBehaviour
{
    [SerializeField]
    private KeyCode tecla;
    [SerializeField]
    private UnityEvent aoPressionarTecla;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(tecla))
        {
            aoPressionarTecla.Invoke();
        }
    }
}
