using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassD 
{
    private ClassA ClassA;

    public ClassD(ClassA classA)
    {
        ClassA = classA;
        ClassA.Health = 20;
    }
}
