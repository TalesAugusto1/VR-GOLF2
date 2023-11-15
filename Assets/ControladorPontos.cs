using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPontos : MonoBehaviour
{
    public Transform bola; // Referência para a bola de golfe
    private Vector3 posicaoPadraoBola; // Posição padrão da bola
    public Transform[] posicaoBuraco; // Array de posições fixas para verificar
    public Transform[] proxBuracos; // Array de posições para os próximos buracos

    public float raioDePontuacao = 1f; // Ajuste o raio com base no tamanho do buraco

    void Start()
    {
        // Armazena a posição padrão da bola no início do jogo
        posicaoPadraoBola = bola.position;
    }

    void Update()
    {
        VerificaBuraco();
    }

    void VerificaBuraco()
    {
        for (int i = 0; i < posicaoBuraco.Length; i++)
        {
            float distancia = Vector3.Distance(bola.position, posicaoBuraco[i].position);

            if (distancia < raioDePontuacao)
            {
                Pontuacao();
                TpProxBuraco(i);
                break; // Saia do loop assim que uma posição de pontuação for encontrada
            }
        }
    }

    void Pontuacao()
    {
        // Adicione sua lógica de pontuação aqui
        // Por exemplo, incremente uma variável de pontuação
        GerenciadorPontos.Instance.IncrementaPonto();
    }

    void TpProxBuraco(int index)
    {
        // Move a bola para a próxima posição do buraco e redefine a posição padrão da bola
        bola.position = proxBuracos[index].position;
        posicaoPadraoBola = bola.position;

        // Você pode querer desabilitar o controle do jogador durante o teletransporte para evitar problemas
        ControladorJogador.Instance.TpPara(posicaoPadraoBola);
    }
}