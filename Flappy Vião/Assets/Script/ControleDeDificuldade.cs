using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDeDificuldade : MonoBehaviour
{
    [SerializeField]
    private float tempoDificuldadeMax;
    private float tempoPassado;
    public float Dificuldade { get; private set; }

    void Update()
    {
        tempoPassado += Time.deltaTime;
        Dificuldade = tempoPassado / tempoDificuldadeMax;
        Dificuldade = Mathf.Min(1, Dificuldade);
    }

    public void ReniciarDifuculdade()
    {
        tempoPassado = 0;
        Dificuldade = 0;
    }
}
