using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerDeath : MonoBehaviour
{
    public GameObject gameOverCanvas;  

    public string TextoObjeto = "Puntos: ";
    private Animator AnimatorPlayer;
    private TextMeshProUGUI textMesh;
    private Puntos puntosScript; // Referencia al script Puntos
    

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas.SetActive(false); 
        puntosScript = FindObjectOfType<Puntos>(); // Busca el objeto Puntos en la escena
    }

    
    
    
    public void GameOver()
    {
        Time.timeScale = 0; // Detener el juego
        gameOverCanvas.SetActive(true); // Mostrar la pantalla de Game Over
        
        // Actualizar el texto con la puntuación actual
        textMesh = gameOverCanvas.GetComponentInChildren<TextMeshProUGUI>(); // Asegúrate de que esté en el canvas de Game Over
        textMesh.text = TextoObjeto + puntosScript.points.ToString(); // Obtener puntos del script Puntos
    }

    public void Reintentar()
    {
        Time.timeScale = 1; // Reiniciar el tiempo del juego
        AnimatorPlayer.SetBool("IsDead", false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reiniciar la escena actual
    }
}
