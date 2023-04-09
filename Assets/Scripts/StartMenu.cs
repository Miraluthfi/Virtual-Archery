using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{  
    public void PindahScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Tombol Keluar telah di tekan");
    }
}
