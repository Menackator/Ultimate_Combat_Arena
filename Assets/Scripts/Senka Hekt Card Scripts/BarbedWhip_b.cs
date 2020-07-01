using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class BarbedWhip_b : MonoBehaviour
{
    // Calls upon the card action when clicked on
    public void DoAction() 
    {
        int targetNum = GameObject.Find("CombatController").GetComponent<CombatController>().targetNum;
        int damageToTarget = 2;
        int playerNum = GameObject.Find("CombatController").GetComponent<CombatController>().playerNum;
        int damageToSelf = 1;

        GameObject.Find("CombatController").GetComponent<CombatController>().playerObjOrder[targetNum].GetComponent<CharacterInfo>().health -= damageToTarget;
        GameObject.Find("CombatController").GetComponent<CombatController>().playerObjOrder[playerNum].GetComponent<CharacterInfo>().health -= damageToSelf;

        Destroy(gameObject);
    }
}
