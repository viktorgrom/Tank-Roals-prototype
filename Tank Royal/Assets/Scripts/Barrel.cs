using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Barrel", menuName ="Item/Barrel")]
public class Barrel : ScriptableObject
{
    public string title;
    public string description;
    public Sprite sprite;
    public int radius;
}
