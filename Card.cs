using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string Palo;
    public int Numero;
    public int Puntuacion;

    public void printInfo()
    {
        Debug.Log(Numero + " de " + Palo + ". Puntiación: " + Puntuacion);
    }

}