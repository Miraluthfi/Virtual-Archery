using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject menupanel;
    public GameObject creditspanel;
    // Start is called before the first frame update
    void Start()
    {
        menupanel.SetActive(true);
        creditspanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void PindahScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void CreditsButton()
    {
        menupanel.SetActive(false);
        creditspanel.SetActive(true);
    }

    public void BackButton()
    {
        menupanel.SetActive(true);
        creditspanel.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Tombol Keluar telah di tekan");
    }
}
