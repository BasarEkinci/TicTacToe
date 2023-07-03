using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneUIManager : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }
}
