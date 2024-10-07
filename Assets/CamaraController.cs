using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public Transform player;
    public float suavizado = 0.3f; 
    private Vector3 velocidad = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        Vector3 newPosition = new Vector3(player.position.x, position.y, position.z);
        transform.position = Vector3.SmoothDamp(position, newPosition, ref velocidad, suavizado);
    }

}
