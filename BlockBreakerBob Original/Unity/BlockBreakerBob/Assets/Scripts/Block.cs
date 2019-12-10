using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] int hitsToDestroy = 1;
    [SerializeField] int timesHit = 0;

    // Als het blok geraakt is, voert hij deze functie uit
    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;

        if (hitsToDestroy == timesHit)
        {
            // Verwijderd het blok
            Destroy(gameObject);
        }
    }
}
