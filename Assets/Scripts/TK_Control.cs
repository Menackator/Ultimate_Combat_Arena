using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TK_Control : MonoBehaviour
{
    public Text Name_Text;
    public Text LP_Text;
    public Text OpponentLP_Text;
    public GameObject DeckButton;
    public GameObject ActionButton;
    public GameObject EndTurnButton;
    private GameObject TK_Cards;
    private GameObject Controller;
    private GameObject Card1;
    private GameObject Card2;
    private GameObject Card3;
    private GameObject Card4;
    private GameObject Card5;
    public Camera Camera;
    public string opponentName;
    public int opponentHealth;


    // Start is called before the first frame update
    void Awake()
    {
        // UI Elements
        Name_Text = GameObject.Find("Tatakai/Camera/P_UI/Character Name").GetComponent<Text>();
        Name_Text.color = new Color32(0, 0, 0, 255);
        Name_Text.text = "Tatakai";
        LP_Text = GameObject.Find("Tatakai/Camera/P_UI/LP").GetComponent<Text>();
        OpponentLP_Text = GameObject.Find("Tatakai/Camera/P_UI/Opponent_LP").GetComponent<Text>();
        Camera = GameObject.Find("Tatakai/Camera").GetComponent<Camera>();
        DeckButton = GameObject.Find("Tatakai/Camera/P_UI/Deck");
        ActionButton = GameObject.Find("Tatakai/Camera/P_UI/Action");
        EndTurnButton = GameObject.Find("Tatakai/Camera/P_UI/EndTurn");

        // Relevant Objects
        TK_Cards = GameObject.Find("Card Database");
        Controller = GameObject.Find("CombatController");

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
    }

    // Method brings up or puts away the player's current hand of cards on screen
    public void BringUpHand(bool state)
    {
        if (state == true)
        {
            Vector3 cameraDirection = Camera.transform.forward;
            Vector3 cameraPosition = Camera.transform.position;
            Quaternion cameraOrientation = Camera.transform.rotation;

            Card1 = Instantiate(TK_Cards.GetComponent<TK_Cards>().Bargain_b, new Vector3(-2, 0, 0) + cameraDirection * 2 + cameraPosition, cameraOrientation);
            Card2 = Instantiate(TK_Cards.GetComponent<TK_Cards>().BuyTime_b, new Vector3(-1, 0, 0) + cameraDirection * 2 + cameraPosition, cameraOrientation);
            Card3 = Instantiate(TK_Cards.GetComponent<TK_Cards>().Kick_b, cameraDirection * 2 + cameraPosition, cameraOrientation);
            Card4 = Instantiate(TK_Cards.GetComponent<TK_Cards>().Slice_b, new Vector3(1, 0, 0) + cameraDirection * 2 + cameraPosition, cameraOrientation);
            Card5 = Instantiate(TK_Cards.GetComponent<TK_Cards>().Stab_b, new Vector3(2, 0, 0) + cameraDirection * 2 + cameraPosition, cameraOrientation);
        }
        else if (state == false)
        {
            Destroy(Card1);
            Destroy(Card2);
            Destroy(Card3);
            Destroy(Card4);
            Destroy(Card5);
        }
    }

    // Time delay coroutine
    IEnumerator WaitFunction(float time)
    {
        GetComponent<CharacterInfo>().cardPlayed = true;
        yield return new WaitForSeconds(time);
        Controller.GetComponent<CombatController>().SwitchPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        opponentName = GameObject.Find("CombatController").GetComponent<CombatController>().targetName;
        int targetNum = GameObject.Find("CombatController").GetComponent<CombatController>().targetNum;
        opponentHealth = GameObject.Find("CombatController").GetComponent<CombatController>().playerObjOrder[targetNum].GetComponent<CharacterInfo>().health;
        Debug.Log(targetNum);
        OpponentLP_Text.text = opponentName + "'s Life Points: " + opponentHealth.ToString() + opponentHealth.ToString();
        LP_Text.text = "Life Points: " + GetComponent<CharacterInfo>().health.ToString();

        // Checks if player clicks a card uses a raycast
        var ray = Camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject.CompareTag("Card") && GetComponent<CharacterInfo>().cardPlayed == false)
            {
                hit.collider.gameObject.SendMessage("DoAction");
                StartCoroutine(WaitFunction(1.0f));
            }
        }
    }
}
