using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] arrayCartas;
    public GameObject player;
    int siguiente = 0;
    void Start()
    {
        initDeck();

        nextCard();
        nextCard();
        nextCard();
        nextCard();
        nextCard();
        nextCard();
        nextCard();
        nextCard();
        nextCard();
        nextCard();
    }

    void Update()
    {
        
    }

    void initDeck()
    {
        for (int pos = 0; pos < arrayCartas.Length; pos++)
        {
            int[] arrayNum = new int [13];
            string[] arraypalo = { "Corazones", "Tréboles", "Picas", "Rombos" };
            int puntuacion;
            int pos2 = Random.Range(0, 4);

            arrayNum[pos] = Random.Range(1, 13);

            if (arrayNum[pos] == 1 || arrayNum[pos] == 11 || arrayNum[pos] == 12|| arrayNum[pos] == 13)
            {
                puntuacion = 10;
            }
            else
            {
                puntuacion = arrayNum[pos];
            }

            Card carta = arrayCartas[pos].GetComponent<Card>();

            carta.Palo = arraypalo[pos2];
            carta.Numero = arrayNum[pos];
            carta.Puntuacion = puntuacion;
        }
    }

    void nextCard()
    {
        Card carta = arrayCartas[siguiente].GetComponent<Card>();
        Debug.Log("Se ha repartido la carta: ");
        carta.printInfo();

        player.GetComponent<Player>().dealCard(carta);
        int resultado = player.GetComponent<Player>().getPoints();
        Debug.Log("Puntuación player: " + resultado);

        siguiente++;
      
    }
}
