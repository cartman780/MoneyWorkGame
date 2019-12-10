using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] InputController paddle1;
    [SerializeField] float xPush = 2f;
    [SerializeField] float yPush = 5f;

    Vector2 paddleToBallVector;
    bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        // Geeft afstand tussen bal en paddle
        paddleToBallVector = transform.position - paddle1.transform.position;
        GetComponent<AudioSource>().playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Na klik is de bal niet neer aan de paddle gelockt  en kan de bal niet meer afgevuurd worden
        if (hasStarted != true)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    void LockBallToPaddle()
    {
        // Geeft de positie van de paddle voor de bal
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);

        //Voegt de afstand tussen de bal en de paddle toe aan de positie van de bal
        transform.position = paddlePos + paddleToBallVector;
    }

    void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Voegt een kracht aan de bal toe met een x- en y-waarde
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
            hasStarted = true;
        }
    }

    private void OnCollisionEnter2D()
    {
        GetComponent<AudioSource>().Play();
    }
}
