using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(goToMenu()); //Forma de llamar a una CORUTINA
    }

    //ESTO ES UNA CORUTINA, se usa mucho para comunicacion entre servidores y en este caso para escenas
    IEnumerator goToMenu() //Es una interface de Unity que se hereda de MonoBehaviour
    {
        yield return new WaitForSeconds(3f); //ESPERA 3 SEGUNDOS
        SceneManager.LoadScene("Menu"); //PASA A LA SIGUIENTE ESCENA
    }
}
