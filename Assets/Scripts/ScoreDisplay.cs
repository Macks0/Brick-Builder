using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Max Schmit 2/15/2025
public class ScoreDisplay : MonoBehaviour
{
    // Vars
    [SerializeField] protected TMP_Text scoreText;
    [SerializeField] protected string preText = "Score: ";
    [SerializeField] protected string postText = "pts";

    //Methods
    void Start()
    {
        ChangeScore();
    }

    public void ChangeScore()
    {
        scoreText.text = preText + GameManager.Instance.PlayerScore + postText;
    }
}
