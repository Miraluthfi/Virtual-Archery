using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject PanelInfo;
    public AudioSource PlaySound;

    public bool show = false;

    public void ShowHideInfo()
    {
        if(!show)
        {
            PanelInfo.SetActive(true);
            show = true;
        }
        else
        {
            
            PanelInfo.SetActive(false);
            show = false;
        }
    }

    public void PlaySoundInfo()
    {
        PlaySound.Play();
    }

}
