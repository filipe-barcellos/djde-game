using UnityEngine;
using UnityEngine.SceneManagement;

public class botao : MonoBehaviour
{
    public string sceneName;

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
     public void CloseGame()
    {
        Debug.Log("saiu");
        Application.Quit();
    }

}
