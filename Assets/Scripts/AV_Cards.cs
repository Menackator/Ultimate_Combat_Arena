using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AV_Cards : MonoBehaviour
{
    public GameObject[] AV_CardChoices = new GameObject[30];

    // Awake is called before start functions
    void Awake()
    {
        AV_CardChoices = Resources.LoadAll<GameObject>("Prefabs/Ansell V'Han Card Deck") as GameObject[];
    }
}
