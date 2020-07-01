using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : MonoBehaviour
{
    public bool cardPlayed;
    public int health;

    // Start is called before the first frame update
    void Start()
    {
        cardPlayed = false;
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
