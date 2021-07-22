using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    Player myPlayer = new Player();


    void Start()
    {
        PrintThis();
    }

    private void PrintThis()
    {
        myPlayer.Experience = 5;
        int x = myPlayer.Experience;

        Debug.Log(x);
    }
}
