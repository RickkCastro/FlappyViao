using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDoComputador : MonoBehaviour
{
    [SerializeField]
    private float intervalo;
    private ControlaAviao aviao;

    // Start is called before the first frame update
    void Start()
    {
        aviao = GetComponent<ControlaAviao>();
        StartCoroutine(Impulsionar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Impulsionar()
    {
        while (true)
        {
            yield return new WaitForSeconds(intervalo);
            aviao.DarImpulso();
        }
    }
}
