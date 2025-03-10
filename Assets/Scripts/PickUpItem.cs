using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    private GameController gameController;
    public float rotationSpeed = 50f;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        transform.rotation = Quaternion.Euler(45, Random.Range(0, 360), 0);
    }

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameController.AddCount();
            gameObject.SetActive(false);
        }
    }
}
