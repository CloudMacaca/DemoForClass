﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Card : ScriptableObject
{

    [SerializeField]
    private Sprite cardImage;
    [SerializeField]
    public string cardName;

    [SerializeField]
    public int health;

    [SerializeField]
    public int attack;

    [SerializeField, Range(0, 5)]
    public int rare;
}
