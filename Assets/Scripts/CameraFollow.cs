using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Referencia al jugador
    public Vector3 offset = new Vector3(0, 5, -5); // Posición de la cámara respecto al jugador

    void LateUpdate()
    {
        // La cámara sigue al jugador pero sin rotar
        transform.position = player.position + offset;
    }
}
