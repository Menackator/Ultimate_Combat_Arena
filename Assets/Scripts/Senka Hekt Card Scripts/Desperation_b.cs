using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Desperation_b : MonoBehaviour
{
    // Calls upon the card action when clicked on
    public void DoAction() 
    {
        int targetNum = GameObject.Find("CombatController").GetComponent<CombatController>().targetNum;
        int damageToTarget = 1;
        int playerNum = GameObject.Find("CombatController").GetComponent<CombatController>().playerNum;
        int playerHealth = GameObject.Find("CombatController").GetComponent<CombatController>().playerObjOrder[playerNum].GetComponent<CharacterInfo>().health;

        if (playerHealth < 0)
        {
            damageToTarget = 2; 
        }

        GameObject.Find("CombatController").GetComponent<CombatController>().playerObjOrder[targetNum].GetComponent<CharacterInfo>().health -= damageToTarget;

        Destroy(gameObject);
    }
}
