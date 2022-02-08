using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassB 
{
    private ClassA ClassA;

    public ClassB(ClassA classA)
    {
        ClassA = classA;
        ClassA.Health = 10;
    }
}
