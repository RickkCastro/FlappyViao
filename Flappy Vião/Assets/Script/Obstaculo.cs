using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    //Scrip para controlar os obstaculos na tela

    [SerializeField]
    private VariavelCompFloat Velocidade; //Velocidade dos obstaculos
    [SerializeField]
    private float VariacaoY; //Variacao no eixo y que os obstaculos podem ser criados

    private void Awake()
    {
        transform.Translate(Vector3.up * Random.Range(-VariacaoY, VariacaoY)); //Variar obstaculos
    }

    private void Update()
    {
        //Sempre mover obstaculos pra a esquerda conforme o tempo e a velocidade
        transform.Translate(Vector3.left * Velocidade.valor * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision) //Colisoes
    {
        if (collision.tag == "Barreira") //Se colidir com a barreira
            Destruir();
    }

    public void Destruir()
    {
        Destroy(gameObject);
    }
}
