using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InterfaceCanvasInativo : MonoBehaviour
{
    [SerializeField]
    private GameObject PanelFundo;
    [SerializeField]
    private TextMeshProUGUI texto;
    private Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    public void Mostrar(Camera camera)
    {
        canvas.worldCamera = camera;
        PanelFundo.SetActive(true);
    }

    public void AtualizarTexto(int pontosParaReviver)
    {
        texto.text = pontosParaReviver.ToString();
    }

    public void Sumir()
    {
        PanelFundo.SetActive(false);
    }
}
