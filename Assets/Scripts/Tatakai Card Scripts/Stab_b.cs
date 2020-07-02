using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Stab_b : MonoBehaviour
{
    // Calls upon the card action when clicked on
    public void DoAction() 
    {
        int damageToTarget = 1;
        int targetNum = GameObject.Find("CombatController").GetComponent<CombatController>().targetNum;
        int playerNum = GameObject.Find("CombatController").GetComponent<CombatController>().playerNum;
        Debug.Log(this.name);

        // Takes away health
        GameObject.Find("CombatController").GetComponent<CombatController>().playerObjOrder[targetNum].GetComponent<CharacterInfo>().health -= damageToTarget;

        // Updates the player's hand
        GameObject.Find("CombatController").GetComponent<CombatController>().playerObjOrder[playerNum].GetComponent<CharacterInfo>().UpdateHand(this.name);

        Destroy(gameObject);
    }
}
