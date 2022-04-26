using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new card" , menuName = "card")]
public class Card : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artwork;

    public int manaCost;
    public int attack;
    public int health;

    public void Print()
    {
        Debug.Log(name + ":" + description + "The card cost" + manaCost);
    }
}
