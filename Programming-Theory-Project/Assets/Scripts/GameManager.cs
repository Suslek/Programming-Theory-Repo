using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameManager : MonoBehaviour
{
    void Awake()
    {
        
    }

    public void OnCatPress()
    {
        LoadMainScene();
    }

    public void OnDogPress()
    {
        LoadMainScene();
    }

    public void OnDeerPress()
    {
        LoadMainScene();
    }

    void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExitPress()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
