using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAR : MonoBehaviour
{
    public GameObject PanelBody;
    public GameObject Credits;

    private void Start()
    {
        PanelBody.SetActive(true);
        Credits.SetActive(false);
    }
    public void PindahScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Tombol Keluar telah di tekan");
    }

    public void BtnCredits()
    {
        PanelBody.SetActive(false);
        Credits.SetActive(true);
    }

    public void BtnBack()
    {
        PanelBody.SetActive(true);
        Credits.SetActive(false);
    }
}
