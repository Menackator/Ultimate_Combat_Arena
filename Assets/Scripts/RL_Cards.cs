using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RL_Cards : MonoBehaviour
{
    public GameObject[] RL_CardChoices = new GameObject[30];

    // Awake is called before start functions
    void Awake()
    {
        RL_CardChoices = Resources.LoadAll<GameObject>("Prefabs/Rama Lux Card Deck") as GameObject[];
    }
}
