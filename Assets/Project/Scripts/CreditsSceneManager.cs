using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsSceneManager : MonoBehaviour
{
    public void LoadCreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }
}

