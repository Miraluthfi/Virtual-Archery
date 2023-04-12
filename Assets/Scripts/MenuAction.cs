using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class MenuAction : MonoBehaviour
{
    public GameObject panel, leave, cam;
    public GameObject avatar;
    public Transform[] spawn;
    public InputField txtInput;

    private GameObject player;

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
        cam.SetActive(false);

        int i = Random.Range(0, spawn.Length);
        player = Instantiate(avatar, spawn[i].position, Quaternion.identity);

        GameObject AvatarName = GameObject.Find("Label Name");
        AvatarName.GetComponent<TextMeshPro>().text = txtInput.text;
    }

    public void ShowPanel()
    {
        Destroy(player);

        panel.SetActive(true);
        leave.SetActive(false);
        cam.SetActive(true);
    }
}
