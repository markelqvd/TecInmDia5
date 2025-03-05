using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practica : MonoBehaviour
{
    public Transform objetoAMover;
    public Vector3 posInicial = new Vector3(0, 0, 0);
    public Vector3 posFinal = new Vector3(10, 0, 0);
    public float suavizado = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MiCorrutina(posFinal));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MiCorrutina(Vector3 miPosFinal)
    {
        while (Vector3.Distance(transform.position, miPosFinal) > 0.05f)
        {
            objetoAMover.position = Vector3.Lerp(objetoAMover.position, miPosFinal, suavizado * Time.deltaTime);
            yield return null;
        }

        yield return new WaitForSeconds(3f);
    }
}
