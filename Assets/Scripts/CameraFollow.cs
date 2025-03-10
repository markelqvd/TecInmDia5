using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public Vector3 offset = new Vector3(0, 5, -5); // Posici�n de la c�mara respecto al jugador

    void LateUpdate()
    {
        // La c�mara sigue al jugador pero sin rotar
        transform.position = player.position + offset;
    }
}
