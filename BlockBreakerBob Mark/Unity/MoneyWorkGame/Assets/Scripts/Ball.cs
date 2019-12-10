using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Velden in Unity
    [SerializeField] InputController paddle1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 5f;

    Vector2 paddleToBallVector;
    bool hasStarted = false;

    // Start gelijk op de eerste frame
    void Start()
    {
        // Geeft afstand tussen bal en paddle en bal staat stil
        paddleToBallVector = transform.position - paddle1.transform.position;
        GetComponent<AudioSource>().playOnAwake = false;
    }

    // Bij elke frame checkt hij of het spel gestart is
    void Update()
    {
        // Na klik is het spel gestart en is de bal niet meer locked aan de paddle
        if (hasStarted != true)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    // Zet de bal vast op deze positie
    void LockBallToPaddle()
    {
        // Geeft de positie van de paddle voor de bal
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);

        // Voegt de afstand tussen de bal en de paddle toe aan de positie van de bal
        transform.position = paddlePos + paddleToBallVector;
    }

    // Als je op de muis klikt start hij de beweging van de bal
    void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Voegt een kracht aan de bal toe met een x- en y-waarde
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
            hasStarted = true;
        }
    }

    // Geluid bij het kaatsen van de bal
    private void OnCollisionEnter2D()
    {
        GetComponent<AudioSource>().Play();
    }
}
