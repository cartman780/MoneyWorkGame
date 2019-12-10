using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        NextLevel();    
    }

    void OnTransformChildrenChanged()
    {
        if (GetComponentInChildren<Block>() == null)
        {
            GetComponent<AudioSource>().Play();
        }
    }

    void NextLevel()
    {
        if (GetComponent<AudioSource>().isPlaying == false && GetComponentInChildren<Block>() == null)
        {
            {
                int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(currentSceneIndex + 1);
            }
        }
    }
}
