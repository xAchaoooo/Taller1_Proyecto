using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{

    public int points;
    public string TextoObjeto = "Puntos: ";
    public string Texto;

    private TextMeshProUGUI textMesh;


    private void Awake() {
        textMesh = GetComponent<TextMeshProUGUI>(); 
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = TextoObjeto + points.ToString();

    }

    public void SumarPuntos(int puntosRecogidos)
    {
        points += puntosRecogidos; 
    }

}
