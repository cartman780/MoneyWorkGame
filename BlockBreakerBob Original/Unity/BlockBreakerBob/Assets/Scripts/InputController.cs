using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    // Update is called once per frame
    void Update()
    {
        // De positie van de muis op de x-as / breedte van het scherm * breedte van het scherm in units
        float mousePosInUnits = (Input.mousePosition.x / Screen.width) * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);

        // Geeft een min en max voor de x-waarde van de muis
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = paddlePos;
    }
}