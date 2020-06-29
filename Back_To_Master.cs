using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Back_To_Master : MonoBehaviour
{
    public Button Back;
    public string Master;
    public Animator tr;

    // Update is called once per frame
    void Update()
    {
        Back.onClick.AddListener(ButtonClick);
    }

    void ButtonClick()
    {
        SceneManager.LoadScene(Master);
    }
}
