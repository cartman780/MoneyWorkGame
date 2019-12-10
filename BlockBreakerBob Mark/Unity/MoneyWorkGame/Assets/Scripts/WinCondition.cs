using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    // Begint gelijk bij het starten van spel
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
    }

    // Checkt bij elk frame
    void Update()
    {
        NextLevel();    
    }


    void OnTransformChildrenChanged()
    {   
        // Speelt geluid af bij het winnen
        if (GetComponentInChildren<Block>() == null)
        {
            GetComponent<AudioSource>().Play();
        }
    }

    // Level gewonnen
    void NextLevel()
    {   
        // Als de achtergrond muziek speelt en er zijn geen blokken meer
        if (GetComponent<AudioSource>().isPlaying == false && GetComponentInChildren<Block>() == null)
        {
            {
                // Ga naar volgend scherm
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex + 1);
            }
        }
    }
}
