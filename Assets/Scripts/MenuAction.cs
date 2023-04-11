using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuAction : MonoBehaviour
{
    public GameObject panel;
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
    public GameObject leave;
=======
>>>>>>> 83633fe3bb461ce70c4419f3806541bc5a3bfc8b
>>>>>>> Stashed changes
    public InputField txtInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

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

    public void JoinRoom()
    {
        panel.SetActive(false);
    }
}
