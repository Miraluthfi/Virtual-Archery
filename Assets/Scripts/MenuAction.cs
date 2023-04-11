using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuAction : MonoBehaviour
{
    public GameObject panel, leave;
    public InputField txtInput;

    // Start is called before the first frame update
    void Start()
    {
        leave.SetActive(false);
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
        leave.SetActive(true);

        //GameObject AvatarName = GameObject.FindGameObjectWithTag("AvatarName");
        //AvatarName.GetComponent<Text>().text = txtInput.text;
    }
}
