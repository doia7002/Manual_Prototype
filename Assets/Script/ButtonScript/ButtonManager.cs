using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{
    public GameObject Option;
    public GameObject buttonmanager;

    public void OnClickNewGame()
    {
        SceneManager.LoadScene("tutorial");
    }
    public void OnClickLoadGame()
    { 
        SceneManager.LoadScene("LoadMap");
    }
    public void OnClickOption()
    {
        Option.SetActive(true);
        buttonmanager.SetActive(false);        
    }
    public void OnClickEndGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
