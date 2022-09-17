using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void goToNivel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void goToNivel2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void goToNivel3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void quitGame()
    {
        
    }
}
