using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_Navigator : MonoBehaviour
{
    public Button B;
    public string Scene;

    // Update is called once per frame
    void Awake()
    {
        if(B.name.Equals("Exit Button"))
        {
            B.onClick.AddListener(delegate { Debug.Log("Quit"); Application.Quit(); });
        }
        else
        {
            B.onClick.AddListener(ButtonClick);
        }
    }

    void ButtonClick()
    {
        SceneManager.LoadScene(Scene);
    }
}
