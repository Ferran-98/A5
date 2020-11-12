using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    List<Card> Mano = new List<Card>();
    int punt = 0;

    public void dealCard(Card cartanueva)
    {
        Mano.Add(cartanueva);
        setPoints(cartanueva.Puntuacion);
    }

    void setPoints(int p)
    {
        punt = punt + p;
    }

   public int getPoints()
    {
        return punt;
    }
}
