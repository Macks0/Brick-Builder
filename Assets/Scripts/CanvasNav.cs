using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Max Schmit 2/13/2024
public class CanvasNav : MonoBehaviour
{
      

    // Methods
    public void LoadNextScene()
    {
        GameManager.Instance.NextScene();
    }

    public void LoadStartScreen()
    {
        GameManager.Instance.StartScene();
    }

     

}
