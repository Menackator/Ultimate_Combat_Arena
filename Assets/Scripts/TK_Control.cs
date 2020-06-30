using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TK_Control : MonoBehaviour
{
    public Text Name_Text;
    public Text LP_Text;
    public Text OpponentLP_Text;
    public int health = 10;
    public string opponentName;
    public int opponentHealth;
    public Camera SH_Camera;

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
        SH_Camera = GameObject.Find("Senka Hekt/Camera").GetComponent<Camera>();
    }

    // Allows the player to see the rest of their deck
    public void Deck()
    {
        Debug.Log("1");
    }

    // Allows for an action to be taken
    public void Action()
    {
        Debug.Log("2");
    }

    // Allows for the player to end the round to start the next one
    public void EndTurn()
    {
        Debug.Log("3");
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if player clicks a card uses a raycast
/*        var ray = SH_Camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == GameObject.FindWithTag("Card"))
            {
                hit.collider.gameObject.SendMessage("DoAction");
            }
        }*/
    }
}
