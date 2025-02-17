using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Max Schmit 2/16/2025
public class GameEnder : MonoBehaviour
{
    // Methods
    private void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.StartScene();
    }

}
