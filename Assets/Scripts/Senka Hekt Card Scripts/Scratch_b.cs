using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Scratch_b: MonoBehaviour
{
    // Calls upon the card action when clicked on
    public void DoAction() 
    {
        int targetNum = GameObject.Find("CombatController").GetComponent<CombatController>().targetNum;
        int damageToTarget = 1;

        GameObject.Find("CombatController").GetComponent<CombatController>().playerObjOrder[targetNum].GetComponent<CharacterInfo>().health -= damageToTarget;


        Destroy(gameObject);
    }
}
