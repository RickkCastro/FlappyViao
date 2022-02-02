using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AtivarJogador : MonoBehaviour
{
   [SerializeField]
   private UnityEvent aoTerminarAnimacao;

   public void ativarJogador()
   {
        aoTerminarAnimacao.Invoke();
   }
}
