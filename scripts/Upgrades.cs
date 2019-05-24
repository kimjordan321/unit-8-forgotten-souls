using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu (menuName = "Upgrades", fileName = "upgrade")]
public class Upgrades : ScriptableObject
{
    public Sprite pic;
    public GameObject Sprite;
    public string name;
    public float price;
    public int Count;
    public float BasePerSec;
    public float Efficiency;

}
