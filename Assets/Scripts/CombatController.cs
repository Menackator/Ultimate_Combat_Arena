using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public GameObject SH; // Senka Hekt => 0
    public GameObject TK; // Tatakai => 1
    public GameObject RL; // Rama Lux => 2
    public GameObject AV; // Ansell V'Han => 3
    public string targetName = "";
    public string playerName = "";
    public int numOfPlayers = 1; // Always at least one
    public int[] playerOrder = new int[4]; // Used to denote which player is playing which character
    public bool[] charUsed = new bool[4]; // Denotes which characters are being used: 0 = SH, 1 = TK, 2 = RL, 3 = AV

    // Start is called before the first frame update
    void Awake()
    {
        // FOR DEBUGGING PURPOSES ----------------------------------------------------------------------
        numOfPlayers = 2;
        playerOrder[0] = 0;
        playerOrder[1] = 1;

        // Finds each character
        SH = GameObject.Find("Senka Hekt");
        TK = GameObject.Find("Tatakai");
        RL = GameObject.Find("Rama Lux");
        AV = GameObject.Find("Ansell V'Han");
        GameObject[] playerObjOrder = new GameObject[numOfPlayers]; // Used to store gameobject references

        // Organizes the characters per player order
        for (int i = 0; i < numOfPlayers; i++)
        {

            switch (playerOrder[i])
            {
                case 0:
                    playerObjOrder[i] = SH;
                    charUsed[0] = true;
                    break;
                case 1:
                    playerObjOrder[i] = TK;
                    charUsed[1] = true;
                    break;
                case 2:
                    playerObjOrder[i] = RL;
                    charUsed[2] = true;
                    break;
                case 3:
                    playerObjOrder[i] = AV;
                    charUsed[3] = true;
                    break;
            }

        }

        // Deactivates unused characters
        for (int i = 0; i < playerOrder.Length; i++)
        {
            if (charUsed[i] == false)
            {
                switch(i)
                {
                    case 0:
                        SH.SetActive(false);
                        break;
                    case 1:
                        TK.SetActive(false);
                        break;
                    case 2:
                        RL.SetActive(false);
                        break;
                    case 3:
                        AV.SetActive(false);
                        break;
                }  
            }
        }

        // Sets which player is going first based on settings chosen
        // PLACEHOLDER
        targetName = TK.name;
        playerName = SH.name;
    }

    // Method changes who is currently playing
    public void switchTurn()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
