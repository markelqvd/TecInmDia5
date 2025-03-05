using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas : MonoBehaviour
{
    public Transform destino;
    public float suavizado = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MiCorrutina(destino));
        Debug.Log("El Script sigue");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MiCorrutina(Transform miDestino)
    {
        Debug.Log("Se inicia laa corutina");
        while (Vector3.Distance(transform.position, miDestino.position)>0.05f)
        {
            Debug.Log("Moviendo");
            transform.position = Vector3.Lerp(transform.position, miDestino.position, suavizado*Time.deltaTime);
            yield return null;
        }

        Debug.Log("Se acaba el while");
        yield return new WaitForSeconds(3f);
        Debug.Log("Se acaba la corutina");
    }
}
