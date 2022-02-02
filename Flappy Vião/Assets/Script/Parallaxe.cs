using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxe : MonoBehaviour
{
    //Script para criar o efeito de parallaxe

    [SerializeField]
    private VariavelCompFloat velocidade;

    [SerializeField]
    private float camadaParallaxe; //Numero que ira dividir a velocidade

    private Vector3 posicaoInicial;
    private float tamanhoRealDaImagem;

    private void Awake()
    {
        posicaoInicial = transform.position; //Pegar posicao inicial

        float tamanhoDaImagem = GetComponent<SpriteRenderer>().size.x; //Pegar tamanho do sprite
        float escala = transform.localScale.x; //Pegar escala do objeto

        tamanhoRealDaImagem = tamanhoDaImagem * escala;
    }

    void Update()
    {
        //objeto é deslocado ate deslocar o tamanho real dele, assim repetindo o deslocamento
        float deslocamento = Mathf.Repeat((velocidade.valor / camadaParallaxe) * Time.time, tamanhoRealDaImagem / 2);
        transform.position = posicaoInicial + Vector3.left * deslocamento;
    }
}
