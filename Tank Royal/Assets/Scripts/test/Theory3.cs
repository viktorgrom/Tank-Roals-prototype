using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Theory3 : MonoBehaviour
{
    Enemy enemy1 = new Enemy();
    
    void Start()
    {
        print(enemy1.GetLevel());
        Enemy.level++;
        print(Enemy.level);
        print(enemy1.GetLevel());

       // Main.Save();
    }

    
}

class Enemy
{
    public static int level = 1;

    public int GetLevel()
    {
        return level;
    }

    public static int GetMaxHealth()
    {
        return level * 100;
    }
}


//Struct

struct Test
{
    public int Number;
    public bool Boolean;

    private void DoSmth()
    {

    }
}

