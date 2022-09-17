using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class login : MonoBehaviour
{
    public GameObject inputUsuario;
    public GameObject inputPassword;
    public GameObject textMensaje;

    TMP_InputField usuario;
    TMP_InputField password;

    public void Start()
    {
        usuario = inputUsuario.GetComponent<TMP_InputField>();
        password = inputPassword.GetComponent<TMP_InputField>();
    }

    public void goToMenu()
    {
        if (usuario.text.Equals("yor") && password.text.Equals("12345"))
        {
            SceneManager.LoadScene("Splash");
        }
        else
        {
            textMensaje.GetComponent<TMP_Text>().text = "Datos incorrectos";
        }
    }
}
