using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAR : MonoBehaviour
{
    

   
    public void PindahScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
   
}
