using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    public int Pontos { get; private set; }
    [SerializeField]
    private TextMeshProUGUI textoPontuacao; //Texto que recebe o valor da pontuacao

    private AudioSource audioSource;

    [SerializeField]
    private UnityEvent aoPontuar;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        textoPontuacao.text = Pontos.ToString();
    }

    public void AdicionarPontos(int pontosAdd)
    {
        Pontos += pontosAdd; //Adicionar pontos
        textoPontuacao.text = Pontos.ToString();
        audioSource.Play(); //Tocar audio de pontuacao
        aoPontuar.Invoke();
    }

    public void Reiniciar() //Zerar pontos
    {
        Pontos = 0;
        textoPontuacao.text = Pontos.ToString();
    }

    public void SalvarPontuacao()
    {
        int recordeAtual = PlayerPrefs.GetInt("Recorde", Pontos);
        if (Pontos >= recordeAtual)
        {
            PlayerPrefs.SetInt("Recorde", Pontos);
            Debug.Log(PlayerPrefs.GetInt("Recorde"));
        }
    }
}
