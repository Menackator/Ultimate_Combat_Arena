using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class GatherDarkness_b : MonoBehaviour
{
    private string target = "";
    private string player = "";

    // Calls upon the card action when clicked on
    public void DoAction() 
    {
        target = GameObject.Find("CombatController").GetComponent<CombatController>().targetName;


        Destroy(gameObject);
    }
}
