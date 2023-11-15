using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorPontos : MonoBehaviour
{
    private static GerenciadorPontos _instance;
    public static GerenciadorPontos Instance { get { return _instance; } }

    private int pontos = 0;

    void Awake() 
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void IncrementaPonto()
    {
        pontos++;
        Debug.Log("Pontuação: " + pontos);
        // You can add more logic here, like updating a UI element with the new score.
    }
}
