using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class BuyTime_b : MonoBehaviour
{
    // Calls upon the card action when clicked on
    public void DoAction() 
    {
        int healSelf = 1;
        int playerNum = GameObject.Find("CombatController").GetComponent<CombatController>().playerNum;

        // Gives health
        GameObject.Find("CombatController").GetComponent<CombatController>().playerObjOrder[playerNum].GetComponent<CharacterInfo>().health += healSelf;

        Destroy(gameObject);
    }
}
