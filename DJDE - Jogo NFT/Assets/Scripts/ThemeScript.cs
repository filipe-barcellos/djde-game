using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThemeScript : MonoBehaviour   
{
    [SerializeField] private string Claro;
    [SerializeField] private string Escuro;
    public void temaClaro()
    {
        SceneManager.LoadScene(Claro);
    }
     public void temaEscuro()
    {
        SceneManager.LoadScene(Escuro);
    }
}
