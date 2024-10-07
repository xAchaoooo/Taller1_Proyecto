using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public int valor = 5; // Las frutas suman 5 puntos
    public Puntos puntaje; 

    void Start()
    {
        puntaje = FindObjectOfType<Puntos>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            puntaje.SumarPuntos(valor); 
            Destroy(gameObject); 
        }
    }
}
