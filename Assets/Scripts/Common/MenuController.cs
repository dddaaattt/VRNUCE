using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void OpenMainSence()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void OpenStartSence()
    {
        SceneManager.LoadScene("Begin");
    }
    public void Exit()
    {
        Debug.Log("Quit Application!");
        Application.Quit();
    }
}
