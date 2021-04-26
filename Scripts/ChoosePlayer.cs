using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePlayer : MonoBehaviour
{
    [Header("Players")]
    public PlayerMovement Player1;
    public PlayerMovement Player2;

    public bool isPlayer1; // Player1 = !Player2

    void Start()
    {
        isPlayer1 = true;
    }

    void Update()
    {
        Player1.enabled = isPlayer1;
        Player2.enabled = !isPlayer1;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            isPlayer1 = !isPlayer1;
        }
    }

    public bool isPlayer1Active()
    {
        return isPlayer1;
    }
}
