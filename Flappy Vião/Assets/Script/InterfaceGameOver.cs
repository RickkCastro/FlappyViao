using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI valorRecorde;

    [SerializeField]
    private GameObject imgGameOver;

    private Pontuacao pontuacao;
    private int recorde;

    [SerializeField]
    private Image Medalha;
    [SerializeField]
    private Sprite MedalhaOuro;
    [SerializeField]
    private Sprite MedalhaPrata;
    [SerializeField]
    private Sprite MedalhaBronze;

    private void Start()
    {
        pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    private void AtualizarInterfaceRecorde()
    {
        recorde = PlayerPrefs.GetInt("Recorde");
        valorRecorde.text = recorde.ToString();
    }

    public void MostrarInterface(bool status)
    {
        AtualizarInterfaceRecorde();
        verificarMedalha();
        imgGameOver.SetActive(status);
    }

    private void verificarMedalha()
    {
        if(pontuacao.Pontos >= recorde) //Ouro
        {
            Medalha.sprite = MedalhaOuro;
        }
        else if(pontuacao.Pontos >= recorde / 2) //Prata
        {
            Medalha.sprite = MedalhaPrata;
        }
        else //Bronze
        {
            Medalha.sprite = MedalhaBronze;
        }
    }
}
