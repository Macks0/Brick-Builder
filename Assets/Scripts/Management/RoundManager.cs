using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Max Schmit 2/14/2025
public class RoundManager : MonoBehaviour
{
    // [SerializeField] protected List<BreakableBrick> bricks;
    [SerializeField] protected GameObject canvasScene;


    // Methods
    private void Update()
    {
        EndRound();
    }


    public void Awake()
    {
        RoundManager[] gOs = FindObjectsOfType<RoundManager>();

        if (gOs.Length > 1)
        {
            Destroy(gameObject);
        }
    }

    protected void EndRound()
    {
        // Debug.Log(FindObjectsOfType<BreakableBrick>().Length);
        if (FindObjectsOfType<BreakableBrick>().Length < 1)
        {
            canvasScene.SetActive(true);
        }
    }

}
