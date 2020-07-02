using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : MonoBehaviour
{
    public bool cardPlayed;
    public int health;
    public List<int> deckOriginal = new List<int>(30);
    public List<GameObject> currentHandObj = new List<GameObject>();
    public List<bool> currentHandBool = new List<bool>();

    // Start is called before the first frame update
    void Start()
    {
        cardPlayed = false;
        health = 10;
    }

    // Updates the player's hand when a card is played
    public void UpdateHand(string name)
    {
        for (int i = 0; i < currentHandObj.Count; i++)
        {
            if (name == currentHandObj[i].name)
            {
                currentHandBool[i] = false;
            }
        }
    }
}
