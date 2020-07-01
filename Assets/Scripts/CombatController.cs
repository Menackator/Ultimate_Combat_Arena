using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public GameObject SH; // Senka Hekt => 0
    public GameObject TK; // Tatakai => 1
    public GameObject RL; // Rama Lux => 2
    public GameObject AV; // Ansell V'Han => 3
    private GameObject SH_Cam;
    private GameObject TK_Cam;
    private GameObject RL_Cam;
    private GameObject AV_Cam;
    public string targetName = "";
    public string playerName = "";
    public int targetNum = 0;
    public int playerNum = 0;
    public int numOfPlayers = 2; // Always at least one
    public int[] playerOrder = new int[4]; // Used to denote which player is playing which character
    public int[] EndOfTurn_HealthEffect = new int[4];
    public int EndOfTurn_MiscEffect;
    public bool[] charUsed = new bool[4]; // Denotes which characters are being used: 0 = SH, 1 = TK, 2 = RL, 3 = AV
    public GameObject[] playerObjOrder = new GameObject[4]; // Used to store gameobject references
    public GameObject[] playerCamOrder = new GameObject[4]; // Used to store gameobject references

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


        // Finds each player camera
        SH_Cam = GameObject.Find("Senka Hekt/Camera");
        TK_Cam = GameObject.Find("Tatakai/Camera");
        RL_Cam = GameObject.Find("Rama Lux/Camera");
        AV_Cam = GameObject.Find("Ansell V'Han/Camera");

        // Organizes the characters per player order
        for (int i = 0; i < numOfPlayers; i++)
        {

            switch (playerOrder[i])
            {
                case 0: // Senka Hekt
                    playerObjOrder[i] = SH;
                    playerCamOrder[i] = SH_Cam;
                    charUsed[0] = true;
                    break;
                case 1: // Tatakai
                    playerObjOrder[i] = TK;
                    playerCamOrder[i] = TK_Cam;
                    charUsed[1] = true;
                    break;
                case 2: // Rama Lux
                    playerObjOrder[i] = RL;
                    playerCamOrder[i] = RL_Cam;
                    charUsed[2] = true;
                    break;
                case 3: // Ansell V'Han
                    playerObjOrder[i] = AV;
                    playerCamOrder[i] = AV_Cam;
                    charUsed[3] = true;
                    break;
            }

        }

        // Deactivates unused characters
        for (int i = 0; i < playerOrder.Length; i++)
        {
            if (charUsed[i] == false)
            {
                switch (i)
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
    }

    // Start method after each object initializes themselves
    void Start()
    {
        // Sets which player is going first based on settings chosen <-- Currently only works for two players
        // PLACEHOLDER
        playerCamOrder[0].SetActive(true);
        playerCamOrder[1].SetActive(false);
        targetName = playerObjOrder[1].name;
        playerName = playerObjOrder[0].name;
        playerNum = 0;
        targetNum = 1;
    }
    

    // Method changes who is currently playing
    public void SwitchPlayer()
    {
        if (playerCamOrder[0].activeSelf == true)
        {
            playerCamOrder[0].SetActive(false);
            playerCamOrder[1].SetActive(true);
            targetName = playerObjOrder[0].name;
            playerName = playerObjOrder[1].name;
            targetNum = 0;
            playerNum = 1;
            playerObjOrder[1].GetComponent<CharacterInfo>().cardPlayed = false;
        }
        else
        {
            playerCamOrder[0].SetActive(true);
            playerCamOrder[1].SetActive(false);
            targetName = playerObjOrder[1].name;
            playerName = playerObjOrder[0].name;
            targetNum = 1;
            playerNum = 0;
            playerObjOrder[0].GetComponent<CharacterInfo>().cardPlayed = false;
        }
        
    }

    // Method updates the possible effects at the end of the turn
    public void UpdateEndOfTurnEffects(int targetEffect, int playerEffect, int miscEffect)
    {
        for (int i = 0; i < numOfPlayers; i++)
        {
            if (targetName == playerObjOrder[i].name)
            {
                EndOfTurn_HealthEffect[i] += targetEffect;
            }
            if (playerName == playerObjOrder[i].name)
            {
                EndOfTurn_HealthEffect[i] += playerEffect;
            }
            EndOfTurn_MiscEffect += miscEffect;
        }
    }

    // Method ends the turn (round) and starts the next one
    public void EndTurnAndStartNewOne()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
