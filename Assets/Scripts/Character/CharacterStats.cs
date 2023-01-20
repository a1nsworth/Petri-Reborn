using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Класс со статами персонажа
/// </summary>
public class CharacterStats : MonoBehaviour
{
    [SerializeField] private int Health { get; set; }

    [SerializeField] private int Coins { get; set; }

    [SerializeField] private int Trees { get; set; }

    [SerializeField] private int Ores { get; set; }
}