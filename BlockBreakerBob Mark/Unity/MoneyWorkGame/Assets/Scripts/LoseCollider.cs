using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    // Wordt uitgevoerd op triggermoment als de bal het aanraakt
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Gaat naar het volgende scherm
        SceneManager.LoadScene("GameOverScreen");
    }
}
