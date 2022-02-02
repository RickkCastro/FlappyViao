using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaoPiscando : MonoBehaviour
{
    private SpriteRenderer imagem;

    void Start()
    {
        imagem = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //Se o botao esquerdo do mouse for precionado
        {
            Desaparecer();
        }
    }

    private void Desaparecer() //Desabilitar imagem do objeto
    {
        imagem.enabled = false;
    }
}
