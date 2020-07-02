using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SH_Control : MonoBehaviour
{
    public Text Name_Text;
    public Text LP_Text;
    public Text OpponentLP_Text;
    public Text EndOfTurnEffects_Text;
    public GameObject DeckButton;
    public GameObject ActionButton;
    public GameObject EndTurnButton;
    private GameObject Card1;
    private GameObject Card2;
    private GameObject Card3;
    private GameObject Card4;
    private GameObject Card5;
    private GameObject CameraObj;
    public Camera Camera;
    private SH_Cards SH_Cards;
    private CharacterInfo CharacterInfo;
    private CombatController Controller;
    public string opponentName;
    public int opponentHealth;
    private bool cardsDrawn;
    

    // Start is called before the first frame update
    void Awake()
    {
        // UI Elements
        Name_Text = GameObject.Find("Senka Hekt/Camera/P_UI/Character Name").GetComponent<Text>();
        Name_Text.color = new Color32(0, 164, 17, 255);
        Name_Text.text = "Senka Hekt";
        LP_Text = GameObject.Find("Senka Hekt/Camera/P_UI/LP").GetComponent<Text>();
        OpponentLP_Text = GameObject.Find("Senka Hekt/Camera/P_UI/Opponent_LP").GetComponent<Text>();
        EndOfTurnEffects_Text = GameObject.Find("Senka Hekt/Camera/P_UI/EndOfTurn").GetComponent<Text>();
        Camera = GameObject.Find("Senka Hekt/Camera").GetComponent<Camera>();
        CameraObj = GameObject.Find("Senka Hekt/Camera");
        DeckButton = GameObject.Find("Senka Hekt/Camera/P_UI/Deck");
        ActionButton = GameObject.Find("Senka Hekt/Camera/P_UI/Action");
        EndTurnButton = GameObject.Find("Senka Hekt/Camera/P_UI/EndTurn");

        // Relevant Objects
        SH_Cards = GetComponent<SH_Cards>();
        CharacterInfo = GetComponent<CharacterInfo>();
        Controller = GameObject.Find("CombatController").GetComponent<CombatController>();

    }

    // Method used to initialize the decks that the player chose for this character
    public void InitializeDecks()
    {

    }

    // Allows the player to see the rest of their deck
    public void Deck()
    {
        if (ActionButton.activeInHierarchy == true)
        {
            ActionButton.SetActive(false);
            EndTurnButton.SetActive(false);
            DeckButton.GetComponentInChildren<Text>().text = "Back";
        }
        else
        {
            ActionButton.SetActive(true);
            EndTurnButton.SetActive(true);
            DeckButton.GetComponentInChildren<Text>().text = "Deck";
        }
    }

    // Allows for an action to be taken, brings up current cards in hand
    public void Action()
    {
        if (DeckButton.activeInHierarchy == true)
        {
            DeckButton.SetActive(false);
            EndTurnButton.SetActive(false);
            ActionButton.GetComponentInChildren<Text>().text = "Back";
            BringUpHand(true);
        }
        else
        {
            DeckButton.SetActive(true);
            EndTurnButton.SetActive(true);
            ActionButton.GetComponentInChildren<Text>().text = "Action";
            BringUpHand(false);
        }
    }

    // Allows for the player to end the round to start the next one
    public void EndTurn()
    {
        DeckButton.SetActive(false);
        ActionButton.SetActive(false);
        EndTurnButton.SetActive(false);
        StartCoroutine(WaitFunction(1.0f, true));
    }

    // Method brings up or puts away the player's current hand of cards on screen
    public void BringUpHand(bool state)
    {
        if (state == true)
        {
            Vector3 cameraDirection = Camera.transform.forward;
            Vector3 cameraPosition = Camera.transform.position;
            Quaternion cameraOrientation = Camera.transform.rotation;

            Debug.Log(SH_Cards.SH_CardChoices[0].name);
            Card1 = Instantiate(SH_Cards.SH_CardChoices[0], new Vector3(-2, 0, 0) + cameraDirection * 2 + cameraPosition, cameraOrientation);
            Card2 = Instantiate(SH_Cards.SH_CardChoices[1], new Vector3(-1, 0, 0) + cameraDirection * 2 + cameraPosition, cameraOrientation);
            Card3 = Instantiate(SH_Cards.SH_CardChoices[2], cameraDirection * 2 + cameraPosition, cameraOrientation);
            Card4 = Instantiate(SH_Cards.SH_CardChoices[3], new Vector3(1, 0, 0) + cameraDirection * 2 + cameraPosition, cameraOrientation);
            Card5 = Instantiate(SH_Cards.SH_CardChoices[4], new Vector3(2, 0, 0) + cameraDirection * 2 + cameraPosition, cameraOrientation);
            cardsDrawn = true;
        }
        else if (state == false)
        {
            Destroy(Card1);
            Destroy(Card2);
            Destroy(Card3);
            Destroy(Card4);
            Destroy(Card5);
            cardsDrawn = false;
        }
    }

    // Time delay coroutine
    IEnumerator WaitFunction(float time, bool endTurn)
    {
        CharacterInfo.cardPlayed = true;
        yield return new WaitForSeconds(time);
        if (cardsDrawn == true)
        {
            BringUpHand(false);
        }

        ButtonReset();

        if (endTurn == false)
        {
            Controller.SwitchPlayer();
        }
        else
        {
            Controller.EndTurnAndStartNewOne();
        }
    }

    // Method to reset buttons for character switching
    public void ButtonReset()
    {
        DeckButton.SetActive(true);
        ActionButton.SetActive(true);
        EndTurnButton.SetActive(true);
        ActionButton.GetComponentInChildren<Text>().text = "Action";
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraObj.activeSelf == true)
        {
            // GUI Update
            opponentName = Controller.targetName;
            int targetNum = Controller.targetNum;
            opponentHealth = Controller.playerObjOrder[targetNum].GetComponent<CharacterInfo>().health;
            OpponentLP_Text.text = opponentName + "'s Life Points: " + opponentHealth.ToString();
            LP_Text.text = "Life Points: " + CharacterInfo.health.ToString();
            int playerNum = Controller.playerNum;
            int playerHealthEffect = Controller.EndOfTurn_HealthEffect[playerNum];
            int targetHealthEffect = Controller.EndOfTurn_HealthEffect[targetNum];
            int miscHealthEffect = Controller.EndOfTurn_MiscEffect;
            EndOfTurnEffects_Text.text = "End of Turn Effects\n" + "You: " + playerHealthEffect + "\nOpponent: " + targetHealthEffect + "\nEither: " + miscHealthEffect;

            // Checks if player clicks a card uses a raycast
            var ray = Camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Input.GetMouseButtonDown(0))
            {

                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Card") && CharacterInfo.cardPlayed == false)
                {
                    hit.collider.gameObject.SendMessage("DoAction");
                    StartCoroutine(WaitFunction(1.0f, false));
                }
            }
        }
    }
}
