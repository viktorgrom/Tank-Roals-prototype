using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassA : MonoBehaviour
{
    public int Health { get; set; }

    private void Awake()
    {
        ClassB b = new ClassB(this);
        Debug.Log(Health);
        ClassD d = new ClassD(this);
        Debug.Log(Health);
    }
}
