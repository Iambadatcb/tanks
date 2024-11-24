using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public string sceneName;

    public void ButtonClick()
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Scene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
