using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Master_Scene_Navigator : MonoBehaviour
{
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;

    public string Scene1;
    public string Scene2;
    public string Scene3;

    // Update is called once per frame
    void Update()
    {
        Button1.onClick.AddListener(delegate { ChangeScene(Scene1); });
        Button2.onClick.AddListener(delegate { ChangeScene(Scene2); });
        Button3.onClick.AddListener(delegate { ChangeScene(Scene3); });
        Button4.onClick.AddListener(ExitNav);
    }

    private void ExitNav()
    {
        Application.Quit();
    }    

    private void ChangeScene(string x)
    {
        SceneManager.LoadScene(x);
    }
}