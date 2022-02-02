using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ControlaAviao : MonoBehaviour
{
    //Script para controlar o aviao(Jogador)

    private Rigidbody2D rig;
    [SerializeField]
    private float Forca; //Forca do impulso do aviao

    [SerializeField]
    private UnityEvent aoBater;
    [SerializeField]
    private UnityEvent aoPassarPeloObstaculo;


    private Vector3 posicaoInicial;
    private bool deveImpulsionar;

    private Animator animator;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>(); //Pegar rig do aviao

        posicaoInicial = transform.position; //Pegar posicao inicial do aviao
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetFloat("VelocidadeY", rig.velocity.y);
    }

    private void FixedUpdate()
    {
        if (deveImpulsionar)
        {
            Impulsionar(); //Impulsionar aviao
            deveImpulsionar = false;
        }
    }

    public void DarImpulso()
    {
        deveImpulsionar = true;
    }

    private void Impulsionar()
    {
        rig.velocity = Vector2.zero;
        rig.AddForce(Vector2.up * Forca, ForceMode2D.Impulse); //Adiciona forca ao rig do aviao para cima
    }

    private void OnCollisionEnter2D(Collision2D collision) //Qunado colidir com algum objeto
    {
        rig.simulated = false; //parar a fisica
        aoBater.Invoke();
    }

    public void Reniciar() //Reniciar o aviao
    {
        rig.simulated = true; //Ligar fisica
        transform.position = posicaoInicial; //Colocar na posicao inicial
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        aoPassarPeloObstaculo.Invoke();
    }
}
