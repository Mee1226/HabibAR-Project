using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadscene(string namascene)
    {
        SceneManager.LoadScene(namascene);
    }

    public void quitapp()
    {
        Application.Quit();
    }

    public void openurlmaps()
    {
        Application.OpenURL("https://goo.gl/maps/DAa5UDpj3Bf18KEBA");
    }
}
