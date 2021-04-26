using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    [Header("Switch States")]
    [SerializeField] private Sprite spriteOff;
    [SerializeField] private Sprite spriteOn;
    [SerializeField] private bool isOn;
    [SerializeField] private bool nearPlayer1;
    [SerializeField] private bool nearPlayer2;

    [Header("Controlled Object")]
    [SerializeField] List<GameObject> controlledObject = new List<GameObject>();
    [SerializeField] ChoosePlayer cP;

    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        //isOn = false;
        nearPlayer1 = false;
        nearPlayer2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            StateChange();
        }
    }

    private void StateChange() // Check if a the player near the switch is the active one and "turns" the switch on
    {
        if (nearPlayer1)
        {
            mySpriteRenderer.sprite = isOn ? spriteOff : spriteOn;
            isOn = !isOn;
        }

        if (nearPlayer2)
        {
            mySpriteRenderer.sprite = isOn ? spriteOff : spriteOn;
            isOn = !isOn;
        }

        foreach (GameObject controlledObject in controlledObject) // flips the state for all objects in list
        {
            controlledObject.SetActive(!isOn);
        }
    }

    private void OnTriggerStay2D(Collider2D collision) // Checks if and which player is near the switch
    {
        if (collision.transform.name == "Player1" && cP.isPlayer1Active())
        {
            nearPlayer1 = true;
        }
        else
        {
            nearPlayer1 = false;
        }

        if (collision.transform.name == "Player2" && !cP.isPlayer1Active())
        {
            nearPlayer2 = true;
        }
        else
        {
            nearPlayer2 = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) // Checks if and which player left the switch area
    {
        if (collision.transform.name == "Player1" && cP.isPlayer1Active())
        {
            nearPlayer1 = false;
        }

        if (collision.transform.name == "Player2" && !cP.isPlayer1Active())
        {
            nearPlayer2 = false;
        }
    }
}
