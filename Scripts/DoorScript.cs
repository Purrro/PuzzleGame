using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;

    [Header("Conditions")]
    [SerializeField] private bool isPlayer1In;
    [SerializeField] private bool isPlayer2In;
    [SerializeField] private bool isDoorUnlocked;

    [Header("Sprites")]
    [SerializeField] private Sprite spriteOff;
    [SerializeField] private Sprite spriteOn;

    [Header("NextScreen")]
    [SerializeField] private string doorTo; // Enter Scene name in Unity



    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();

        isPlayer1In = false;
        isPlayer2In = false;
        isDoorUnlocked = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1In || isPlayer2In)
        {
            mySpriteRenderer.sprite = spriteOn;
        }
        else
        {
            mySpriteRenderer.sprite = spriteOff;
        }


        if (isPlayer1In && isPlayer2In)
        {
            isDoorUnlocked = true;
        }

        if (isPlayer1In && isPlayer2In && isDoorUnlocked)
        {
            SceneManager.LoadScene(doorTo);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            isPlayer1In = true;
        }

        if (collision.gameObject.name == "Player2")
        {
            isPlayer2In = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            isPlayer1In = false;
        }

        if (collision.gameObject.name == "Player2")
        {
            isPlayer2In = false;
        }
    }
}
