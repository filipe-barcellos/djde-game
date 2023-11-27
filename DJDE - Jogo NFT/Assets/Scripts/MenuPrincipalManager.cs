using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject painelAjuda;

    public void abrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }
    public void fecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);


    }
    public void abrirAjuda()
    {
        painelMenuInicial.SetActive(false);
        painelAjuda.SetActive(true);
    }
    public void fecharAjuda()
    {
        painelAjuda.SetActive(false);
        painelMenuInicial.SetActive(true);


    }
 
}
