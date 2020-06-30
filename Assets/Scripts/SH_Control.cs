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
    public GameObject DeckButton;
    public GameObject ActionButton;
    public GameObject EndTurnButton;
    public GameObject myPrefab;
    public int health = 10;
    public string opponentName;
    public int opponentHealth;
    public Camera Camera;

    // Start is called before the first frame update
    void Start()
    {
        // UI Elements
        Name_Text = GameObject.Find("Senka Hekt/P_UI/Character Name").GetComponent<Text>();
        Name_Text.color = new Color32(0, 164, 17, 255);
        Name_Text.text = "Senka Hekt";
        LP_Text = GameObject.Find("Senka Hekt/P_UI/LP").GetComponent<Text>();
        LP_Text.text = "Life Points: " + health.ToString();
        OpponentLP_Text = GameObject.Find("Senka Hekt/P_UI/Opponent_LP").GetComponent<Text>();
        OpponentLP_Text.text = opponentName + "'s Life Points: " + opponentHealth.ToString();
        Camera = GameObject.Find("Senka Hekt/Camera").GetComponent<Camera>();
        DeckButton = GameObject.Find("Senka Hekt/P_UI/Deck");
        ActionButton = GameObject.Find("Senka Hekt/P_UI/Action");
        EndTurnButton = GameObject.Find("Senka Hekt/P_UI/EndTurn");
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
            Vector3 test = Camera.transform.forward;
            Vector3 test2 = Camera.transform.position;
            Debug.Log(Camera.transform.forward);
            Debug.Log(Camera.transform.position);
            Quaternion cameraOrientation = Camera.transform.rotation;
            Debug.Log(cameraOrientation);

            Instantiate(myPrefab, test * 2 + test2, cameraOrientation);
        }
        else if (state == false)
        {
            Destroy(myPrefab); // FIX THIS
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if player clicks a card uses a raycast
        var ray = Camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == GameObject.FindWithTag("Card"))
            {
                hit.collider.gameObject.SendMessage("DoAction");
            }
        }
    }
}
