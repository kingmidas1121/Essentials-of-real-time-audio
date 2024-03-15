using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{

}
public class Player1
{
    private int experience;
    public int Experience
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }
    }
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }
    public int Health { get; set; }
}
public class Game : MonoBehaviour
{
    void Start()
    {
        Player1 myPlayer = new Player1();
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}

