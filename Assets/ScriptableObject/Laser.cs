using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Laser Data", menuName = "Weapon Data")]
public class LaserData : ScriptableObject
{
    
    [Header("INFO")]
    [SerializeField] private string weaponName;
    [SerializeField] private string weaponType;

    [Header("Stat")]
    [SerializeField] private float reloadSpeed;
    [SerializeField] private int Attack;
    [SerializeField] private int numberOfBullet;
    [SerializeField] private bool Pierce;

    [Header("Cost")]
    [SerializeField] private int price;
    [SerializeField] private int power;
    [SerializeField] private bool useMissile;
}
