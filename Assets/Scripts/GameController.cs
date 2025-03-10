using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text countText;
    public Text winText; // Nueva variable para el texto de victoria
    private int count = 0;
    private int totalCubes = 12; // Número total de cubos a recolectar

    void Start()
    {
        UpdateCountText();
        winText.gameObject.SetActive(false); // Oculta el texto de victoria al inicio
    }

    public void AddCount()
    {
        count++;
        UpdateCountText();

        // Si hemos recogido todos los cubos, mostramos "You Win"
        if (count >= totalCubes)
        {
            winText.gameObject.SetActive(true);
        }
    }

    void UpdateCountText()
    {
        countText.text = "Count: " + count.ToString();
    }
}
