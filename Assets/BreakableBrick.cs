

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Max Schmit 2/14/2025
public class BreakableBrick : MonoBehaviour
{
    // Vars
    [SerializeField, Range(1, 20)] protected int hitsToBreak;
    [SerializeField, Range(1, 20)] protected int pointValue;
    protected int curHitsToBreak = 0;

    // break emiter
    [SerializeField] GameObject ps_Prefab;


    // Methods
    private void Awake()
    {
        curHitsToBreak = hitsToBreak;
    }
    // Accessors

    public void Break(int aDamage)
    {
        curHitsToBreak -= aDamage;
        Instantiate(ps_Prefab);
        BreakBrick();
        
    }

    protected void BreakBrick()
    {
        if (curHitsToBreak <= 0)
        {
            // Add flare before Destroy 
            // FindObjectOfType<RoundManager>().RemoveBrick(this);
            GameManager.Instance.AddScore(pointValue);
            Instantiate(ps_Prefab).GetComponent<ParticleSystem>().Play();
            Destroy(gameObject);
            // Too late for Flare
        }
        
    }

}
