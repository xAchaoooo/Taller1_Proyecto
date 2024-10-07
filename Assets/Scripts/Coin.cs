using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int valor = 1; // Las monedas suman 1 punto
    public Puntos puntaje; 

    void Start()
    {
        // Cambia "Puntaje" por "Puntos"
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