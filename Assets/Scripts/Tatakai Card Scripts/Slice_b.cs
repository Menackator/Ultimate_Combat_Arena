using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Slice_b : MonoBehaviour
{
    // Calls upon the card action when clicked on
    public void DoAction() 
    {
        int damageToTarget = 1;
        int targetNum = GameObject.Find("CombatController").GetComponent<CombatController>().targetNum;

        // Takes away health
        GameObject.Find("CombatController").GetComponent<CombatController>().playerObjOrder[targetNum].GetComponent<CharacterInfo>().health -= damageToTarget;

        Destroy(gameObject);
    }
}
