using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Card : ScriptableObject
{

    [SerializeField]
    public Sprite cardImage;
    [SerializeField]
    public string cardName;

    [SerializeField]
    public int health;

    [SerializeField]
    public int attack;

    [SerializeField, Range(1, 5)]
    public int rare;
}
